namespace Section23.Applications.Tests
{
    public class BookDTO
    {
        public Guid FlightId { get; }
        public string PassengerEmail { get; }
        public int NumberOfSeats { get; }

        public BookDTO(
            Guid flightId,
            string passengerEmail,
            int numberOfSeats)
        {
            FlightId = flightId;
            PassengerEmail = passengerEmail;
            NumberOfSeats = numberOfSeats;
        }
    }
}
