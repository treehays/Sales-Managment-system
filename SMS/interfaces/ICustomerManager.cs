namespace SMS.interfaces
{
    public interface ICustomerManager
    {
        public void CreateCustomer(string firstName, string lastName, string email, string phoneNumber, int pin);
        public void GetCustomer(int staffId);
        public void UpdateCustomer(int staffId, string firstName, string lastName, string phoneNumber);
        public void DeleteCustomer(int staffId);
    }
}