using SMS.model;
using SMS.interfaces;

namespace SMS.implementation
{


    public class CustomerManager : ICustomerManager
    {
        public static List<Customer> listOfCustomer = new List<Customer>();
        public void CreateCustomer(string firstName, string lastName, string email, string phoneNumber, int pin, string address, double wallet)
        {
            int id = listOfCustomer.Count() + 1;
            int staffId = new Random(id).Next(100000);
            Customer customer = new Customer(id, firstName, lastName, staffId, email, phoneNumber, pin, address, wallet);
            listOfCustomer.Add(customer);
            Console.WriteLine($"Dear {firstName}, Registration Successful! \nYour Staff Identity Number is {staffId}, \nKeep it Safe.");

        }

        public void DeleteCustomer(int staffId)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(int staffId)
        {
            throw new NotImplementedException();
        }

        public Customer Login(int staffId, int pin)
        {
            throw new NotImplementedException();
        }

        public Customer Login(string email, int pin)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(int staffId, string firstName, string lastName, string phoneNumber)
        {

        }
    }
}