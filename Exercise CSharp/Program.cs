﻿using System;
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
            Exercise_3();
        }

        static void Exercise_3()
        {
            Console.WriteLine("Introduceti un caracter in consola: ");
            var caracterIntrodus = Console.ReadLine();
            int result = 0;

            if (int.TryParse(caracterIntrodus, out result))
            {
                Console.WriteLine($"Caracterul {result} pe care l-ai introdus este cifra!”");              
            }
            else
                Console.WriteLine($"Caracterul {result} pe care l-ai introdus nu este cifra!");
        }

        static void Exercise_2()
        {
            Console.WriteLine("Introduceti un cuvant in consola: ");
            var cuvantulIntrodus = Console.ReadLine();

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
