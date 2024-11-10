using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PredicateDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> predicate = new Predicate<string>(SearchName);
            //Her hangi bir türden parametre alan ve geriye boolean değer dönen delegelere predicate delege denir. Bir tane parametre alır.

            //var data = predicate.Invoke("ismail");
            //Bu şekilde tetiklendiğinde data değeri true ya da false olur.

            List<string> names = new List<string>(){ "ali", "ayşe", "ismail" };
            
            var name = names.Find(predicate);
            //Predicate'e fonksiyonu atıp, predicate'e predicate'i atıyoruz.
            var name2 = names.Find(SearchName);
            //Fonksiyonu çağırıp, predicate'e fonksiyonu atıyoruz.
            var name3 = names.Find(n => n == "ayşe");
            //Fonksiyonu lambda ile burada oluşturup, predicate'e oluşturduğumuz fonksiyonu atıyoruz.

            Console.WriteLine($"Bulunan isim 1 = {name}\nBulunan isim 2 = {name2}\nBulunan isim 3 = {name3}");
        }

        private static bool SearchName(string name) => name == "ismail";
    }
}
