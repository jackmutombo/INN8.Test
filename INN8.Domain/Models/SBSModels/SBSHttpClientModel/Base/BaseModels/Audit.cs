namespace INN8.Domain.Models.SBSModels.SBSHttpClientModel.Base.BaseModels;

using System;
public class Audit
{
  public DateTime LastUpdated { get; set; }
  public string LastUpdatedBy { get; set; }
  public long DataVersion { get; set; }
}
