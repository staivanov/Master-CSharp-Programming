namespace Flights.Domain
{
    public class Flight
    {
        public int SeatCapacity { get; set; }
        public int RemainingNumbersOfFreeSeats { get; set; }

        public Flight(int seatCapacity)
        {
            SeatCapacity = seatCapacity;
            RemainingNumbersOfFreeSeats = seatCapacity;
        }


        public void Book(string v1, int v2)
        {
            RemainingNumbersOfFreeSeats -= v2;
        }
    }
}
