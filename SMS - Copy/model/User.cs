namespace SMS.model
{
    public class User
    {
        // public int Id { get; set; }

        public string UserId { get; set; }
        public string Pin { get; set; }
        public string Role { get; set; }
        public User(string userId, string pin, string role)
        {

            UserId = userId;
            Pin = pin;
            Role=role;

        }
    }
}