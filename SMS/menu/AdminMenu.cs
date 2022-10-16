using SMS.implementation;
using SMS.interfaces;

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
            Console.WriteLine("\nSuccessfully Login:");

        }
    }
}