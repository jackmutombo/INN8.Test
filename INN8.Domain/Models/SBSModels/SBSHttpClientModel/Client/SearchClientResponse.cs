namespace INN8.Domain.Models.SBSModels.SBSHttpClientModel.Client;

using INN8.Domain.Models.SBSModels.SBSHttpClientModel.Base;
using INN8.Domain.Models.SBSModels.SBSHttpClientModel.Client.ClientModels;

public class SearchClientResponse : ResponseRestBaseAPI
{
  public List<SearchResult> SearchResults { get; set; }
}
