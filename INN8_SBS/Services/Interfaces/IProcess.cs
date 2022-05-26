namespace INN8_SBS.Services.Interfaces;

public interface IProcess<Request, Response>
{
  Task<Response> ProcessAsync();
  void SetRequest();
  void Validate();
  Task<Response> GetResponseAsync();
}
