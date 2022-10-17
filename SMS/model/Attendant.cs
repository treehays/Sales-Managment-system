namespace SMS.model
{
    public class Attendant : User
    {
        public string Post { get; set; }
        // public Attendant(int id, string firstName, string lastName, int staffId, string email, string phoneNumber, int pin, string post, string dateOfBirth, int age) : base(id, firstName, lastName, staffId, email, phoneNumber, pin, dateOfBirth, age)
        public Attendant(int id, string firstName, string lastName, string staffId, string email, string phoneNumber, int pin, string post) : base(id, firstName, lastName, staffId, email, phoneNumber, pin)
        {
            Post = post;
        }

        // public override string ToString()
        // {
        //     return $"{this.FirstName}";
        // }
    }
}