using System;

namespace CAddressBookManagement
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("\"Welcome To The Address Book Program\"\n");

            AddressBookManager obj = new AddressBookManager();

            Persons_Book obj1 = new Persons_Book();
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter City");
            string city = Console.ReadLine();

            Console.WriteLine("Enter State");
            string state = Console.ReadLine();

            Console.WriteLine("Enter Zip/Pin");
            int zip = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Phone Number");
            long phoneNumber = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter Email-ID");
            string eMail = Console.ReadLine();

            obj1.FirstName = firstName;
            obj1.LastName = lastName;
            obj1.City = city;
            obj1.State = state;
            obj1.Zip = zip;
            obj1.PhoneNumber = phoneNumber;
            obj1.Email = eMail;

            obj.AddPersons_Details(obj1);

            obj.Display();

        }
    }
}
