namespace BowlingDesktopClient.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime StartDateTime { get; set; }
        public int HoursToPlay { get; set; }
        public int NoOfPlayers { get; set; }
        public Customer? Customer { get; set; }
        public int PriceId { get; set; }
        public int LaneId { get; set; }

        // Empty constructor
        public Booking() { }

        // Constructor with parameters
        public Booking(DateTime startDateTime, int hoursToPlay, int noOfPlayers, Customer? customer)
        {
            StartDateTime = startDateTime;
            HoursToPlay = hoursToPlay;
            NoOfPlayers = noOfPlayers;
            Customer = customer;

        }
        public Booking(int id, DateTime startDateTime, int hoursToPlay, int noOfPlayers, Customer? customer) : this(startDateTime, hoursToPlay, noOfPlayers, customer)

        {
            Id = id;
        }

        public override string ToString()
        {
            string cusNavn = Customer.FirstName + " " + Customer.LastName;
            string text = "Booking ID:" + Id + ". Start tid: " + StartDateTime + ". Spille Tid: " + HoursToPlay + ". Antal spillere: " + NoOfPlayers + ". Kundens navn: " + cusNavn + ". Pris ID: " + PriceId + ". Bane ID: " + LaneId;
            return text;
        }
    }
       
}

