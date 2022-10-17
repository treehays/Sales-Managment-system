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
            string staffId = new Random(id).Next(100000).ToString();
            Customer customer = new Customer(id, firstName, lastName, staffId, email, phoneNumber, pin, address, wallet);
            listOfCustomer.Add(customer);
            Console.WriteLine($"Dear {firstName}, Registration Successful! \nYour Staff Identity Number is {staffId}, \nKeep it Safe.");

        }

        public void DeleteCustomer(string staffId)
        {
            Customer customer = GetCustomer(staffId);
            if (customer != null)
            {
                Console.WriteLine($"{customer.FirstName} {customer.LastName} Successfully deleted. ");
                listOfCustomer.Remove(customer);
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        public Customer GetCustomer(string staffId)
        {
            foreach (var item in listOfCustomer)
            {
                if (item.StaffId == staffId)
                {
                    return item;
                }
            }
            return null;

        }

        public Customer Login(string staffId, int pin)
        {
            foreach (var item in listOfCustomer)
            {
                if (item.StaffId == staffId && item.Pin == pin)
                {
                    return item;
                }
            }
            return null;

        }



        public void UpdateCustomer(string staffId, string firstName, string lastName, string phoneNumber)
        {
            Customer customer = GetCustomer(staffId);
            if (customer != null)
            {
                customer.FirstName = firstName;
                customer.LastName = lastName;
                customer.PhoneNumber = phoneNumber;
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }
    }
}