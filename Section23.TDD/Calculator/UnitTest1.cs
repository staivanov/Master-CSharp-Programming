using Section23.TDD.Calculator.Domain;
using FluentAssertions;

namespace CalculatorTest
{
    public class UnitTest1
    {
        [Fact]
        public void Sum_of_2_and_2_should_be_4()
        {
            //What do i really want?
            //What my project do?
            Calculator calculator = new();
            int result = calculator.Sum(2, 2),
                expectedResult = 4;

            result.Should().Be(expectedResult);
        }
    }
}