using Microsoft.AspNetCore.Mvc;

namespace First_API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class Operations : Controller
    {
        [HttpPost]
        [Route("api/Add")]
        public double  Add_Number(double Number_1, double Number_2)
        { 
            return Number_1 + Number_2;
        }


        [HttpPost]
        [Route("api/Subtract")]
        public double Subtract_Number(double Number_1, double Number_2)
        {
            return Number_1 - Number_2;
        }

        [HttpPost]
        [Route("api/Multiply")]
        public double Multiply_Number(double Number_1, double Number_2)
        {
            return Number_1 * Number_2;
        }

        [HttpPost]
        [Route("api/Divide")]
        public string Divide_Number(double Number_1, double Number_2)
        {
            if (Number_2 == 0)
            {
                return "Cant not divide by 0 ";
            }
            else
            { 
                return (Number_1 / Number_2).ToString();
            }
        }

    }
}
