namespace INN8_SBS.Services.ClientService.ClientActionMethods;

using INN8.Domain.Models.SBSModels.SBSHttpClientModel.Base.BaseModels;
using INN8.Domain.Models.SBSModels.SBSHttpClientModel.Client;
using INN8.Domain.Models.SBSModels.SBSHttpClientModel.Client.ClientModels;
using INN8.Domain.Models.SBSModels.UserRequestModel;
using INN8_Api_Models.Constants;
using INN8_SBS.Services.Abstract;

public class SearchClientSBSActionMethod : AbstractAPIService<RequestParametersSearchClient, SearchClientRequest, SearchClientResponse>
{
  public SearchClientSBSActionMethod(RequestParametersSearchClient @userobject, HttpClient httpClient, string endPointUrl) : base(@userobject)
  {
    this.httpClient = httpClient;
    this.urlEndpoint = endPointUrl;
  }

  public override void SetRequest()
  {
    if (userRequest.code is not "PROS" || userRequest.code is null)
    {

      _request.SearchCriteria = new SearchCriteria();
      _request.SearchCriteria.Client = new Client();
      _request.SearchCriteria.Client.ClientExternalRef = new ClientExternalRef();
      _request.SearchCriteria.MaxResults = ApplicationConstants.MaxResult;

      if (userRequest.includeAddresses)
      {
        _request.SearchCriteria.IncludeAddresses = true;
      }

      if (userRequest.reference is not null)
      {
        _request.SearchCriteria.Client.ClientExternalRef.Reference = userRequest.reference;
      }

      if (userRequest.referenceCode is not null)
      {
        _request.SearchCriteria.Client.ClientExternalRef.ReferenceCode = userRequest.referenceCode;
      }

      if (userRequest.investTypeCode is not null)
      {
        _request.SearchCriteria.Client.ClientExternalRef.ReferenceCode = userRequest.investTypeCode is "PERS" ? "SAID" : userRequest.investTypeCode is "CORP" ? "SARN" : "SATO";
      }

      if (userRequest.clientSurname is not null)
      {
        _request.SearchCriteria.Client.ClientSurname = userRequest.clientSurname;
      }

      if (userRequest.clientForename is not null)
      {
        _request.SearchCriteria.Client.ClientForename = userRequest.clientForename;
      }

      if (userRequest.sonataId is not null)
      {
        _request.SearchCriteria.Client.Id = Convert.ToInt64(userRequest.sonataId);
      }

      if (userRequest.dateOfBirth is not null && userRequest.dateOfBirth.Value.Year is not 1)
      {
        _request.SearchCriteria.DateOfBirth = userRequest.dateOfBirth.Value;
      }

      if (userRequest.code is not null)
      {
        _request.SearchCriteria.TypeCode = new TypeCode();
        _request.SearchCriteria.TypeCode.Code = userRequest.code;
        _request.SearchCriteria.TypeCode.CodeType = "CLTY";
      }

      _request.SearchCriteria.IncludeExternalReferences = true;

      if (userRequest.accountNo is not null)
      {
        _request.SearchCriteria.Account = new Account();
        _request.SearchCriteria.Account.AccountNumber = new AccountNumber();
        _request.SearchCriteria.Account.AccountNumber.AccountNo = userRequest.accountNo;
      }

      if (userRequest.advisorNumber is not null)
      {
        _request.SearchCriteria.Advisor = new Advisor
        {
          AdvisorNumber = userRequest.advisorNumber
        };
      }

      if (userRequest.advisorId > 0)
      {
        if (_request.SearchCriteria.Advisor is null)
          _request.SearchCriteria.Advisor = new Advisor();

        _request.SearchCriteria.Advisor.Id = userRequest.advisorId;
      }

      if (userRequest.outletID > 0)
      {
        // Weird I know, but we have to map outletID to advisorId field.
        if (_request.SearchCriteria.Advisor is null)
          _request.SearchCriteria.Advisor = new Advisor();

        _request.SearchCriteria.Advisor.Id = userRequest.outletID;
      }

      if (userRequest.emailAddress is not null)
      {
        _request.SearchCriteria.EmailAddress = userRequest.emailAddress;
      }

      if (userRequest.clientIdAsSearchCriteria > 0)
      {
        _request.SearchCriteria.Client.Id = userRequest.clientIdAsSearchCriteria;
      }

      if (userRequest.investTypeCode is not null)
      {
        // If client type is company, return all companies and trusts
        // Companies and trusts have the same typeCode == "COMP"
        // Trusts have investorTypeCode == "TRST"
        // Companies have any investorTypeCode != "TRST"
        // Therefore return all companies and trusts, and filter in the Lib layer.
        if (userRequest.investTypeCode != ApplicationConstants.clientCORPIdentifier)
        {
          _request.SearchCriteria.InvestTypeCode = new InvestTypeCode();
          _request.SearchCriteria.InvestTypeCode.Code = userRequest.investTypeCode;
          _request.SearchCriteria.InvestTypeCode.CodeType = ApplicationConstants.investorTypeCompanycodeType;
        }
      }
    }
  }
}
