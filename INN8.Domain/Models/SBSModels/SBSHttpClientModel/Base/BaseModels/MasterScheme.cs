namespace INN8.Domain.Models.SBSModels.SBSHttpClientModel.Base.BaseModels;

public class MasterScheme
{
  public long Id { get; set; }
  public string Name { get; set; }
  public Audit Audit { get; set; }
  public string DisplayName { get; set; }
  public string LongName { get; set; }
}
