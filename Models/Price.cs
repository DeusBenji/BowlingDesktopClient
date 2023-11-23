namespace BowlingDesktopClient.Models
{
    public class Price
    {
        public int Id { get; set; }
        public double? NormalPrice { get; set; }
        public string? Weekday { get; set; }

        // Empty constructor
        public Price() { }

        // Constructor with parameters
        public Price(double? normalPrice, string? weekday)
        {
            NormalPrice = normalPrice;
            Weekday = weekday;
        }
        //Reuses constructor with id parameter
        public Price(int id, double? normalPrice, string? weekday) : this(normalPrice, weekday)
        {
            Id = id;
        }

        public override string ToString()
        {
            string text = "ID: " + Id + ". Normal Pris: " + NormalPrice +  ". Dag på ugen: " + Weekday;
            return text;
        }

    }
}
