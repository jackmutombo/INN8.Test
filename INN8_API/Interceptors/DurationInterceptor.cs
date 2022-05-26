namespace INN8_API.Interceptors;

using Castle.DynamicProxy;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

public class DurationInterceptor : IInterceptor
{

  private readonly ILogger<DurationInterceptor> _logger;

  public DurationInterceptor(ILogger<DurationInterceptor> logger)
  {
    _logger = logger ?? throw new ArgumentNullException(nameof(logger));
  }

  public void Intercept(IInvocation invocation)
  {
    // before actual method call
    var sw = Stopwatch.StartNew();
    try
    {
      invocation.Proceed();

    }
    finally
    {
      //after actual method call
      sw.Stop();
      _logger.LogInformation("Intercept-- {methodName} took {Duration}ms", invocation.Method.Name, sw.ElapsedMilliseconds);
    }

  }
}
