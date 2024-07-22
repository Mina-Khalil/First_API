using Microsoft.AspNetCore.Mvc;
namespace First_API.Controllers
{
    [ApiController]
    [Route("api/ [Controller]")]
    public class Hello : ControllerBase
    {
        [HttpGet]
   
        public string GetWelcome()
        {
            return "Hello Eng Ramez";
        }

    }
}
