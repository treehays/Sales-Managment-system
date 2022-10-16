namespace SMS.interfaces
{
    public interface IAttendantManager
    {
        public void CreateAttendant(string firstName, string lastName, string email, string phoneNumber, int pin, string post);
        public void GetAttendant(int staffId);
        public void UpdateAttendant(int staffId, string firstName, string lastName, string phoneNumber, int pin);
        public void DeleteAttendant(int staffId);
    }
}