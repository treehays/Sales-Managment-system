using SMS.model;

namespace SMS.interfaces
{
    public interface IAttendantManager
    {
        public void CreateAttendant(string firstName, string lastName, string email, string phoneNumber, string pin, string post);
        public Attendant GetAttendant(string userId);
        public Attendant GetAttendant(string userId, string email);
        public void UpdateAttendant(string userId, string firstName, string lastName, string phoneNumber);
        public void DeleteAttendant(string userId);
        public Attendant Login(string userId, string pin);
        public void ViewAttendant(string userId);
        public void ViewAllAttendants();
    }
}