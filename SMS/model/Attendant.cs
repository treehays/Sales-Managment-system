namespace SMS.model
{
    public class Attendant : User
    {
        public string Post { get; set; }
        public Attendant(int id, string firstName, string lastName, string staffId, string email, string phoneNumber, string pin, string post) : base(id, firstName, lastName, staffId, email, phoneNumber, pin)
        {
            Post = post;
        }
    }
}