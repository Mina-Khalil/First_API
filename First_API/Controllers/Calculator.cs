using Microsoft.AspNetCore.Mvc;
namespace First_API.Controllers
{
    [ApiController]
    [Route("api/ [Controller]")]
    public class Calculator : ControllerBase
    {

        [HttpGet]
        public String CalCulator(double Number1, char N_Operation, double Number2)
        {

            while (true)
            {
                char choice = N_Operation;
                double num1 = Number1;
                double num2 = Number2;
                double Result = 0;

                switch (choice)
                {
                    case '+':
                        Result = num1 + (double)Number2;
                        return Result.ToString();
                    case '-':
                        Result = num1 - (double)Number2;
                        return Result.ToString();
                    case '*':
                        Result = num1 * (double)Number2;
                        return Result.ToString();
                    case '/':
                        if ((double)Number2 != 0)
                        {
                            Result = num1 / (double)Number2;
                            return Result.ToString();
                        }
                        else
                        {
                            return ("Error: Division by zero");
                        }
                    default:
                        return "you chose a mistake operation ";
                }
            }

        }


    }
}
