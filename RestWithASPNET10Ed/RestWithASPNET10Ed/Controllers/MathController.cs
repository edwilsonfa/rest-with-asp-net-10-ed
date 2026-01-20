using Microsoft.AspNetCore.Mvc;
using RestWithASPNET10Ed.Services;
using RestWithASPNET10Ed.Utils;

namespace RestWithASPNET10Ed.Controllers {
    [ApiController]
    [Route("[controller]")]

    public class MathController : ControllerBase {
        private readonly MathServices _services;
        public MathController(MathServices services) {
            _services = services;
        }


        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber) {
            if (NumberHelper.isNumeric(firstNumber) && NumberHelper.isNumeric(secondNumber)){
                var sum = _services.Sum(NumberHelper.ConvertToDecimal(firstNumber),NumberHelper.ConvertToDecimal(secondNumber));
                return Ok(sum);
            }
            return BadRequest("Invalid input");
        }

        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult Subtraction(string firstNumber, string secondNumber) {
            if(NumberHelper.isNumeric(firstNumber) && NumberHelper.isNumeric(secondNumber)){
                var subtraction = _services.Subtraction(NumberHelper.ConvertToDecimal(firstNumber),NumberHelper.ConvertToDecimal(secondNumber));
                return Ok(subtraction);
            }
            return BadRequest("Invalid input");
        }

        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult Division(string firstNumber, string secondNumber) {
            if(NumberHelper.isNumeric(firstNumber) && NumberHelper.isNumeric(secondNumber)) {
                var division = _services.Division(NumberHelper.ConvertToDecimal(firstNumber),NumberHelper.ConvertToDecimal(secondNumber));
                return Ok(division);            }
            return BadRequest("Invalid input");
        }

        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplication(string firstNumber, string secondNumber) {
            if(NumberHelper.isNumeric(firstNumber) && NumberHelper.isNumeric(secondNumber)) {
                var multiplication = _services.Multiplication(NumberHelper.ConvertToDecimal(firstNumber), NumberHelper.ConvertToDecimal(secondNumber));
                return Ok(multiplication);
            }
            return BadRequest("Invalid input");
        }

        [HttpGet("mean/{firstNumber}/{secondNumber}")]
        public IActionResult Average(string firstNumber, string secondNumber) {
            if (NumberHelper.isNumeric(firstNumber) && NumberHelper.isNumeric(secondNumber)) {
                var mean = _services.Mean(NumberHelper.ConvertToDecimal(firstNumber),NumberHelper.ConvertToDecimal(secondNumber));
                return Ok(mean);
            }
            return BadRequest("Invalid input");
        }


        [HttpGet("square-root/{number}")]
        public IActionResult SquareRoot(string number) {
            if (NumberHelper.isNumeric(number)){
                var sqrt = _services.SquareRoot(NumberHelper.ConvertToDecimal(number));
                return Ok(sqrt);
            }
            return BadRequest("Invalid input");
        }

       



    }
}
