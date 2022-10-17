using SMS.model;

namespace SMS.interfaces
{
    public interface ICustomerManager
    {
        public void CreateCustomer(string firstName, string lastName, string email, string phoneNumber, int pin, string address,double wallet);
        public Customer GetCustomer(int staffId);
        public void UpdateCustomer(int staffId, string firstName, string lastName, string phoneNumber);
        public void DeleteCustomer(int staffId);
        public Customer Login (string email,  int pin);
    }
}