using System;

namespace CAddressBookManagement
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("\"Welcome To The Address Book Program\"\n");
            AddressBookManager obj = new AddressBookManager();
            while (true)
            {
                Console.WriteLine("Please Choose Your Option To Perform");
                Console.WriteLine("Enter 1: For Adding the Address");
                Console.WriteLine("Enter 2: For Delete the Address");
                Console.WriteLine("Enter 3: For Display the Address");
                Console.WriteLine("Enter 4: For Edit the Address");
                int num = int.Parse(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        {
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
                        }
                        break;
                    case 2:
                        {
                            obj.Display();
                            Console.WriteLine("Enter The Person Name To Delete");
                            obj.Remove(Console.ReadLine());
                            Console.WriteLine("Address Successfully Deleted\n");
                            obj.Display();
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Welcome To The Address Book Details\n*******************************");
                            obj.Display();
                        }
                        break;
                    case 4:
                        {
                            obj.Display();
                            Console.WriteLine("Enter the First name to Edit");
                            obj.EditPerson(Console.ReadLine());
                            obj.Display();
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Please Enter The Correct Option\n");
                        }
                        break;
                }
            }
        }
    }
}
