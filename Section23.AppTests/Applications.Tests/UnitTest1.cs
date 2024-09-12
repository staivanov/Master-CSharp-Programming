using Flights.Domain;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Section23.Applications.Tests;

namespace Applications.Tests
{
    public class FlightApplicationSpecifications
    {
        [Theory]
        [InlineData("m@m.com", 2)]
        [InlineData("a@m.com", 2)]
        public void Books_flights(string passengerEmail, int numberOfSeats)
        {
            DbContextOptions context = new DbContextOptionsBuilder<Entities>()
                .UseInMemoryDatabase("Flights")
                .Options;

            Entities entities = new (context);
            Flight flight = new(3);
            entities.Flights.Add(flight);

            BookingService bookingService = new(entities: entities);
            bookingService.Book(new BookDTO(flight.Id, passengerEmail, numberOfSeats));

            bookingService.FindBookings(flight.Id)
                .Should()
                .ContainEquivalentOf(new BookingRm(passengerEmail, numberOfSeats));
        }
    }
}