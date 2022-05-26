namespace INN8.Domain.Models.SBSModels.SBSHttpClientModel.Client;

using INN8.Domain.Models.SBSModels.SBSHttpClientModel.Base;
using INN8.Domain.Models.SBSModels.SBSHttpClientModel.Client.ClientModels;

public class SearchClientRequest : RequestRestBaseAPI
{
  public SearchCriteria SearchCriteria { get; set; }
}
