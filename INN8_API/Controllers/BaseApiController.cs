using INN8.Domain.Models.APIModels;
using INN8Lib.Server.Integration;
using Microsoft.AspNetCore.Mvc;

namespace INN8_API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BaseApiController : ControllerBase
  {
    
    protected ActionResult HandleResult<T>(APIResult<T> result)
    {
      if (result == null) return NotFound();
      if (result.IsSuccess && result.Value != null)
        return Ok(result.Value);
      if (result.IsSuccess && result.Value == null)
        return NotFound();
      return BadRequest(result.Error);
    }
  }
}
