using SMS.model;
namespace SMS.interfaces
{
    public interface IAdminManager
    {
        void CreateAdmin(string firstName, string lastName, string email, string phoneNumber, string pin, string post);
        Admin GetAdmin(string staffId);
        void UpdateAdmin(string staffId, string firstName, string lastName, string phoneNumber);
        void DeleteAdmin(string staffId);
        Admin Login(string staffId, string pin);
    }
}