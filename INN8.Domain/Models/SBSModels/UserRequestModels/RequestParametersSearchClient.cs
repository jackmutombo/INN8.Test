namespace INN8.Domain.Models.SBSModels.UserRequestModel;

using INN8.Domain.Models.Base;

public class RequestParametersSearchClient : RequestParametersBase
{
  public string reference { get; set; }
  public string referenceCode { get; set; }
  public string clientSurname { get; set; }
  public string clientForename { get; set; }
  public DateTime? dateOfBirth { get; set; }
  public string accountNo { get; set; }
  public string sonataId { get; set; }
  public bool includeAddresses { get; set; }
  public string code { get; set; }
  public string codeType { get; set; }
  public string advisorNumber { get; set; }
  public long advisorId { get; set; }
  public string emailAddress { get; set; }
  public string investTypeCode { get; set; }
  public long clientIdAsSearchCriteria { get; set; }
  public bool deletedInd { get; set; }

  //Indicator to tell if searching for prospects only
  // If this is true we will only return clients from SBS otherwise we will return both.
  public bool? excludeProspectInd { get; set; }
  public long outletID { get; set; }
}
