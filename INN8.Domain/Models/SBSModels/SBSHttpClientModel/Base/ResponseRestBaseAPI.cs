namespace INN8.Domain.Models.SBSModels.SBSHttpClientModel.Base;

using System.Collections.Generic;

public class ResponseRestBaseAPI
{
  public InvocationSummary InvocationSummary { get; set; }
  public List<ValidationMessage> ValidationMessages { get; set; }
}
