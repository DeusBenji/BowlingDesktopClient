namespace BowlingDesktopClient.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

        //Empty Conscructor
        public Customer()  { }

        // Constructor with parameters
        public Customer(string? firstName, string? lastName, string? email, string? phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
        }
        //Reuses constructor with id parameter
        public Customer(int id, string? firstName, string? lastName, string? email, string? phone) : this(firstName, lastName, email, phone)
        {
            Id = id;
        }

        public override string ToString()
        {
            string text = "Kunde ID: " + Id + ". " + FirstName + " " + LastName + ". Email: " + Email + ". Mobil No. " + Phone;
            return text;
        }
    }
}

