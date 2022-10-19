using SMS.interfaces;
using SMS.implementation;
using SMS.model;
namespace SMS.menu
{
    public class AttendantMenu
    {
        IAttendantManager iAttendantManager = new AttendantManager();
        ITransactionManager iTransactionManager = new TransactionManager();
        // ICustomerManager iCustomerManager = new CustomerManager();

        MainMenu mainMenu = new MainMenu();
        AdminMenu adminMenu = new AdminMenu();

        public void RegisterAttendantPage()
        {
            Console.WriteLine("\nEnter Valid Details..");
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
            iAttendantManager.CreateAttendant(firstName, lastName, email, phoneNumber, pin, post);
            // LoginAdminMenu();

            adminMenu.AdminSubMenu();
        }

        public void DeleteProduct()
        {
            Console.Write("Enter the Barcode of the Product to be deleted.");
            string customerId = Console.ReadLine();


        }



        public void LoginAttendantMenu()
        {
            Console.WriteLine("\nWelcome.\nEnter your Staff ID and Password to login ");
            Console.Write("Staff ID: ");
            string staffId = Console.ReadLine();
            Console.Write("Pin: ");
            int pin = Convert.ToInt32(Console.ReadLine());
            // iAdminManager.Login(staffId,pin); waht is this doing not part of the code
            Attendant attendant = iAttendantManager.Login(staffId, pin);
            if (attendant != null)
            {
                Console.WriteLine($"Welcome {attendant.FirstName}, you've successfully Logged in!");
                AttendantSubMenu(attendant);
            }
            else
            {
                Console.WriteLine($"Wrong Email or Password!.");
            }
        }
        public void AttendantSubMenu(Attendant attendant)
        {
            int choice;
            do
            {
                // Console.Clear();
                Console.WriteLine("...Logged >> Attendant >>");

                Console.WriteLine("\nSemicolon Sales Management System. \nEnter valid option.");
                Console.WriteLine("Enter 1 to Record Sales.\nEnter 2 to Update My Details. \nEnter 3 to View history.\nEnter 4 to Logout.\nEnter 0 to Close.");
                // int choice = Convert.ToInt32(Console.ReadLine());
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    // Console.Clear();
                    Console.WriteLine("Invalid Input\n");
                    AttendantSubMenu(attendant);
                }
                if (choice == 1)
                {
                    // Record Sales
                    // Make Payement
                    Console.WriteLine("...Logged >> Attendant >> Payment Page");
                    Console.Write("Enter RecieptNo: ");
                    string receiptNo = Console.ReadLine();
                    Console.Write("Enter Porduct Barcode: ");
                    string barCode = Console.ReadLine();
                    Console.Write("Quantity: ");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    Console.Write("CustomerName: ");
                    string customerId = Console.ReadLine();
                    iTransactionManager.CreateTransaction(receiptNo, barCode, quantity, customerId);

                    AttendantSubMenu(attendant);
                }
                else if (choice == 2)
                {
                    // Update detail
                    Console.WriteLine("\nWelcome.\nEnter D");
                    Console.Write("First Name: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Last Name: ");
                    string lastName = Console.ReadLine();
                    Console.Write("Phone Number: ");
                    string phoneNumber = Console.ReadLine();
                    // IAttendantManager iAttendantManager = new AttendantManager();
                    iAttendantManager.UpdateAttendant(attendant.StaffId, firstName, lastName, phoneNumber);

                }
                else if (choice == 3)
                {
                    //View Transaction History
                    // View Sales Sales Records
                    iTransactionManager.GetAllTransactions();
                }
                else if (choice == 4)
                {
                    // logout
                    mainMenu.LoginMenu();
                }
            } while (choice != 0);
        }


        /*
                public void CustomerCart()
                {
                    Console.WriteLine(".\nEnter Customer ID: ");
                    string customerId = Console.ReadLine();
                    Console.Write("Enter Product barcode: ");
                    string barCode = Console.ReadLine();
                    Console.Write("Enter Product barcode: ");
                    int quantity = int.Parse(Console.ReadLine());
                    IAttendantManager iAttendantManager = new AttendantManager();
                    iAttendantManager.UpdateAttendant(attendant.StaffId, firstName, lastName, phoneNumber);

                }
                */

        // public void AllAttendant(Attendant attendant)
        // {
        //     Console.WriteLine("Attendant Details.");
        //     AttendantManager attendantManager = new AttendantManager();
        //     attendantManager.ViewAttendant(attendant.StaffId);
        // }

        // public void AttendantDetails ()
        // {

        // }


    }
}