namespace SMS.model
{
    public class Attendant
    {
        public static List<Attendant> listOfAttendant = new List<Attendant>();
        public string UserId { get; set; }
        public string Post { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }


        public Attendant( string firstName, string lastName, string email, string phoneNumber, string post)
        {
            UserId = AttendantIdGenerator();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Post = post;
        }
        private string AttendantIdGenerator()
        {
            return "AT" + new Random().Next(10000, 99999).ToString();
        }
    }
}