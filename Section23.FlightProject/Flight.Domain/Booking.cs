namespace Section23.Flight.Domain
{
    public class Booking
    {
        public string Email { get; set; }
        public int NumberOfSeats { get; set; }


        public Booking(string email, int numberOfSeats)
        {
            Email = email;
            NumberOfSeats = numberOfSeats;
        }
    }
}
