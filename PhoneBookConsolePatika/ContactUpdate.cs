using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookConsolePatika
{
    public static class ContactUpdate
    {
        public static void Updating()
        {
            Console.WriteLine("Lütfen numarasını Güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string name= Console.ReadLine();
            bool check = false;
            foreach (var item in Directory._contact)
            {
                if (item.Surname.ToLower() == name.ToLower() || item.Name.ToLower() == name.ToLower())
                {
                    Console.Write($"{item.PhoneNo} numarasını, güncelemek istediginiz numarayı giriniz: ");
                    item.PhoneNo = Console.ReadLine();
                    Console.WriteLine("Başarıyla güncellendi.\n");
                    check = true;
                    break;
                }
                
                
            }
            if (!check)
            {
                
                    Console.WriteLine("  Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n" +
                                      " * Güncellemeyi sonlandırmak için: (Herhangi bir tuşa basabilirsiniz)\n" +
                                      " * Yeniden denemek için: (2)");
                    var select = Console.ReadLine();
                    if (select == "2")
                    {
                        Updating();
                    }
                    else 
                    {
                    }
                
            }
        }
    }
}
