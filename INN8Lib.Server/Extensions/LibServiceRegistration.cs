namespace INN8Lib.Server.Extensions;

using Castle.DynamicProxy;
using INN8Lib.Server.Integration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

public static class LibServiceRegistration
{
  public static IServiceCollection AddLibServices(this IServiceCollection services, IConfiguration configuration)
  {
    services.TryAddScoped<SearchClientAsync>();
    return services;
  }
}
