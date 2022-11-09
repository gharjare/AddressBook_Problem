using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    public class NewContact
    {
        List<PersonInput> addressbook = new List<PersonInput>(); 
        public void AddRecords()
        {
            PersonInput input = new PersonInput();


            Console.WriteLine("Enter your First Name : ");
            input.fName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name : ");
            input.lName = Console.ReadLine();
            Console.WriteLine("Enter your Address : ");
            input.address = Console.ReadLine();
            Console.WriteLine("Enter your City Name : ");
            input.city = Console.ReadLine();
            Console.WriteLine("Enter your State Name : ");
            input.state = Console.ReadLine();
            Console.WriteLine("Enter your Zip Code : ");
            input.zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Phone Number : ");
            input.phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your Email Address: ");
            input.email = Console.ReadLine();
        }
        public void PrintRecords()
        {
            int i = 1;
            foreach (var record in addressbook)
            {
                Console.WriteLine("\n\nRecord - " + i);
                Console.WriteLine("First Name : " + record.fName);
                Console.WriteLine("Last Name : " + record.lName);
                Console.WriteLine("Address : " + record.address);
                Console.WriteLine("City : " + record.city);
                Console.WriteLine("State : " + record.state);
                Console.WriteLine("Email : " + record.email);
                Console.WriteLine("Zip code : " + record.zip);
                Console.WriteLine("Phone Number : " + record.phoneNumber);
                i++;
            }
        }
    }
}
