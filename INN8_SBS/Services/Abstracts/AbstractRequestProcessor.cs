namespace INN8_SBS.Services.Abstract;

using INN8.Domain.Models.SBSModels.SBSHttpClientModel.Base;
using INN8_SBS.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Polly;
using Polly.Retry;
using System.Text;

public class AbstractRequestProcessor<ResponseObject, RequestObject>
    where ResponseObject : ResponseRestBaseAPI
    where RequestObject : RequestRestBaseAPI
{
  // HttpClient
  public HttpClient httpClient { get; set; }
  public string urlEndpoint { get; set; }

  public string PayloadTemp { get; set; }

  private readonly AsyncRetryPolicy _retryPolicy;

  private const int MaxRetries = 3;

  public AbstractRequestProcessor()
  {
    _retryPolicy = Policy.Handle<HttpRequestException>().WaitAndRetryAsync(MaxRetries, time => TimeSpan.FromSeconds(1));
    //_retryPolicy = Policy.Handle<HttpRequestException>(exception =>
    //{
    //  return false; // condition not to retry
    //}).WaitAndRetryAsync(MaxRetries, time => TimeSpan.FromSeconds(1));
  }

  public virtual Task<ResponseObject> PostAsync(RequestObject _request)
  {
    return _retryPolicy.ExecuteAsync(async () =>
    {
      using var response = await this.SendAsync(HttpMethod.Post, _request).ConfigureAwait(false);
      return await response.ReadContentAs<ResponseObject>().ConfigureAwait(false);
    });

  }

  private Task<HttpResponseMessage> SendAsync(HttpMethod method, RequestRestBaseAPI body)
  {
    // Payload in json format
    var sanitisedBody = JsonConvert.SerializeObject(body, Formatting.None,
      new JsonSerializerSettings
      {
        NullValueHandling = NullValueHandling.Ignore,
        DefaultValueHandling = DefaultValueHandling.Ignore,
        ContractResolver = new LowercaseContractResolver(),
      });
    PayloadTemp = sanitisedBody;
    var content = new StringContent(sanitisedBody, UnicodeEncoding.UTF8, "application/json");
    var request = new HttpRequestMessage(method, $"{httpClient.BaseAddress}{urlEndpoint}")
    {
      Content = content,
    };

    return this.httpClient.SendAsync(request);
  }
}

public class LowercaseContractResolver : DefaultContractResolver
{
  protected override string ResolvePropertyName(string propertyName)
  {
    return propertyName.ToLower();
  }
}
