using SMS.interfaces;
using SMS.model;
namespace SMS.implementation
{
    public class AttendantManager : IAttendantManager
    {
        public static List<Attendant> listOfAttendant = new List<Attendant>();

        public void CreateAttendant(string firstName, string lastName, string email, string phoneNumber, int pin, string post)
        {
            int id = listOfAttendant.Count() + 1;
            int staffId = new Random(id).Next(100000);
            Attendant attendant = new Attendant(id, firstName, lastName, staffId, email, phoneNumber, pin, post);
            listOfAttendant.Add(attendant);
            Console.WriteLine($"Dear {firstName}, Registration Successful! \nYour Staff Identity Number is {staffId}, \nKeep it Safe.");

        }

        public void DeleteAttendant(int staffId)
        {
            Attendant attendant = GetAttendant(staffId);
            if (attendant != null)
            {
                Console.WriteLine($"{attendant.FirstName} {attendant.LastName} Successfully deleted. ");
                listOfAttendant.Remove(attendant);
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        public Attendant GetAttendant(int staffId)
        {
            foreach (var item in listOfAttendant)
            {
                if (item.StaffId == staffId)
                {
                    return item;
                }
            }
            return null;

        }

        public Attendant Login(int staffId, int pin)
        {
            foreach (var item in listOfAttendant)
            {
                if (item.StaffId == staffId && item.Pin == pin)
                {
                    return item;
                }
            }
            return null;
        }

        public void UpdateAttendant(int staffId, string firstName, string lastName, string phoneNumber, int pin)
        {
            Attendant attendant = GetAttendant(staffId);
            if (attendant != null)
            {
                attendant.FirstName = firstName;
                attendant.LastName = lastName;
                attendant.PhoneNumber = phoneNumber;
            }
            else
            {
                Console.WriteLine("User not found.");
            }

        }
    }
}