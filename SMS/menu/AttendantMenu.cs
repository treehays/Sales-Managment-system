using SMS.interfaces;
using SMS.implementation;
using SMS.model;
namespace SMS.menu
{
    public class AttendantMenu
    {
        IAttendantManager iAttendantManager = new AttendantManager();
        ITransactionManager iTransactionManager = new TransactionManager();
        IProductManager iProductManager = new ProductManager();
        public void RegisterAttendantPage()
        {
            Console.WriteLine("\nEnter Valid Details..");
            Console.WriteLine("\nRegister Attendant..");
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("pin: ");
            string pin = Console.ReadLine();
            Console.Write("Post: ");
            string post = Console.ReadLine();
            iAttendantManager.CreateAttendant(firstName, lastName, email, phoneNumber, pin, post);
            // LoginAdminMenu();
            AdminMenu adminMenu = new AdminMenu();
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
            string pin = Console.ReadLine();
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

                Console.WriteLine("\nAZ Sales Management System. \nEnter valid option.");
                Console.WriteLine("Enter 1 to Record Sales.\nEnter 2 to Update My Details. \nEnter 3 to View history.\nEnter 4 to Logout.\nEnter 0 to Close.");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    // Console.Clear();
                    Console.WriteLine("Invalid Input\n");
                    AttendantSubMenu(attendant);
                }
                if (choice == 1)
                {
                    // Record Sales
                    MakeProductPayment();
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
                    iAttendantManager.UpdateAttendant(attendant.StaffId, firstName, lastName, phoneNumber);
                }
                else if (choice == 3)
                {
                    //View Transaction History
                    // View Sales Sales Records
                    Console.WriteLine("\nID\tSTAFF\tFIRST NAME\tLAST NAME\tEMAIL\tPHONE NO");

                    iTransactionManager.GetAllTransactions();
                }
                else if (choice == 4)
                {
                    // logout
                    // LoginAttendantMenu();
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.LoginMenu();
                }
            } while (choice != 0);
        }
        public void MakeProductPayment()
        {
            List<string> listOfBarCodes = new List<string>();
            List<int> listOfQuantities = new List<int>();
            // Customer Details
            Console.WriteLine("...Logged >> Attendant >> Payment Page");
            DateTime dateTime = new DateTime();
            dateTime = DateTime.UtcNow;
            Console.Write("CustomerName: ");
            string customerId = Console.ReadLine();

            bool flag = true;
            while (flag)
            {
                Console.Write("Enter Product Barcode: ");
                string barCode = Console.ReadLine();
                Console.Write("Quantity: ");
                int quantity;
                while (!int.TryParse(Console.ReadLine(), out quantity))
                {
                    Console.WriteLine("wrong input.. Try again.");
                }
                listOfBarCodes.Add(barCode);
                listOfQuantities.Add(quantity);

                Console.Write("Enter 1 to Add More Product else press any key:  ");
                string opt = Console.ReadLine();
                flag = opt == "1" ? true : false;
            }





            var product = iProductManager.GetSelectedProducts(listOfBarCodes);
            // Console.WriteLine($"Amount to be Paid: {quantity * product.Price}");
            Console.Write("Cash Tender: ");
            double cashTender;
            while (!double.TryParse(Console.ReadLine(), out cashTender))
            {
                System.Console.WriteLine("wrong input.. Try again.");
            }
            iTransactionManager.CreateTransaction(listOfBarCodes, listOfQuantities, customerId, cashTender);
        }
        // public void ZZCustomerCart()
        // {
        //     Console.Write("Enter Porduct Barcode: ");
        //     string barCode = Console.ReadLine();
        //     Console.Write("Quantity: ");
        //     int quantity;
        //     while (!int.TryParse(Console.ReadLine(), out quantity))
        //     {
        //         System.Console.WriteLine("wrong input.. Try again.");
        //     }
        // }
    }
}