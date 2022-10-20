using SMS.model;
using SMS.interfaces;
namespace SMS.implementation
{
    public class AdminManager : IAdminManager
    {
        public static List<Admin> listOfAdmin = new List<Admin>();
        public void CreateAdmin(string firstName, string lastName, string email, string phoneNumber, string pin, string post)
        {
            int id = listOfAdmin.Count() + 1;
            string staffId = "AZ" + new Random(id).Next(1100000).ToString();
            Admin admin = new Admin(id, firstName, lastName, staffId, email, phoneNumber, pin, post);
            listOfAdmin.Add(admin);
            Console.WriteLine($"Dear {firstName}, Registration Successful! \nYour Staff Identity Number is {staffId}, \nKeep it Safe.\n");
        }

        public void DeleteAdmin(string staffId)
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

        public Admin GetAdmin(string staffId)
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

        public Admin Login(string staffId, string pin)
        {
            foreach (var item in listOfAdmin)
            {
                if (item.StaffId == staffId.ToUpper() && item.Pin == pin)
                {
                    return item; 
                }
            }
            return null;
        }

        public void UpdateAdmin(string staffId, string firstName, string lastName, string phoneNumber)
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