namespace SMS.model
{
    public class Admin : User
    {
        public static List<Admin> listOfAdmin = new List<Admin>();
        public string UserId { get; set; }
        public string Post { get; set; }
         public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Pin { get; set; }

        // public double Wallet { get; set; }
        public Admin(string userId, string firstName, string lastName, string email, string phoneNumber, string pin, string post) : base(userId)
        {
            Post = post;
            UserId = StaffIdGenerator();
        }
        private string StaffIdGenerator()
        {
            return "AD"+new Random().Next(10000,99999).ToString();
        }
    }
}