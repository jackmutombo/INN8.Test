

namespace BenchMarkTester;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class NewFramework
{
  private static readonly HttpClient _client = new HttpClient();
  public Task<responseNew> GetSmallPayloadAsync()
  {
    _client.DefaultRequestHeaders.Accept.Clear();
    _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

    return _client.GetFromJsonAsync<responseNew>($"http://localhost:5248/api/searchClient");
  }
}

public class responseNew
{
  public Value Value { get; set; }
  public List<object> Formatters { get; set; }
  public List<object> ContentTypes { get; set; }
  public object DeclaredType { get; set; }
  public int StatusCode { get; set; }
}

public class Value
{
  public string Name { get; set; }
  public int SearchResultCount { get; set; }
}