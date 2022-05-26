namespace INN8.Domain.Models.APIModels;
using INN8.Domain.Models.Base;
using System.Security.Claims;
public class ConfiguredRequestParameters
{
  public ConfiguredRequestParameters(RequestParametersBase requestParameters, ClaimsPrincipal principal, bool validateOnly = false)
  {
    RequestParameters = requestParameters;
    RequestParameters.callerDetails_clientID = principal.Claims.FirstOrDefault(c => c.Type == "client_id")?.Value;
    RequestParameters.callerDetails_validateOnly = validateOnly;
  }

  public ConfiguredRequestParameters(RequestParametersBase requestParameters, string callerDetails_clientID, bool validateOnly = false)
  {
    RequestParameters = requestParameters;
    RequestParameters.callerDetails_clientID = callerDetails_clientID;
    RequestParameters.callerDetails_validateOnly = validateOnly;
  }

  public RequestParametersBase RequestParameters { get; set; }
}

