using SMS.implementation;
using SMS.interfaces;
using SMS.model;

namespace SMS.menu
{
    public class AdminMenu
    {
        IAdminManager iAdminManager = new AdminManager();
        IAttendantManager iAttendantManager = new AttendantManager();
        IProductManager iProductManager = new ProductManager();
        MainMenu mainMenu = new MainMenu();
        AttendantMenu attendantMenu = new AttendantMenu();
        ProductMenu productMenu = new ProductMenu();
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



        public void DeleteAttendantMenu()
        {
            Console.Write("Enter Staff ID of the Attendant.");
            string staffId = Console.ReadLine();
            iAttendantManager.DeleteAttendant(staffId);
        }



        public void LoginAdminMenu()
        {
            Console.WriteLine("Welcome.\nEnter your Staff ID and Password to login ");
            Console.Write("Staff ID: ");
            string staffId = Console.ReadLine();
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

            // do
            // {
            // Console.Clear();
            Console.WriteLine("Main Menu >> Login >> Admin >>");
            Console.WriteLine("Welcome..\nSemicolon Sales Management System. \nEnter valid option.");
            Console.WriteLine("Enter 1 to Manage Attendant.\nEnter 2 to Manage Products \n3 to Update My Details. \nEnter 4 to View sales Records.\nEnter 5 to Logout.\nEnter 0 to Close.");
            // int choice = Convert.ToInt32(Console.ReadLine());

            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                // Console.Clear();
                Console.WriteLine("Invalid Input\n");
                AdminSubMenu();
            }
            switch (choice)
            {
                case 0:
                    System.Console.WriteLine("Closed.");
                    break;
                case 1:
                    // Manage Attendant
                    ManageAttendantSubMenu();

                    break;
                case 2:
                    // Manage Products 
                    ManageProductSubMenu();

                    break;
                case 3:
                    // Update detail
                    break;
                case 4:
                    // View Sales Records
                    break;
                case 5:
                    // logout
                    mainMenu.LoginMenu();
                    break;
                default:
                    AdminSubMenu();
                    break;
            }
        }


        public void ManageAttendantSubMenu()
        {
            Console.WriteLine("...>> Admin >> Manage Attendants >>");
            Console.WriteLine("Welcome..\nSemicolon Sales Management System. \nEnter valid option.");
            Console.WriteLine("Enter 1 to Create Attendant.\nEnter 2 to View all attendants. \nEnter 3 to Delete Attendant.\nEnter 4 to Logout.\nEnter 0 to Close.");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                // Console.Clear();
                Console.WriteLine("Invalid Input\n");
                AdminSubMenu();
            }
            switch (choice)
            {
                case 0:
                    System.Console.WriteLine("Closed.");
                    return;
                // break;
                case 1:
                    // Create Attendant                    
                    attendantMenu.RegisterAttendantPage();
                    break;
                case 2:
                    // View All Attendants details
                    //  Console.WriteLine("Attendant Details.");
                    // AttendantManager attendantManager = new AttendantManager();
                    // attendantManager.ViewAttendant(attendant.StaffId);
                    iAttendantManager.ViewAllAttendants();
                    break;
                case 3:
                    // Delete Attendants
                    // iAdminManager.DeleteAdmin();
                    DeleteAttendantMenu();
                    break;
                case 4:
                    // logout
                    mainMenu.LoginMenu();
                    break;
                default:
                    ManageAttendantSubMenu();
                    break;
            }
        }

        public void ManageProductSubMenu()
        {
            Console.WriteLine("...>> Admin >> Manage Product >>");
            Console.WriteLine("Welcome..\nSemicolon Sales Management System. \nEnter valid option.");
            Console.WriteLine("Enter 1 to Add a product .\nEnter 2 to Modify A product \n3  to View all Products. \nEnter 4 to Delete Product.\nEnter 5 to Logout.\nEnter 0 to Close.");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                // Console.Clear();
                Console.WriteLine("Invalid Input\n");
                AdminSubMenu();
            }
            switch (choice)
            {
                case 0:
                    System.Console.WriteLine("Closed.");
                    return;
                // break;
                case 1:
                    // Add Product
                    Console.Write("Product Name: ");
                    string productName = Console.ReadLine();
                    Console.Write("Barcode(Product ID): ");
                    string barCode = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = int.Parse(Console.ReadLine());
                    iProductManager.CreateProduct(barCode, productName, price);
                    break;
                case 2:
                    // View All Attendants details
                    //  Console.WriteLine("Attendant Details.");
                    // AttendantManager attendantManager = new AttendantManager();
                    // attendantManager.ViewAttendant(attendant.StaffId);
                    iAttendantManager.ViewAllAttendants();
                    break;
                case 3:
                    // Delete Attendants
                    // iAdminManager.DeleteAdmin();
                    DeleteAttendantMenu();
                    break;
                case 4:
                    // logout
                    mainMenu.LoginMenu();
                    break;
                default:
                    ManageAttendantSubMenu();
                    break;
            }
        }
    }
}
