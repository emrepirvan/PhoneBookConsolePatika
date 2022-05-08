using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookConsolePatika
{
    public class DisplayAllContacts
    {
        public static void DisplayContactDetails()
        {
            foreach (var c in Directory._contact)
            {
                Console.WriteLine($" {c.Name} {c.Surname} {c.PhoneNo}");
            }
        }
    }
}
