// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchMarkTester;

Console.WriteLine("Hello, World!");
//var tt = new OldFramework().GetSmallPayloadAsync();
var results = BenchmarkRunner.Run<BenchmarkTestttttt>();
Console.ReadKey();


//[MemoryDiagnoser]
public class Demo
{
  [Benchmark]
  public string GetFullStringNormally()
  {
    string output = "";
    for (int i = 0; i < 100; i++)
    {
      output += i;
    }
    return output;
  }

}
