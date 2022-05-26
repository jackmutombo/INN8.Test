namespace INN8Lib.Server.Base;

using INN8.Domain.Models.APIModels;
using INN8.Domain.Models.Base;
public interface IIntegrateAsync<T> where T : LibResponse
{
      Task ProcessAsync(ConfiguredRequestParameters requestParameterBaseLib);

      void SetParameters(RequestParametersBase requestParameterBaseLib);
      void Enrich();

      void MapParameters();

      void Transform();

      Task<APIResult<T>> ProcessAndReturnAsync(ConfiguredRequestParameters requestParameterBaseLib);
}
