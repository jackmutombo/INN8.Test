namespace INN8_SBS.Services.ClientService;

using INN8.Domain.Models.SBSModels.SBSHttpClientModel.Client;
using INN8.Domain.Models.SBSModels.UserRequestModel;

public interface IClientServices
{
  Task<SearchClientResponse> SearchClientAsync(RequestParametersSearchClient userRequest);
}
