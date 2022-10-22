using SMS.interfaces;
using SMS.model;

namespace SMS.implementation
{
    public class UserManager : IUserManager
    {
        public void CreateUser(string userId, string pin, string role)
        {
            User user = new User()
        }

        public User GetUser(string userId)
        {
            throw new NotImplementedException();
        }

        public User LoginUser(string userId, string pin)
        {
            throw new NotImplementedException();
        }
    }
}