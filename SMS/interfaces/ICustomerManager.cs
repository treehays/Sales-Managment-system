using SMS.model;

namespace SMS.interfaces
{
    public interface ICustomerManager
    {
        public void CreateCustomer(string firstName, string lastName, string email, string phoneNumber, int pin, string address,double wallet);
        public Customer GetCustomer(string staffId);
        public void UpdateCustomer(string staffId, string firstName, string lastName, string phoneNumber);
        public void DeleteCustomer(string staffId);
        public Customer Login (string email,  int pin);
    }
}