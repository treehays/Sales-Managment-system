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
            string staffId = new Random(id).Next(100000).ToString();
            Attendant attendant = new Attendant(id, firstName, lastName, staffId, email, phoneNumber, pin, post);
            listOfAttendant.Add(attendant);
            Console.WriteLine($"Attendant Creation was Successful! \nThe Staff Identity Number is {staffId} and pint {pin}, \nKeep it Safe.");
        }
        public void DeleteAttendant(string staffId)
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
        public Attendant GetAttendant(string staffId)
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
        public void ViewAttendant(string staffId)
        {
            foreach (var item in listOfAttendant)
            {
                Console.WriteLine($"{item.FirstName}\t{item.LastName}\t{item.Email}\t{item.StaffId}\t{item.Post}");
                // Console.WriteLine(item.ToString()); 
                // Console.WriteLine(item.ToString());
            }
        }
        // public void ViewAttendant()
        // {
        //     foreach (var item in listOfAttendant)
        //     {
        //         Console.WriteLine($"{item.FirstName}\t{item.LastName}\t{item.Email}\t{item.StaffId}\t{item.Post}");
        //         // Console.WriteLine(item.ToString()); 
        //         // Console.WriteLine(item.ToString());
        //     }
        // }

        public Attendant Login(string staffId, int pin)
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
        public void UpdateAttendant(string staffId, string firstName, string lastName, string phoneNumber)
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

        public void ViewAllAttendants()
        {
            foreach (var item in listOfAttendant)
            {
                Console.WriteLine($"Staff Id: {item.StaffId} {item.LastName} {item.FirstName} {item.Email} {item.PhoneNumber}");
            }
        }
    }
}