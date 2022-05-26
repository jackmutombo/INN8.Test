namespace INN8.Domain.Models.SBSModels.SBSHttpClientModel.Client.ClientModels;

using INN8.Domain.Models.SBSModels.SBSHttpClientModel.Base.BaseModels;

public class PrimaryAddress
{
  public long Id { get; set; }
  public string Operation { get; set; }
  public TypeCode TypeCode { get; set; }
  public bool PrimaryType { get; set; }
  public bool Primary { get; set; }
  public string Line1 { get; set; }
  public string Line2 { get; set; }
  public string Line3 { get; set; }
  public string Line4 { get; set; }
  public string Suburb { get; set; }
  public string City { get; set; }
  public string Postcode { get; set; }
  public State State { get; set; }
  public Country Country { get; set; }
  public string Dpid { get; set; }
  public string BarCode { get; set; }
  public string CareOf { get; set; }
  public Audit Audit { get; set; }
}
