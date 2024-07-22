using Microsoft.AspNetCore.Mvc;

namespace First_API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class AgeCalculate : ControllerBase
    {
        [HttpPost]

       public String Age_Calculate(int Day, int Month, int Year)
        {

            DateTime currentDate = DateTime.Today;
            int Years, Months, Days;
            Years = currentDate.Year - Year;
            Months = currentDate.Month - Month;
            Days = currentDate.Day - Day;






            if (Days < 0)
            {
                Months--;
                Days += DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
            }
            if (Months < 0)
            {
                Years--;
                Months += 12;
            }

            // check your , month, day
            if (Years<0 || Months<0  || Day<0 )
            {
                return "You have entered an incorrect date"; 
            }
            else
            {
                string result = $"{Years} Years, {Months} Months, {Days} Days";
                return result;
            }

        }
    } 
}
