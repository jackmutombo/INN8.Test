using INN8.Domain.Models.APIModels;
using INN8.Domain.Models.Base;
using INN8Lib.Server.Helpers;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace INN8Lib.Server.Base;

public abstract class LibAbstractAsync
{
  public readonly IConfiguration _config;

  protected LibAbstractAsync()
  {
   // _config = config ?? throw new ArgumentNullException(nameof(config));
  }

  public async Task ProcessAsync(ConfiguredRequestParameters requestParameters)
  {

    var requestParametersLib = requestParameters.RequestParameters;

    await SetCallerDetailsAsync(requestParametersLib).ConfigureAwait(false);
    SetParameters(requestParametersLib);
    MapParameters();
    await GetResponseAsync().ConfigureAwait(false);

  }

  public abstract void SetParameters(RequestParametersBase requestParametersLib);

  public abstract void MapParameters();

  public abstract Task GetResponseAsync();

  public Task SetCallerDetailsAsync(RequestParametersBase _requestParameters)
  {
    CallerDetailsConfig CallerDetailconfig = new CallerDetailsConfig();
    //_config.
    //_config.Bind("SBSCallerDetailsConfig", authenticationConfiguration);

    //_requestParameters.callerDetails_username = _config["SBSCallerDetailsConfig:CallerDetailUsername"];
    //_requestParameters.callerDetails_country = _config["SBSCallerDetailsConfig:CallerDetailCountry"];
    //_requestParameters.callerDetails_language = _config["SBSCallerDetailsConfig:CallerDetailsLanguage"];
    //_requestParameters.callerDetails_databaseIdentifier = _config["SBSCallerDetailsConfig:CallerDetailsDatabaseIdentifier"];
    //_requestParameters.callerDetails_usernameAdmin = _config["SBSCallerDetailsConfig:CallerDetailsUsernameAdmin"];
    _requestParameters.callerDetails_username = "demo";
    _requestParameters.callerDetails_country = "za";
    _requestParameters.callerDetails_language = "en";
    _requestParameters.callerDetails_databaseIdentifier = "SonataDatasource";
    _requestParameters.callerDetails_usernameAdmin = "admin";
    return Task.CompletedTask;
  }
}
