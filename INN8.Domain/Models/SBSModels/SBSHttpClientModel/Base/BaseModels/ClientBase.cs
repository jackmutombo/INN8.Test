namespace INN8.Domain.Models.SBSModels.SBSHttpClientModel.Base.BaseModels;

public class ClientBase
{
  public long Id { get; set; }
  public string Name { get; set; }
  public Audit Audit { get; set; }
  public MasterScheme MasterScheme { get; set; }
  public ClientPointer ClientPointer { get; set; }
  public ClientExternalRef ClientExternalRef { get; set; }
  public string ClientSurname { get; set; }
  public string ClientForename { get; set; }
  public string ClientForename2 { get; set; }
  public string ClientTFN { get; set; }
  public string GlobalIntermediaryIDNumber { get; set; }
}
