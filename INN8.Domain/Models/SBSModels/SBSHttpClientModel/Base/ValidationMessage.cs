namespace INN8.Domain.Models.SBSModels.SBSHttpClientModel.Base;

public class ValidationMessage
{
  public string Key { get; set; }
  public string Message { get; set; }
  public string Severity { get; set; }
  public string Locator { get; set; }
  public List<string> Arguments { get; set; }
}
