using Microsoft.AspNetCore.Mvc;

namespace WebApplicationWithSwagger.Controllers
{
    /// <summary>
    /// This is a sample controller to demonstrate Swagger documentation.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        /// <summary>
        /// Returns a simple "hello world" message.
        /// </summary>
        /// <remarks>
        /// This API is used to demonstrate a simple GET request returning a "hello world" message.
        /// </remarks>
        /// <returns>A string with the message "hello world".</returns>
        /// <response code="200">Returns the "hello world" message</response>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("hello world");
        }
    }
}
