namespace INN8.Domain.Models.APIModels.LibResponse;

using INN8.Domain.Models.Base;
using INN8.Domain.Models.SBSModels.SBSHttpClientModel.Client;

public class SearchClientAsyncLibResponse : LibResponse
{
  public string Name { get; set; }
  public int SearchResultCount { get; set; }
}
