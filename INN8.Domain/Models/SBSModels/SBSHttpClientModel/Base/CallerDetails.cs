namespace INN8.Domain.Models.SBSModels.SBSHttpClientModel.Base;

public class CallerDetails
{
  public string OperationName { get; set; }
  public string OperationSource { get; set; }
  public string Username { get; set; }
  public string Country { get; set; }
  public string Language { get; set; }
  public string DatabaseIdentifier { get; set; }
  public System.Collections.Generic.List<string> Roles { get; set; }
  public string ProcessName { get; set; }
  public int InstanceId { get; set; }
  public string CorrelationId { get; set; }
  public bool ValidateOnly { get; set; }
  public string ChangeReference { get; set; }
}
