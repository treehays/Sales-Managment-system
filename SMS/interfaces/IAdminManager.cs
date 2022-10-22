using SMS.model;
namespace SMS.interfaces
{
    public interface IAdminManager
    {
        public void CreateAdmin(string firstName, string lastName, string email, string phoneNumber, string pin, string post);
        public Admin GetAdmin(string userId);
        public Admin GetAdmin(string email, string phoneNumber);
        public void UpdateAdmin(string userId, string firstName, string lastName, string phoneNumber);
        public void DeleteAdmin(string userId);
        public Admin Login(string userId, string pin);
    }
}