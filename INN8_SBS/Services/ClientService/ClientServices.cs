namespace INN8_SBS.Services.ClientService;

using INN8.Domain.Models.SBSModels.SBSHttpClientModel.Client;
using INN8.Domain.Models.SBSModels.UserRequestModel;
using INN8_SBS.Services.ClientService.ClientActionMethods;
using System.Threading.Tasks;

public class ClientServices : IClientServices
{
  private readonly HttpClient _httpClient;
  private const string endpoint_searchClient = "searchClient";

  public ClientServices(HttpClient httpClient)
  {
    _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));

  }

  public Task<SearchClientResponse> SearchClientAsync(RequestParametersSearchClient request)
  {
    return new SearchClientSBSActionMethod(request, _httpClient, endpoint_searchClient).ProcessAsync();
  }
}
