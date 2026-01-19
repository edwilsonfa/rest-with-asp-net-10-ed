using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNET10Ed.Controllers {
    //[ApiController]
    //[Route("[controller]")]

    public class MathControllerV1 : ControllerBase {
    
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber) {
            if (isNumeric(firstNumber) && isNumeric(secondNumber)){
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum);
            }
            return BadRequest("Invalid input");
        }

        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult Subtraction(string firstNumber, string secondNumber) {
            if(isNumeric(firstNumber) && isNumeric(secondNumber)){
                var subtraction = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                return Ok(subtraction);
            }
            return BadRequest("Invalid input");
        }

        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult Division(string firstNumber, string secondNumber) {
            if(isNumeric(firstNumber) && isNumeric(secondNumber)) {
                var division = ConvertToDecimal(firstNumber) /  ConvertToDecimal(secondNumber);
                return Ok(division);            }
            return BadRequest("Invalid input");
        }

        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplication(string firstNumber, string secondNumber) {
            if(isNumeric(firstNumber) && isNumeric(secondNumber)) {
                var multiplication = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                return Ok(multiplication);
            }
            return BadRequest("Invalid input");
        }

        [HttpGet("average/{firstNumber}/{secondNumber}")]
        public IActionResult Average(string firstNumber, string secondNumber) {
            if (isNumeric(firstNumber) && isNumeric(secondNumber)) {
                var average = (ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber)) / 2;
                return Ok(average);
            }
            return BadRequest("Invalid input");
        }


        [HttpGet("square-root/{number}")]
        public IActionResult SquareRoot(string number) {
            if (isNumeric(number)){
                var sqrt = Math.Sqrt((double) ConvertToDecimal(number));
                return Ok(sqrt);
            }
            return BadRequest("Invalid input");
        }

       

        private bool isNumeric(string strNumber)
        {
            decimal decimalValue;
            bool isNumber = decimal.TryParse(
                strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out decimalValue
                );//BR 10,5 - US 10.5
            return isNumber;
        }

        private decimal ConvertToDecimal(string strNumber) {
            decimal decimalValue;
            if(decimal.TryParse(
                strNumber,
               System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out decimalValue)){
                return decimalValue;
            }
            return 0;
        }


    }
}
