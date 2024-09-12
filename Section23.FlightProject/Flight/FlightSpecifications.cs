using Flights.Domain;
using FluentAssertions;
using Section23.Flight.Domain;


namespace FlightTests
{
    public class FlightSpecifications
    {
        [Theory]
        [InlineData(3, 1, 2)]
        public void Booking_reduces_the_number_of_seats(
            int seatCapacity,
            int numberOfSeats,
            int remainingNumberOfSeats)
        {
            Flight flight = new(seatCapacity: seatCapacity);
            string email = "jax@abv.bg";
            flight.Book(email, numberOfSeats);
            int remainingNumberOfFreeSeats = remainingNumberOfSeats;
            flight.RemainingNumbersOfFreeSeats.Should().Be(remainingNumberOfFreeSeats);
        }


        [Fact]
        public void Avoids_overbooking()
        {
            //Given
            Flight flight = new(4);
            //When
            object? expectedError = flight.Book("niki@abv.bg", 5);
            //Then
            expectedError.Should().BeOfType<OverbookingError>();
        }


        [Fact]
        public void Book_flights_successfully()
        {
            Flight flight = new(seatCapacity: 3);
            object? error = flight.Book("jax@abv.bg", 1);
            error.Should().BeNull();
        }


        [Fact]
        public void Remembers_booking()
        {
            Flight flight = new(seatCapacity: 150);
            flight.Book(passengerEmail: "a@b.com", numberOfSeats: 4);

            flight.BookingList.Should().ContainEquivalentOf(new Booking("a@b.com", 4));
        }

        [Theory]
        [InlineData(3, 1, 1, 3)]
        [InlineData(4, 2, 2, 4)]
        [InlineData(7, 5, 4, 6)]
        public void Canceling_bookings_frees_up_the_seats(
            int initialCapacity,
            int numberOfSeatsToBook,
            int numberOfSeatsToCancel,
            int remainingNumberOfSeats)
        {
            //Given
            Flight flight = new(initialCapacity);
            flight.Book(passengerEmail: "a@ab.com", numberOfSeatsToBook);
            //When
            flight.CancelBooking(passengerEmail: "a@b.com", numberOfSeats: numberOfSeatsToCancel);
            //Then
            flight.RemainingNumbersOfFreeSeats.Should().Be(3);
        }


        [Fact]
        public void Doesnt_cancel_booking_for_passenger_who_have_not_booked()
        {
            Flight flight = new(3);
            object error = flight.CancelBooking(passengerEmail: "a@b.com", numberOfSeats: 2);
            error.Should().BeOfType<BookingNotFoundError>();
        }


        [Fact]
        public void Returns_null_when_successfully_cancels_a_booking()
        {
            Flight flight = new(3);
            flight.Book(passengerEmail: "a@b.com", numberOfSeats: 1);
            object error = flight.CancelBooking(passengerEmail: "a@b.com", numberOfSeats: 1);
            error.Should().BeNull();


        }

    }
}