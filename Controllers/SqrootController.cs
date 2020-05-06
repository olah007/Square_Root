using System;
using Microsoft.AspNetCore.Mvc;

namespace SquareRoot.Controllers
{
    public class SqrootController :Controller
    {
        [HttpGet]
        public IActionResult SquareRt()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SquareRt(string firstNumber, string secondNumber)
        {            
            var canConvert = float.TryParse(firstNumber, out float firstNum);
            var canConvert1 = float.TryParse(secondNumber, out float secondNum);

            if(!canConvert | firstNum < 0 |!canConvert1 | secondNum < 0)
            {
                ViewBag.Result = "Error Message: Invalid Inputs!";
            }
            
            else if (firstNum == secondNum)
            {
                ViewBag.Result = "Alert: The square root of both numbers are the same. Kindly input another set of numbers";
            }
            
            else
            {
                var firstSqrt = Math.Sqrt(firstNum);
                var secondSqrt = Math.Sqrt(secondNum);
        
                if (firstSqrt > secondSqrt)
                {
                    ViewBag.Result = $"Result: The number {firstNumber} with Square root {firstSqrt.ToString("F2")} has a higher square root than the number {secondNumber} with square root {secondSqrt.ToString("F2")}";
                }         

                else
                {
                    ViewBag.Result = $"The number {secondNumber} with Square root {secondSqrt.ToString("F2")} has a higher square root than the number {firstNumber} with square root {firstSqrt.ToString("F2")}";
                }   
            }
            return View();       
        }        
    }
}