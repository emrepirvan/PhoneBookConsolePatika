using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookConsolePatika
{
    public static class DeleteContact
    {
        public static void Deleting()
        {

            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string data = Console.ReadLine();
            bool check = false;
            foreach (var item in Directory._contact)
            {
                if (item.Surname.ToLower() == data.ToLower() || item.Name.ToLower() == data.ToLower())
                {
                    Console.Write($"{item.Name} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n) ");
                    char yn = char.Parse(Console.ReadLine().ToLower());
                    if (yn == 'y')
                    {
                        Directory._contact.Remove(item);
                        Console.WriteLine("Başarıyla silindi.\n");
                        check = true;
                        break;
                    }
                    else if (yn == 'n')
                    {
                        check = true;
                        break;
                    }

                }
            }
            if (!check) { 
            Console.WriteLine("  Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n" +
             " * Silmeyi sonlandırmak için: (Her Hangi bir tuşa basabilirsiniz)\n" +
             " * Yeniden denemek için: (2)");
            var select = Console.ReadLine();
            if (select == "2")
            {
                Deleting();
                
            }
            }

        }
    }
}
