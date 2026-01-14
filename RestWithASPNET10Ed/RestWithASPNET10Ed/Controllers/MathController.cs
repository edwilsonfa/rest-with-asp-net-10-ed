using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNET10Ed.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase {
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Get(string firstNumber, string secondNumber) {
            if isNumeric(firstNumber) && isNumeric(secondNumber){
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum);
            }
            return BadRequest("Invalid input");
        }

        private decimal ConvertToDecimal(string firstNumber) {
            throw new NotImplementedException();
        }

        private bool isNumeric(string firstNumber) {
            throw new NotImplementedException();
        }
    }
}
