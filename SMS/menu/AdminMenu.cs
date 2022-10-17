using SMS.implementation;
using SMS.interfaces;
using SMS.model;

namespace SMS.menu
{
    public class AdminMenu
    {
        IAdminManager iAdminManager = new AdminManager();
        MainMenu mainMenu = new MainMenu();
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
            // LoginAdminMenu();
            mainMenu.LoginMenu();
        }


        public void LoginAdminMenu()
        {
            Console.WriteLine("\nWelcome.\nEnter your Staff ID and Password to login ");
            Console.Write("Staff ID: ");
            int staffId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pin: ");
            int pin = Convert.ToInt32(Console.ReadLine());
            // iAdminManager.Login(staffId,pin); waht is this doing not part of the code
            Admin admin = iAdminManager.Login(staffId, pin);
            if (admin != null)
            {
                Console.WriteLine($"Welcome {admin.FirstName}, you've successfully Logged in!");
                AdminSubMenu();
            }
            else
            {
                Console.WriteLine($"Wrong Staff ID or Password!.");
            }
        }




        public void AdminSubMenu()
        {
            int choice;
            do
            {
                // Console.Clear();
                Console.WriteLine("Welcome..\nSemicolon Sales Management System. \nEnter valid option.");
                Console.WriteLine("Enter 1 to Manage Attendant.\nEnter 2 to Update My Details. \n3 View sales Records.\n4 to Logout.\n0 to Close.");
                // int choice = Convert.ToInt32(Console.ReadLine());
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    // Console.Clear();
                    Console.WriteLine("Invalid Input\n");
                    AdminSubMenu();
                }
                if (choice == 1)
                {
                    // Manage Attendant
                }
                else if (choice == 2)
                {
                    // Update detail
                }
                else if (choice == 3)
                {
                    // View Sales Records
                }
                else if (choice == 4)
                {
                    // logout
                    mainMenu.LoginMenu();
                }
            } while (choice != 0);
        }
    }
}