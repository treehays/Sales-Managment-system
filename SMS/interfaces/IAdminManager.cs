namespace SMS.interfaces
{
    public interface IAdminManager
    {
        public void CreateAdmin(string firstName, string lastName, string email, string phoneNumber, int pin, string post, string dateOfBirth);
        public void GetAdmin(int staffId);
        public void UpdateAdmin(int staffId, string firstName, string lastName, string phoneNumber);
        public void DeleteAdmin(int staffId);
    }
}
