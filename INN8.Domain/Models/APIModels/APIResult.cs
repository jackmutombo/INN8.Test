namespace INN8.Domain.Models.APIModels
{
  public class APIResult<T>
  {
    public bool IsSuccess { get; set; }
    public T Value { get; set; }
    public string Error { get; set; }

    public static APIResult<T> Success(T value) => new APIResult<T> { IsSuccess = true, Value = value };
    public static APIResult<T> Failure(string error) => new APIResult<T> { IsSuccess = false, Error = error };
  }
}
