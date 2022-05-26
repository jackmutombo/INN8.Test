namespace INN8.Domain.Models.Base;
using System;
public class RequestParametersBase
{
  public string callerDetails_username { get; set; }
  public string callerDetails_country { get; set; }
  public string callerDetails_language { get; set; }
  public string callerDetails_databaseIdentifier { get; set; }
  public string callerDetails_usernameAdmin { get; set; }
  public string callerDetails_clientID { get; set; }
  public string callerDetails_userid { get; set; }
  public string callerDetails_ipaddress { get; set; }

  public bool callerDetails_validateOnly { get; set; } = false;
}

