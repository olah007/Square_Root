using System;
using Microsoft.AspNetCore.Mvc;

namespace Square_Root.Data
{
    public class SquareRoot : Controller, ISquareRoot
    {
        public string GetSquareRoot(string firstNumber, string secondNumber)
        {
            var result = "";
            var canConvert = float.TryParse(firstNumber, out float firstNum);
            var canConvert1 = float.TryParse(secondNumber, out float secondNum);

            if(!canConvert | firstNum < 0 |!canConvert1 | secondNum < 0)
            {
                result = "Error Message: Invalid Inputs!";
                return result;  
            }
            
            else if (firstNum == secondNum)
            {
                result = "Alert: The square root of both numbers are the same. Kindly input another set of numbers.";
                return result; 
            }
            
            var firstSqrt = Math.Sqrt(firstNum);
            var secondSqrt = Math.Sqrt(secondNum);
    
            if (firstSqrt > secondSqrt)
            {
                result = $"Result: The number {firstNumber} with Square root {firstSqrt.ToString("F2")} has a higher square root than the number {secondNumber} with square root {secondSqrt.ToString("F2")}";
            }         

            else
            {
                result = $"The number {secondNumber} with Square root {secondSqrt.ToString("F2")} has a higher square root than the number {firstNumber} with square root {firstSqrt.ToString("F2")}";
            }
            return result;
        }
    }
}