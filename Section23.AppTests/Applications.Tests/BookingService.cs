using Section23.Applications.Tests;

namespace Applications.Tests
{
    public class BookingService
    {
        private Entities entities;

        public BookingService(Entities entities)
        {
            this.entities = entities;
        }

        public void Book(BookDTO bookDTO)
        {
            if (bookDTO is null)
            {
                throw new ArgumentNullException(nameof(bookDTO));
            }
        }

        public IEnumerable<BookingRm> FindBookings(Guid flightId) => new[]
            {
             new BookingRm("a random string", 23)
            };
    }
}