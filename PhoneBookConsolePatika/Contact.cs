using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookConsolePatika
{
    public class Contact
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNo { get; set; }

        public Contact(string name, string surname, string phoneNo)
        {
            Name = name;
            Surname = surname;
            PhoneNo = phoneNo;
        }
    }
}
