namespace SMS.model
{
    public class Customer : User
    {
        public int Id {get;set;}
        public string Address { get; set; }
        public string CustomerId { get; set; }
        public double Wallet { get; set; }
        public string FirstName;
        public string LastName;
        public string Email;
         public string phoneNumber;
         public int Pin;
        // public Customer(int id, string firstName, string lastName, int staffId, string email, string phoneNumber, int pin, string post, string address, string dateOfBirth, int age, double wallet) : base(id, firstName, lastName, staffId, email, phoneNumber, pin, dateOfBirth, age)
        public Customer(int id, string firstName, string lastName, string email, string customerId, string phoneNumber, int pin, string address, double wallet);
        {
            Address = address;
            Wallet = wallet;
        }
    }
}