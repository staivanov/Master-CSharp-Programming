using Section23.Flight.Domain;

namespace Flights.Domain
{
    public class Flight
    {
        private readonly List<Booking> bookingList = new();
        public List<Booking> BookingList => bookingList;

        public Guid Id { get; }

        [Obsolete("Needed By EF")]
        public Flight()
        {
            
        }
        /// <summary>
        /// Capacity of all possible existing seats.
        /// </summary>
        public int SeatCapacity { get; set; }
        /// <summary>
        /// Remaining numbers of free seats.
        /// </summary>
        public int RemainingNumbersOfFreeSeats { get; set; }

        /// <summary>
        /// Creat a new flight instance.
        /// </summary>
        /// <param name="seatCapacity">Number of all possible existing seats.</param>
        public Flight(int seatCapacity)
        {
            SeatCapacity = seatCapacity;
            RemainingNumbersOfFreeSeats = seatCapacity;
        }

        /// <summary>
        /// Booking by a passenger with his email address and number of reserved seats.
        /// </summary>
        /// <param name="passengerEmail">Email of the passenger.</param>
        /// <param name="numberOfSeats">Number of reserved seats.</param>
        public object? Book(string passengerEmail, int numberOfSeats)
        {
            if (passengerEmail is null)
            {
                throw new ArgumentNullException(nameof(passengerEmail));
            }

            if (numberOfSeats > RemainingNumbersOfFreeSeats)
            {
                return new OverbookingError();
            }

            RemainingNumbersOfFreeSeats -= numberOfSeats;
            BookingList.Add(new Booking(passengerEmail, numberOfSeats));

            return null;
        }

        public object? CancelBooking(string passengerEmail, int numberOfSeats)
        {
            bool isPassengerNotEmailAvailable = !bookingList
                .Any(booking => booking.Email == passengerEmail);

            if (isPassengerNotEmailAvailable)
            {
                return new BookingNotFoundError();
            }

            RemainingNumbersOfFreeSeats += numberOfSeats;

            return null;
        }
    }
}
