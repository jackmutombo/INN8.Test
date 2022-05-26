namespace INN8.Domain.Models.APIModels;

using INN8.Domain.Models.Base;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

public class APIHelpers
{
  public static ConfiguredRequestParameters SetChangeReference(RequestParametersBase model, HttpRequest httpRequest)
  {
    var identity = httpRequest.HttpContext.User;
    var remoteIpAddress = httpRequest.HttpContext.Connection.RemoteIpAddress.ToString();
    string callerDetails_clientID = "";

    //string localpath = GetUri(httpRequest).LocalPath?.ToLowerInvariant() ??= "";
    string localpath = string.Empty;

    if (localpath.Contains("api/staticdata") || localpath.Contains("api/user") || localpath.Contains("api/saveuserregistration"))
    {
      callerDetails_clientID = "clientId";
    }
    else
    {
      var clientId = identity.Claims.FirstOrDefault(c => c.Type == "client_id")?.Value;
      if (!string.IsNullOrEmpty(clientId))
        callerDetails_clientID = identity.Claims.FirstOrDefault(c => c.Type == "client_id")?.Value;
      else
        callerDetails_clientID = new string("Anonymous Client");
    }

    model.callerDetails_userid = identity?.FindFirst(ClaimTypes.Sid)?.Value;
    model.callerDetails_ipaddress = remoteIpAddress;
    return new ConfiguredRequestParameters(model, callerDetails_clientID);
  } 
  public static ConfiguredRequestParameters SetChangeReference(RequestParametersBase model, string clientId)
  {

    string callerDetails_clientID = clientId;   

    return new ConfiguredRequestParameters(model, callerDetails_clientID);
  }

  private static Uri GetUri(HttpRequest request)
  {
    var builder = new UriBuilder();
    builder.Scheme = request.Scheme;
    builder.Host = request.Host.Value;
    builder.Path = request.Path;
    builder.Query = request.QueryString.ToUriComponent();
    return builder.Uri;
  }
}
