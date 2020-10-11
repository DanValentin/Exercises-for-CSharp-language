using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise_1();
            Exercise_2();
        }

        static void Exercise_2()
        {
            Console.WriteLine("Introduceti un cuvant in consola: ");
            var cuvantulIntrodus = Console.ReadLine();
            //int value = Convert.ToInt32(numarulIntrodus);

            if (cuvantulIntrodus.Equals("automation"))
            {
                Console.WriteLine("Cuvantul pe care tu l-ai citit este “automation");
            }
            else
                Console.WriteLine("Este un alt cuvant");
        }

        static void Exercise_1()
        {
            Console.WriteLine("Introduceti un numar: ");
           var numarulIntrodus = Console.ReadLine();
           int value = Convert.ToInt32(numarulIntrodus);

            if (value.Equals(20))
            {
                Console.WriteLine("Numarul introdus este 20!");
            }
            else
                Console.WriteLine("Numarul nu este 20");
        }
    }
}
