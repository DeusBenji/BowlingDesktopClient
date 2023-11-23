namespace BowlingDesktopClient.Models
{
    public class Lane
    {
        public int Id { get; set; }
        public int? LaneNumber { get; set; }

        // Empty Constructor
        public Lane() { }

        // Constructor with LaneNumber parameter
        public Lane(int? inLaneNumber)
        {
            LaneNumber = inLaneNumber;
        }
        // Constructor with Id and LaneNumber parameters
        public Lane(int id, int? inLaneNumber) : this(inLaneNumber)
        {
            Id = id;
        }

        public override string ToString()
        {
            string text = "Bane nummer: " + LaneNumber + ". Banes ID: " + Id;
            return text;
        }

    }
}
