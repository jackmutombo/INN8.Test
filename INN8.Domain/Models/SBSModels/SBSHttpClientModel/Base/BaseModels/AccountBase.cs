namespace INN8.Domain.Models.SBSModels.SBSHttpClientModel.Base.BaseModels;

public class AccountBase
{
  public long Id { get; set; }
  public string Name { get; set; }
  public Audit Audit { get; set; }
  public AccountNumber AccountNumber { get; set; }
  public AccountExternalRef AccountExternalRef { get; set; }
  public StatusCode StatusCode { get; set; }
  public AccountPointer AccountPointer { get; set; }
  public MasterScheme MasterScheme { get; set; }
}
