using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _03.ActionDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Action delegeler herhangi bir tipten değer alıp geriye herhangi bir şey dönmeyen delegelerdir. 16 tane overload'ı vardır.

            Action action = new Action(SelamVer);
            action.Invoke();

            Action<string> action2 = new Action<string>(SelamVer2);
            action2 += SelamVer3;
            action2.Invoke("iak");

            Action<string> action3 = new Action<string>(name =>
            {
                Console.WriteLine("Selam " + name);
            });
            action3.Invoke("Abdullah");

            Action action4 = new Action(() =>
            {
                Console.WriteLine("66");
            });
            action4.Invoke();

        }

        private static void SelamVer()
        {
            Console.WriteLine("Selam İsmail");
        }

        private static void SelamVer2(string name)
        {
            Console.WriteLine($"Selam {name}");
        }

        private static void SelamVer3(string name)
        {
            Console.WriteLine($"Selam {name}, Nasılsın?");
        }
    }
}
