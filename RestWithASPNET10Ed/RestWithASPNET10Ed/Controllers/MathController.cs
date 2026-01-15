using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNET10Ed.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase {
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Get(string firstNumber, string secondNumber) {
            if (isNumeric(firstNumber) && isNumeric(secondNumber)){
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum);
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
