namespace SMS.model
{
    public class Admin : User
    {
        public string Post { get; set; }
        // public Admin(int id, string firstName, string lastName, int staffId, string email, string phoneNumber, int pin, string post, string dateOfBirth, int age) : base(id, firstName, lastName, staffId, email, phoneNumber, pin, dateOfBirth, age)
        public Admin(int id, string firstName, string lastName, int staffId, string email, string phoneNumber, int pin, string post) : base(id, firstName, lastName, staffId, email, phoneNumber, pin)
        {
            Post = post;
        }
    }
}