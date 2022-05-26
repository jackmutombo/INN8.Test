using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace INN8_API.Extensions;

public static class ServicesExtensions
{
  public static void AddProxiedScoped<TInterface, TImplementation>(this IServiceCollection services)
    where TInterface : class
    where TImplementation : class, TInterface
  {
    services.TryAddScoped<TImplementation>();
    services.TryAddScoped(typeof(TInterface), serviceProvider =>
    {
      var proxyGenerator = serviceProvider.GetRequiredService<ProxyGenerator>();
      var actual = serviceProvider.GetRequiredService<TImplementation>();
      var interceptors = serviceProvider.GetServices<IInterceptor>().ToArray();
      return proxyGenerator.CreateInterfaceProxyWithTarget(typeof(TInterface), actual, interceptors);
    });
  }
}
