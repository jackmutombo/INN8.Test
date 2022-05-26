namespace INN8.Domain.Models.SBSModels.SBSHttpClientModel.Base;

public class InvocationSummary
{
  public string Version { get; set; }
  public string InvocationId { get; set; }
  public string CorrelationId { get; set; }
  public int ExecutionTime { get; set; }
  public DateTime Timestamp { get; set; }
  public string Username { get; set; }
}
