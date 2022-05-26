namespace INN8.Domain.Models.SBSModels.SBSHttpClientModel.Base.BaseModels;

public class EntityTypeBase
{
  public long Id { get; set; }
  public string Name { get; set; }
  public Audit Audit { get; set; }
  public string Code { get; set; }
}
