using Microsoft.AspNetCore.Mvc;
using Section23.TDD.Calculator.Domain;


namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculateController : ControllerBase
    {
        [HttpGet("Add/{left}/{right}")]
        public int Get(int left, int right)
        {
            Calculator calculator = new();
            int result = calculator.Sum(left, right);

            return result;
        }
    }
}
