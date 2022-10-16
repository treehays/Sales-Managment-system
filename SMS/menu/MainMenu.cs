namespace SMS.menu
{
    public class MainMenu
    {
        public void AllMainMenu()
        {
            Console.WriteLine("Welcome..\nSemicolon Sales Management System. ");
            Console.WriteLine("Enter 1 to Register.\nEnter 2 to Login.\n3 to Close.");
            // int choice = Convert.ToInt32(Console.ReadLine());
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.Clear();
                Console.WriteLine("Invalid Input\n");
                AllMainMenu();
            }

            if (choice == 1)
            {
                // Register
                RegistrationMenu();
            }
            else if (choice == 2)
            {
                // Login
                LoginMenu();
            }
            else if (choice == 3)
            {
                // Close
                // Console.WriteLine();
                // return;
            }
            else
            {
                // Invalid Choice
                Console.Clear();
                Console.WriteLine("Invalid Input.\n");
                AllMainMenu();
            }
        }


        public void RegistrationMenu()
        {
            AdminMenu adminMenu = new AdminMenu();
            Console.WriteLine("Enter 1 for Admin.\nEnter 2 for Attendant. \nEnter 3 for Customer. \n4 to go back.");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.Clear();
                Console.WriteLine("Invalid Input\n");
                RegistrationMenu();
            }

            if (choice == 1)
            {
                // Admin
                adminMenu.RegisterAdminPage();
                
            }
            else if (choice == 2)
            {
                // Attendant
            }
            else if (choice == 3)
            {
                // Customer
            }
            else if (choice == 4)
            {
                // Go Back
                AllMainMenu();
            }
            else
            {
                // Invalid Choice
                Console.Clear();
                Console.WriteLine("Invalid Input.\n");
                RegistrationMenu();
            }
        }


        public void LoginMenu()
        {
            Console.WriteLine("Enter 1 for Admin.\nEnter 2 for Attendant. \nEnter 3 for Customer. \n4 to go back.");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.Clear();
                Console.WriteLine("Invalid Input\n");
                LoginMenu();
            }

            if (choice == 1)
            {
                // Admin
            }
            else if (choice == 2)
            {
                // Attendant
            }
            else if (choice == 3)
            {
                // Customer
            }
            else if (choice == 4)
            {
                // Go Back
                AllMainMenu();
            }
            else
            {
                // Invalid Choice
                Console.Clear();
                Console.WriteLine("Invalid Input.\n");
                LoginMenu();
            }
        }
























































        // switch (choice)
        // {
        //     case 1:
        //         // Register
        //         break;
        //     case 2:
        //         //Login
        //         break;
        //     case 3:
        //         //close

        //         return;
        //     default:
        //         // Invalid Choice
        //         Console.Clear();
        //         Console.WriteLine("Invalid Input.\n");
        //         AllMainMenu();
        //         break;
        // }
    }
}
