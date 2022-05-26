namespace INN8.Domain.Models.SBSModels.SBSHttpClientModel.Client.ClientModels;

using System;
public class SearchCriteria
{
  public Client Client { get; set; }
  public string Postcode { get; set; }
  public DateTime DateOfBirth { get; set; }
  public TypeCode TypeCode { get; set; }
  public InvestTypeCode InvestTypeCode { get; set; }
  public bool WrapIndicator { get; set; }
  public bool IncludeExternalReferences { get; set; }
  public bool IncludeAddresses { get; set; }
  public string SpinNumber { get; set; }
  public string AbnNumber { get; set; }
  public Account Account { get; set; }
  public Advisor Advisor { get; set; }
  public int MaxResults { get; set; }
  public string GlobalIntermediaryIDNumber { get; set; }
  public string EmailAddress { get; set; }
  public EntityTypeCode EntityTypeCode { get; set; }
}
