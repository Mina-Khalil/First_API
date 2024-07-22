using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Text.Json;

namespace First_API
{
    public enum OperationType
    {
        Add = 1,
        Subtract = 2,
        Multiply = 3,
        Divide = 4
    }

    [ApiController]
    [Route("api/[controller]")]
    public class OperationController : ControllerBase
    {
        private string filePath = "data.json";

        [HttpPost]
        public string Calculate(OperationType operation, double firstNumber, double secondNumber)
        {
            double result;
            switch (operation)
            {
                case OperationType.Add:
                    result = firstNumber + secondNumber;
                    SaveDate(firstNumber, operation, secondNumber, result);
                    return result.ToString();

                case OperationType.Subtract:
                    result = firstNumber - secondNumber;
                    SaveDate(firstNumber, operation, secondNumber, result);
                    return result.ToString();

                case OperationType.Multiply:
                    result = firstNumber * secondNumber;
                    SaveDate(firstNumber, operation, secondNumber, result);
                    return result.ToString();

                case OperationType.Divide:
                    // Check if the Number_2 = 0 
                    if (secondNumber != 0)
                    {
                        result = firstNumber / secondNumber;
                        SaveDate(firstNumber, operation, secondNumber, result);
                        return result.ToString();
                    }
                    else
                    {
                        return "Error: Division by zero";
                    }

                default:
                    return "Invalid operation";
            }
        }

        private void SaveDate(double Num1, OperationType Oper, double Num2, double Resul)
        { 
            
            var dataObject = new
            {
                Number1 = Num1,
                Operator = Oper.ToString(),
                Number2 = Num2,
                Result = Resul
            };

            try
            {
                string jsonString = JsonSerializer.Serialize(dataObject);

                // Check if the file exists
                if (System.IO.File.Exists(filePath))
                {
                    string existingJson = System.IO.File.ReadAllText(filePath);
                    string newJson = existingJson + Environment.NewLine + jsonString;
                    System.IO.File.WriteAllText(filePath, newJson);
                }
                else
                {
                    System.IO.File.WriteAllText(filePath, jsonString);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving data to file");
            }
        }
    }
}
