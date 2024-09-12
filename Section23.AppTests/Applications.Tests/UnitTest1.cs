using Flights.Domain;
using FluentAssertions;
using Section23.Applications.Tests;

namespace Applications.Tests
{
    public class FlightApplicationSpecifications
    {
        [Fact]
        public void Books_flights()
        {
            Entities entities = new Entities();
            Flight flight = new(3);
            entities.Flights.Add(flight);

            BookingService bookingService = new(entities: entities);
            bookingService.Book(new BookDTO(flight.Id, "a@b.com", 2));

            bookingService.FindBookings(flight.Id)
                .Should()
                .ContainEquivalentOf(new BookingRm("a@b.com", 2));

        }
    }
}