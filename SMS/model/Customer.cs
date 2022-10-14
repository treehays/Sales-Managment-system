namespace SMS.model
{
    public class Customer : User
    {
        public string Address { get; set; }
        public Customer(int id, string firstName, string lastName, string staffId, string email, string phoneNumber, int pin, string post, string address, string dateOfBirth, int age) : base(id, firstName, lastName, staffId, email, phoneNumber, pin, dateOfBirth, age)
        {
            Address = address;
        }
    }
}