

namespace BenchMarkTester;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class OldFramework
{
  private static readonly HttpClient _client = new HttpClient();
  public async Task<responseOld> GetSmallPayloadAsync()
  {
    _client.DefaultRequestHeaders.Accept.Clear();
    _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

    var result = await _client.GetFromJsonAsync<responseOld>($"http://localhost/INN8_API/api/searchClient");
    return result;
  }
}

public class responseOld
{
  public int HttpStatusCode { get; set; }
  public bool ShowCustomErrorMessage { get; set; }
  public object ExceptionMessage { get; set; }
  public string ErrorText { get; set; }
  public bool IsInitialData { get; set; }
  public bool Success { get; set; }
  public Data Data { get; set; }
}
public class Data
{
  public string Name { get; set; }
  public int SearchResultCount { get; set; }
}

