using Flights.Domain;
using Section23.Applications.Tests;

namespace Applications.Tests
{
    public class BookingService
    {
        private Entities _entities { get; set; }

        public BookingService(Entities entities)
        {
            _entities  = entities;
        }

        public void Book(BookDTO bookDTO)
        {      
            Flight? flight = _entities.Flights.Find(bookDTO.FlightId);
            flight.Book(bookDTO.PassengerEmail, bookDTO.NumberOfSeats);

            _entities.SaveChanges();
        }


        public IEnumerable<BookingRm> FindBookings(Guid flightId)
        {
            return _entities.Flights?
                .Find(flightId)?
                .BookingList
                .Select(booking => new BookingRm(
                    booking.Email,
                    booking.NumberOfSeats
                    ));
        }
    }
}