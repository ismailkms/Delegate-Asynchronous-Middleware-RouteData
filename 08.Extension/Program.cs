using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Extension
{
    internal class Program
    {
        //Extension => Extension methodlarla bir class'ı genişletebiliriz. Yani ekstra özellikler eklememizi sağlar.
        static void Main(string[] args)
        {
            Matematik matematik = new Matematik();
            int toplam = matematik.Topla(2, 3);
            int carpim = matematik.Carp(2, 5);

            Console.WriteLine($"Toplam= {toplam}\nÇarpım= {carpim}");
        }
    }

    public class Matematik
    {
        public int Topla(int a, int b)
        {
            return a + b;
        }
    }

    //Extension methodu yazdığımız class'ın static olması gerekiyor.
    public static class MatExtension
    {
        //Alt taraftaki this ile başlayan parametre ile ben Matematik class'ını genişletiyorum ve ona Carp methodunu ekliyorum diyoruz.
        public static int Carp(this Matematik matematik, int a, int b)
        {
            return a * b;
        }
    }
}
