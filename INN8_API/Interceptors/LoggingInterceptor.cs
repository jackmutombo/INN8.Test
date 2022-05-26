namespace INN8_API.Interceptors;

using Castle.DynamicProxy;

public class LoggingInterceptor : IInterceptor
{
  private readonly ILogger<LoggingInterceptor> _logger;

  public LoggingInterceptor(ILogger<LoggingInterceptor> logger)
  {
    _logger = logger;
  }

  public void Intercept(IInvocation invocation)
  {
    _logger.LogInformation($"Calling method {invocation.TargetType}.{invocation.Method.Name}.");
    invocation.Proceed();
  }
}
