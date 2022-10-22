using SMS.interfaces;
using SMS.model;

namespace SMS.implementation
{
    public class UserManager : IUserManager
    {
        public void CreateUser(string userId, string pin, string userRole)
        {
            User user = new User(userId,pin,userRole);
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