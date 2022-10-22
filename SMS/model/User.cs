namespace SMS.model
{
    public class User
    {
        // public int Id { get; set; }

        public string UserId { get; set; }
        public string Pin { get; set; }
        public string UserRole { get; set; }
        public User(string userId, string pin, string userRole)
        {

            UserId = userId;
            Pin = pin;
            UserRole=userRole;

        }
    }
}