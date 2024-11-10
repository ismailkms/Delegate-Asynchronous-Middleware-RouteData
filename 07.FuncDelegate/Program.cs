using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FuncDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> func = new Func<string, bool>(SearchForAChar);
            //Func delegeler bir ya da birden fazla parametre alıp geriye herhangi bir türden dönüş yapan delegelerdir. <string,...,bool> burada son girilen(bool) dönüş tipidir. İlk girilen ve aradakilerin hepsi normal parametredir.

            List<string> names = new List<string>() { "ismail", "pelin", "mert", "ayşe" };

            var namesWithAInThem = names.Where(func);
            //Func'e fonksiyonu atıp, func'e func'i atıyoruz.
            var namesWithAInThem2 = names.Where(SearchForAChar);
            //Fonksiyonu çağırıp, func'e fonksiyonu atıyoruz.
            var namesWithEInThem = names.Where(n => n.Contains("e"));
            //Fonksiyonu lambda ile burada oluşturup, func'e oluşturduğumuz fonksiyonu atıyoruz.

            foreach (var name in namesWithAInThem)
            {
                Console.WriteLine($"a içeren isim 1 = {name}\n");
            }

            foreach (var name in namesWithAInThem2)
            {
                Console.WriteLine($"a içeren isim 2 = {name}\n");
            }

            foreach (var name in namesWithEInThem)
            {
                Console.WriteLine($"e içeren isim = {name}\n");
            }
        }

        private static bool SearchForAChar(string arg) => arg.Contains("a");
    }
}
