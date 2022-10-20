namespace SMS.model
{
    public class Admin : User
    {
        public string Post { get; set; }
        public Admin(int id, string firstName, string lastName, string staffId, string email, string phoneNumber, string pin, string post) : base(id, firstName, lastName, staffId, email, phoneNumber, pin)
        {
            Post = post; 
        }
    }
}