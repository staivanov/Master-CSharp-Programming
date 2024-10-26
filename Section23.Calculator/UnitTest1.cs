using Section23.TDD.Calculator.Domain;
using FluentAssertions;

namespace Section23.CalculatorTest
{
    public class UnitTest1
    {

        [Fact]
        public void Sum_of_2_and_2_should_be_4()
        {
            Calculator calculator = new();
            int result = calculator.Sum(2,2);
            int correctResult = 4;

            result.Should().Be(correctResult);
        }
    }
}