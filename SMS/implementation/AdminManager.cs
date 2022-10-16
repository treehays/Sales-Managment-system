using SMS.model;
using SMS.interfaces;
namespace SMS.implementation
{
    public class AdminManager : IAdminManager
    {
        public static List<Admin> listOfAdmin = new List<Admin>();
        public void CreateAdmin(string firstName, string lastName, string email, string phoneNumber, int pin, string post)
        {
            int id = listOfAdmin.Count() + 1;
            int staffId = new Random(id).Next(100000);
            Admin admin = new Admin(id, firstName, lastName, staffId, email, phoneNumber, pin, post);
            Console.WriteLine($"Dear {firstName}, Registration Successful! \nYour Staff Identity Number is {staffId}, \nKeep it Safe.");
        }

        public void DeleteAdmin(int staffId)
        {
            Admin admin = GetAdmin(staffId);
            if (admin != null)
            {
                Console.WriteLine($"{admin.FirstName} {admin.LastName} Successfully deleted. ");
                listOfAdmin.Remove(admin);
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        public Admin GetAdmin(int staffId)
        {
            foreach (var item in listOfAdmin)
            {
                if (item.StaffId == staffId)
                {
                    return item;
                }
            }
            return null;
        }

        public Admin Login(int staffId, int pin)
        {
            foreach (var item in listOfAdmin)
            {
                if (item.StaffId == staffId && item.Pin == pin)
                {
                    return item;
                }
            }
            return null;
        }

        public void UpdateAdmin(int staffId, string firstName, string lastName, string phoneNumber)
        {
            Admin admin = GetAdmin(staffId);
            if (admin != null)
            {
                admin.FirstName = firstName;
                admin.LastName = lastName;
                admin.PhoneNumber = phoneNumber;
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }
    }
}