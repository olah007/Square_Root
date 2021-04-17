using Microsoft.AspNetCore.Mvc;
using Square_Root.Data;

namespace SquareRoot.Controllers
{
    public class SqrootController : Controller
    {
        private readonly ISquareRoot _sqroot;
        public SqrootController(ISquareRoot sqroot)
        {
            _sqroot = sqroot;

        }

        [HttpGet]
        public IActionResult SquareRt()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SquareRt(string firstNumber, string secondNumber)
        {
            ViewBag.Result = _sqroot.GetSquareRoot(firstNumber, secondNumber);
            return View();
        }
    }
}