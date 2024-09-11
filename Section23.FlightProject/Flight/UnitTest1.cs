using Flights.Domain;
using FluentAssertions;

namespace FlightsTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var flight = new Flight(seatCapacity: 4);
            string email = "jax@abv.bg";
            flight.Book(email, 1);
            int remainingNumberOfFreeSeats = 3;
            flight.RemainingNumbersOfFreeSeats.Should().Be(remainingNumberOfFreeSeats);
        }
    }
}