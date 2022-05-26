namespace INN8Lib.Server.Integration;

using BenchmarkDotNet.Attributes;
using INN8.Domain.Models.APIModels;
using INN8.Domain.Models.APIModels.LibResponse;
using INN8.Domain.Models.Base;
using INN8.Domain.Models.LibModels;
using INN8.Domain.Models.SBSModels.SBSHttpClientModel.Client;
using INN8.Domain.Models.SBSModels.UserRequestModel;
using INN8_SBS.Services.ClientService;
using INN8Lib.Server.Base;
using Mapster;
using System.Net.Http;

[MemoryDiagnoser]
public class SearchClientAsync : LibAbstractAsync, IIntegrateAsync<SearchClientAsyncLibResponse>
{
  private SearchClientAsyncLibResponse _searchClientAsyncLibResponse = new();
  private RequestParametersLibSearchClient _requestParametersLibSearchClient;
  private RequestParametersSearchClient _requestSearchAllClient;
  private SearchClientResponse _response;

  private IClientServices _clientService;
  public SearchClientAsync(IClientServices clientService)
  {
    _clientService = clientService ?? throw new ArgumentNullException(nameof(clientService));
  }
  public SearchClientAsync()
  {

  }
  public void Enrich()
  {
  
  }

  public override async Task GetResponseAsync()
  {
    _searchClientAsyncLibResponse.SearchResultCount = (await _clientService.SearchClientAsync(_requestSearchAllClient)).SearchResults.Count;
    _searchClientAsyncLibResponse.Name = new string("It's worked");
  }

  public override void MapParameters()
  {
    _requestSearchAllClient = _requestParametersLibSearchClient.Adapt<RequestParametersLibSearchClient, RequestParametersSearchClient>();
  }

  public async Task<APIResult<SearchClientAsyncLibResponse>> ProcessAndReturnAsync(ConfiguredRequestParameters requestParameterBaseLib)
  {
    await ProcessAsync(requestParameterBaseLib);
    return APIResult<SearchClientAsyncLibResponse>.Success(_searchClientAsyncLibResponse);
  }

  public override void SetParameters(RequestParametersBase requestParametersLib)
  {
    _requestParametersLibSearchClient = (RequestParametersLibSearchClient)requestParametersLib;
  }

  public void Transform()
  {
    
  }
}
