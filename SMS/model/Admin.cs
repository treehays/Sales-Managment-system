namespace SMS.model
{
    public class Admin 
    {
        public static List<Admin> listOfAdmin = new List<Admin>();
        public string UserId { get; set; }
        public string Post { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        // public double Wallet { get; set; }
        public Admin( string firstName, string lastName, string email, string phoneNumber, string post) 
        {
            UserId = StaffIdGenerator();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Post = post;

        }
        private string StaffIdGenerator()
        {
            return "AD" + new Random().Next(10000, 99999).ToString();
        }
    }
}