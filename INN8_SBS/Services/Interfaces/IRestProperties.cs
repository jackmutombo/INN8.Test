namespace INN8_SBS.Services.Interfaces;

public interface IRestProperties<C, T>
{
  /// <summary>
  /// Mandatory Request object
  /// </summary>
  C _request { get; set; }

  /// <summary>
  /// Mandatory Response object
  /// </summary>
  T _response { get; set; }
}
