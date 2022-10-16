using SMS.implementation;
using SMS.interfaces;
using SMS.model;

namespace SMS.menu
{
    public class AdminMenu
    {
        IAdminManager iAdminManager = new AdminManager();
        public void RegisterAdminPage()
        {
            Console.WriteLine("Welcome...");

            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("pin: ");
            int pin = Convert.ToInt32(Console.ReadLine());
            Console.Write("Post: ");
            string post = Console.ReadLine();

            iAdminManager.CreateAdmin(firstName, lastName, email, phoneNumber, pin, post);

            LoginAdminMenu();
        }

        public void LoginAdminMenu()
        {

            Console.WriteLine("\nWelcome.\nEnter your Staff ID and Password to login ");
            Console.Write("Staff Id: ");
            int staffId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pin: ");
            int pin = Convert.ToInt32(Console.ReadLine());
            // iAdminManager.Login(staffId,pin); waht is this doing not part of the code
            Admin admin = iAdminManager.Login(staffId, pin);
            if (admin != null)
            {
                Console.WriteLine($"Welcome {admin.FirstName}, you've successfully Logged in!");
            }
            else
            {
                Console.WriteLine($"Wrong Email or Password!.");
            }

        }
    }
}