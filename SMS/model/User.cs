namespace SMS.model
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Pin { get; set; }
        public string StaffId;
        // public string DateOfBirth { get; set; }
        // public int Age { get; set; }
        // public User(int id, string firstName, string lastName, int staffId, string email, string phoneNumber, int pin, string dateOfBirth, int age)
        public User(int id, string firstName, string lastName, string staffId, string email, string phoneNumber, int pin)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            StaffId = staffId;
            Email = email;
            PhoneNumber = phoneNumber;
            Pin = pin;
            // DateOfBirth = dateOfBirth;
            // Age = age;
        }
    }
}