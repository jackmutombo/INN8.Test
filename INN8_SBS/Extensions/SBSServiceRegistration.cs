namespace INN8_SBS.Extensions;

using Castle.DynamicProxy;
using INN8_SBS.Services.ClientService;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

public static class SBSServiceRegistration
{
  public static IServiceCollection AddSBSServices(this IServiceCollection services, IConfiguration configuration)
  {

    //services.AddProxiedScoped<IClientServices, ClientServices>();
    services.AddScoped<IClientServices, ClientServices>();

    //services.AddInterceptedScope<IClientServices, ClientServices, DurationInterceptor>();
    return services;

  }

  public static void AddInterceptedScope<TInterface, TImplementation, TInterceptor>(this IServiceCollection services)
      where TInterface : class
      where TImplementation : class, TInterface
      where TInterceptor : class, IInterceptor
  {
    services.TryAddSingleton<IProxyGenerator, ProxyGenerator>();
    services.AddScoped<TImplementation>();
    services.TryAddTransient<TInterceptor>();
    services.AddSingleton(provider =>
    {
      var proxyGenerator = provider.GetRequiredService<IProxyGenerator>();
      var impl = provider.GetRequiredService<TImplementation>();
      var interceptor = provider.GetRequiredService<TInterceptor>();
      return proxyGenerator.CreateInterfaceProxyWithTarget<TInterface>(impl, interceptor);
    });

  }

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
