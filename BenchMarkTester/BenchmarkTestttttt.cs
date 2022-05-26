namespace BenchMarkTester;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

[HtmlExporter]
public class BenchmarkTestttttt
{

  [Params(100, 200)]
  public int IterationCount;

  private readonly NewFramework _newClient = new NewFramework();
  private readonly OldFramework _oldClient = new OldFramework();

  [Benchmark]
  public async Task Dotnet6Async()
  {
    for (int i = 0; i < IterationCount; i++)
    {
      await _newClient.GetSmallPayloadAsync();
    }
  }
  [Benchmark]
  public async Task Frame48Async()
  {
    for (int i = 0; i < IterationCount; i++)
    {
      await _oldClient.GetSmallPayloadAsync();
    }
  }
}
