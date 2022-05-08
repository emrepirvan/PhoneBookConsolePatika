using System;

namespace PhoneBookConsolePatika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Telefon Numarası Kaydet
                 Telefon Numarası Sil
                 Telefon Numarası Güncelle
                 Rehber Listeleme (A-Z, Z-A seçimli)
                 Rehberde Arama
                 Başlangıç olarak 5 kişinin numarasını varsayılan olarak ekleyiniz.*/

            Directory._contact.Add(new Contact("Emre", "Pirvan", "123123"));
            Directory._contact.Add(new Contact("Will", "Smith", "234234"));
            Directory._contact.Add(new Contact("Roberto", "Carlos", "345345"));
            Directory._contact.Add(new Contact("Harry", "Potter", "456456"));
            Directory._contact.Add(new Contact("Aragorn", "Arathorn", "567567"));

            HomePage.FirstPage();

        }
    }
}
