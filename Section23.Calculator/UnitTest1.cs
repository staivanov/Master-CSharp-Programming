using Section23.TDD.Calculator.Domain;

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

            if(result != correctResult)
            {
                string errorMessage = $"The Sum(2,2) was expected to be 4, but it's {result}."
                throw new Exception(errorMessage);
            }
        }

        



    

    }
}