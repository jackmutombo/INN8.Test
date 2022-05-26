namespace INN8_API.Controllers;

using INN8.Domain.Models.APIModels;
using INN8.Domain.Models.APIModels.LibResponse;
using INN8.Domain.Models.LibModels;
using INN8_API.Helpers;
using INN8Lib.Server.Integration;
using Microsoft.AspNetCore.Mvc;
using System;

public class ClientController : BaseApiController
{
 
  private readonly SearchClientAsync _searchClientAsync;

  public ClientController(SearchClientAsync searchClientAsync)
  {
    _searchClientAsync = searchClientAsync ?? throw new ArgumentNullException(nameof(searchClientAsync));
  }

  [HttpGet]
  [Route("[action]/searchclient/", Name = "SearchClient")]
  public async Task<ActionResult<APIResult<SearchClientAsyncLibResponse>>> SearchClient()
  {
    var t = Request;
    var request = new RequestParametersLibSearchClient
    {
      accountNo = "IA100639"
    };
    var result = await _searchClientAsync.ProcessAndReturnAsync(APIHelpers.SetChangeReference(request, Request));
    return Ok(HandleResult<SearchClientAsyncLibResponse>(result));
  }
}
