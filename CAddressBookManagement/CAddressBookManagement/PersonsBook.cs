using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace CAddressBookManagement
{
   
    
        public class Persons_Book
        {
            public string FirstName;   //variables
            public string LastName;
            public string City;
            public string State;
            public int Zip;
            public long PhoneNumber;
            public String Email;

            public string Result()
            {
                return "First Name : " + FirstName + "\nLast Name : " + LastName + "\nCity : " + City + "\nState : " + State + "\nZip/Pin : " + Zip + "\nPhoneNumber : " + PhoneNumber + "\nEmail_ID : " + Email + "\n*******************************";
            }

        }

        public class AddressBookManager
        {
            public List<Persons_Book> listName = new List<Persons_Book>();

            public void AddPersons_Details(Persons_Book newPerson)
            {
                listName.Add(newPerson);
                string adding_AllDataIn_JsonFile = JsonConvert.SerializeObject(listName);
                File.WriteAllText(@"E:\BridgeLabzAssignment\AddressBook.json", adding_AllDataIn_JsonFile);
            }

            public AddressBookManager()
            {
                string inAllJsonContent = File.ReadAllText(@"E:\BridgeLabzAssignment\AddressBook.json");
                if (inAllJsonContent.Length > 0)
                {
                    listName = JsonConvert.DeserializeObject<List<Persons_Book>>(inAllJsonContent);
                }
                else
                {
                    listName = new List<Persons_Book>();
                }
            }

        }
    
}
