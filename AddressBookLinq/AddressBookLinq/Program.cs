using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address book LINQ problem");
            AddressBook address = new AddressBook();
            List<Contact> contactlist = new List<Contact>()
            {
                new Contact{ firstname = "Gita", lastname = "Pande", address = "Nandavan", city = "Nagpur", state = "Maharashtra", zip = 440076 ,phonenumber = 1234567890,email = "Gita@gmail.com" },
                new Contact{ firstname = "Sita", lastname = "Shende", address = "Itwari", city = "Wardha", state = "Maharashtra", zip = 440046 ,phonenumber = 6784567890,email = "Sita@gmail.com" },
                new Contact{ firstname = "Meena", lastname = "Dhore", address = "MahalgiNagar", city = "Nagpur", state = "Maharashtra", zip = 440026 ,phonenumber = 7834567890,email = "Mina@gmail.com" },
                new Contact{ firstname = "Tina", lastname = "Bele", address = "SanjayGandhi", city = "Yavatmal", state = "Maharashtra", zip = 440054 ,phonenumber = 9234567890,email = "Teena@gmail.com" },
                new Contact{ firstname = "Ashu", lastname = "Thakre", address = "New Nandavan", city = "Nagpur", state = "Maharashtra", zip = 440032 ,phonenumber = 8234567890,email = "Ashu@gmail.com" }
            };
            address.AddDataTable(contactlist);
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the Program number to get executed \n1.Edit Existing data \n2.Delete Existing data \n3.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        address.EditExistingContact(contactlist);
                        break;
                    case 2:
                        address.DeleteContact("Ashu");
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}