using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Delegate
{
    public delegate void MyDelegateHandler(int number1, int number2);
    //Delegate bir yada birden çok methodu tetikleyen yapıdır. Delegate isimleri geleneksel olarak Handler ile biter.

    internal class Program
    {
        static void Main(string[] args)
        {
            MyDelegateHandler myDelegateHandler = new MyDelegateHandler(Topla);
            myDelegateHandler += Carp;
            myDelegateHandler.Invoke(4, 3);
        }

        //Static bir methodun içinde çalışacak olan methodun static olması gerekir.
        static void Topla(int sayi1, int sayi2)
        {
            Console.WriteLine("Toplam = " + (sayi1 + sayi2));
        }

        static void Carp(int number1, int number2)
        {
            Console.WriteLine($"Çarpım = {number1 * number2}");
        }
    }
}
