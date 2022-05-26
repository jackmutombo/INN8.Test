namespace INN8_SBS.Services.Abstract;

using INN8.Domain.Models.Base;
using INN8.Domain.Models.SBSModels.SBSHttpClientModel.Base;
using INN8_SBS.Services.Interfaces;
using System.Threading.Tasks;

public abstract class AbstractAPIService<UserRequestObject, RequestObject, ResponseObject> : AbstractRequestProcessor<ResponseObject, RequestObject>, IRestProperties<RequestObject, ResponseObject>, IProcess<RequestObject, ResponseObject>
  where RequestObject : RequestRestBaseAPI, new()
  where ResponseObject : ResponseRestBaseAPI, new()
  where UserRequestObject : RequestParametersBase
{
  // Properties (REST)
  public RequestObject _request { get; set; }
  public ResponseObject _response { get; set; }

  // User Request (C#)
  private UserRequestObject _userRequest { get; set; }
  public UserRequestObject userRequest
  {
    get { return _userRequest; }
    set
    {
      _userRequest = value;
      this.SetCallerDetails();
      this.SetParameterType();
    }
  }


  #region Base Methods

  private void SetCallerDetails()
  {
    _request.CallerDetails.Username = _userRequest.callerDetails_username;
    _request.CallerDetails.Country = _userRequest.callerDetails_country;
    _request.CallerDetails.Language = _userRequest.callerDetails_language;
    _request.CallerDetails.DatabaseIdentifier = _userRequest.callerDetails_databaseIdentifier;
    _request.CallerDetails.ChangeReference = _userRequest.callerDetails_clientID;
  }
  private void SetParameterType()
  {
    _userRequest = (UserRequestObject)_userRequest;
  }

  #endregion

  public AbstractAPIService(UserRequestObject @userobject)
  {
    _request = new RequestObject();
    _response = new ResponseObject();

    userRequest = @userobject;
  }

  public Task<ResponseObject> ProcessAsync()
  {
    try
    {
      this.SetRequest();
      this.Validate();
      return this.GetResponseAsync();
    }
    catch (Exception ex)
    {
      throw;
    }
  }

  public abstract void SetRequest();

  public void Validate()
  {
    if (string.IsNullOrEmpty(userRequest.callerDetails_clientID))
    {
      //throw ExceptionHandler.NewException(new Exception("Error callerDetails_clientID not set."));
    }
  }

  public virtual Task<ResponseObject> GetResponseAsync()
  {
    return this.PostAsync(_request);
  }
}
