using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookConsolePatika
{
    public class AddContact
    {
        public static void AddPerson()
        {
            Console.WriteLine("Contact Name");
            string name = Console.ReadLine();
            Console.WriteLine("Contact Surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Contact number");
            string number = Console.ReadLine();

            Directory._contact.Add(new Contact(name, surname, number));
        }

    }
}
