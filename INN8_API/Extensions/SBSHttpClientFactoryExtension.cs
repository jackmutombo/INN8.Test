using INN8_API.Helpers.ConfigurationsClasses;
using INN8_SBS.Services.ClientService;

namespace INN8_API.Extensions
{
  public static class SBSHttpClientFactoryExtension
  {
    public static IServiceCollection AddSBSHttpClientFactory(this IServiceCollection services, IConfiguration configuration)
    {
      services.AddHttpClient<IClientServices, ClientServices>(c =>
      {
        APIUrlSettingConfig clientUrL = new APIUrlSettingConfig();
        configuration.Bind("ApiSettings", clientUrL);
        c.Timeout = new TimeSpan(0, 0, 30);
        c.BaseAddress = new Uri(clientUrL.ClientServiceEndPoint);
        c.DefaultRequestHeaders.Clear();
      });
      return services;
    }
  }
}
