using Calculator_Library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorAppAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorAPIController : ControllerBase
    {
        private readonly CalculatorLib _library;

        public CalculatorAPIController()
        {
            _library = new CalculatorLib();
        }
        [HttpPost]
        [Route("Addition")]
        public IActionResult Addition(int number1, int number2)
        {
            try
            {
                int add = _library.Addition(number1, number2);
                return Ok(add);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("Subtraction")]
        public IActionResult Sub(int number1, int number2)
        {
            try
            {
                return Ok(_library.Subtraction(number1, number2));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("Division")]
        public IActionResult Div(decimal number1, decimal number2)
        {
            try
            {
                return Ok(_library.Division(number1, number2));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("Multiplication")]
        public IActionResult Mul(int number1, int number2)
        {
            try
            {
                return Ok(_library.Multiplication(number1, number2));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
