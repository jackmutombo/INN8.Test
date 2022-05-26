namespace INN8.Domain.Models.SBSModels.SBSHttpClientModel.Base.BaseModels;

public class AdvisorBase
{
  public long Id { get; set; }
  public string Name { get; set; }
  public Audit Audit { get; set; }
  public string AdvisorNumber { get; set; }
  public long ClientId { get; set; }
  public ClientExternalRef ClientExternalRef { get; set; }
  public string ClientForename { get; set; }
  public string ClientSurname { get; set; }
  public MasterScheme MasterScheme { get; set; }
  public string Username { get; set; }
}
