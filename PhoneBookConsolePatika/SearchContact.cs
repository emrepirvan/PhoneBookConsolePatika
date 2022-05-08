using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookConsolePatika
{
    public static class SearchContact
    {
        public static void Searching()
        {
                Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz.\n" +
                  "********************************************** \n" +
                  "İsime göre arama yapmak için: (1) \n" +
                  "Telefon numarasına göre arama yapmak için: (2)");
                var secim = Console.ReadLine();
                if (secim == "1")
                {
                    Console.WriteLine("Bulmak istediğiniz ismi giriniz");
                    var word = Console.ReadLine().ToLower();
                    var matchingContact = Directory._contact.Where(x => x.Name.ToLower().Contains(word)).ToList();
                    foreach (var contact in matchingContact)
                    {
                        Console.WriteLine($"Name         :  {contact.Name}\nSurname      :  {contact.Surname}\nPhone Number :  {contact.PhoneNo}\n");
                    }
                }
                else if (secim == "2")
                {
                    Console.WriteLine("Bulmak istediğiniz Numarayi giriniz");
                    var No = Console.ReadLine();
                    var matchingContact = Directory._contact.Where(x => x.PhoneNo.ToLower().Contains(No)).ToList();
                    foreach (var contact in matchingContact)
                {
                    Console.WriteLine($"Name  :  {contact.Name}\nSurname  :  {contact.Surname}\nPhone Number  :  {contact.PhoneNo}");
                }
                }
                else
                {
                    Console.WriteLine("Geçerli bir Tercih yapınız");
                }
            
        }
    }
}
