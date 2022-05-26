namespace INN8_API.Helpers.ConfigurationsClasses;

using System.Text;

public class APIUrlSettingConfig
{
  public string SBS_API_URL_BASE { get; set; }

  private string clientServiceEndPoint;

  public string ClientServiceEndPoint
  {
    get { return clientServiceEndPoint; }
    set { clientServiceEndPoint = new StringBuilder(SBS_API_URL_BASE).Append(value).ToString(); }
  }

}