using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookConsolePatika
{
    public static class HomePage
    {
        public static void FirstPage()
        {
            Console.WriteLine("**********Telefon_Rehberi*********");
            Console.WriteLine("  Lütfen yapmak istediğiniz işlemi seçiniz :) \n******************************************* \n" +
                "(1) Yeni Numara Kaydetmek\n" +
                "(2) Varolan Numarayı Silmek \n" +
                "(3) Varolan Numarayı Güncelleme \n" +
                "(4) Rehberi Listelemek \n" +
                "(5) Rehberde Arama Yapmak \n" +
                "Uygulamadan Cıkmak için *cikis* yaziniz\n");

            var giris = Console.ReadLine();
            Directory rehber = new Directory();

            while (giris != "cikis")
            {

                switch (giris)
                {
                    case "1":
                        AddContact.AddPerson();
                        break;
                    case "2":
                        DeleteContact.Deleting();
                        break;
                    case "3":
                        ContactUpdate.Updating();
                       break;
                     case "4":
                         DisplayAllContacts.DisplayContactDetails();
                         break;
                    case "5":
                        SearchContact.Searching();
                        break;
                    default:
                        Console.WriteLine("Lütfen Geçerli bir Seçim yapınız");
                        break;
                }
                Console.WriteLine("Başka bir işlem yapabilir  veya 'cikis' yapabilirsiniz");
                giris = Console.ReadLine();

            }
        }
    }
}
