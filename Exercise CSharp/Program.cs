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
            Exercise_4();
            Exercise_5();
            Exercise_6();
            Exercise_7();
            Exercise_8();
            Exercise_9();
            Exercise_10();
            Exercise_11();
            Exercise_12();
            Exercise_13();
            Exercise_14();
            Exercise_16();
            Exercise_17();
            Exercise_18();
            Exercise_19();

        }

        static void Exercise_19()
        {
            int numarulUnu;
            int numarulDoi;
            string operatia;
            ConsoleKeyInfo status;
            float answer;

            while (true)
            {
                Console.Write("Primul numar: ");
                numarulUnu = Convert.ToInt32(Console.ReadLine());
                Console.Write("Numarul doi: ");
                numarulDoi = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ce operatie doriti sa faceti? \n (+, -, /, *): ");
                operatia = Console.ReadLine();

                switch (operatia)
                {
                    case "-":
                        answer = numarulUnu - numarulDoi;
                        break;
                    case "+":
                        answer = numarulUnu + numarulDoi;
                        break;
                    case "/":
                        answer = numarulUnu / numarulDoi;
                        break;
                    case "*":
                        answer = numarulUnu * numarulDoi;
                        break;
                    default:
                        answer = 0;
                        break;
                }

                Console.WriteLine(numarulUnu.ToString() + " " + operatia + " " + numarulDoi.ToString() + " = " + answer.ToString());
                Console.WriteLine("\n\n Do You Want To Break (Y/y)");
                status = Console.ReadKey();
                if (status.Key == ConsoleKey.Y)
                {
                    break;
                }
                Console.Clear();
            }

        }

        static void Exercise_18()
        {
            Console.WriteLine("Introduceti primul numar: ");
            var primulNumar = Console.ReadLine();
            int value1 = Convert.ToInt32(primulNumar);

            Console.WriteLine("Introduceti numarul doi: ");
            var numarDoi = Console.ReadLine();
            int value2 = Convert.ToInt32(numarDoi);

            Console.WriteLine("Introduceti numarul trei: ");
            var numarTrei = Console.ReadLine();
            int value3 = Convert.ToInt32(numarTrei);


            int[] numbers = new int[3] { value1, value2, value3 };

            Array.Sort(numbers);

            foreach (int val in numbers)
            {
                Console.WriteLine(val);
            }

        }

        static void Exercise_17()
        {
            Console.WriteLine("Introduceti inaltimea in cm: ");
            var inaltimeaInCm = Console.ReadLine();
            int value = Convert.ToInt32(inaltimeaInCm);

            if (value <= 150)
            {
                Console.WriteLine("Persoana miniona");
            }
            else if (value <= 150 && value <= 165)
            {
                Console.WriteLine("Persoana mica de incaltine");
            }
            else if (value <= 165 && value <= 175)
            {
                Console.WriteLine("Persona inalta");
            }
            else
            {
                Console.WriteLine("Persona foarte inalta");
            }
        }

        static void Exercise_16()
        {
            Console.WriteLine("Introduceti ora: ");
            var oraIntrodusa = Console.ReadLine();
            double value = Convert.ToDouble(oraIntrodusa);

            if (value <= 12)
            {
                Console.WriteLine("Buna dimineata!");
            }
            else if (value <= 17)
            {
                Console.WriteLine("Buna ziua!");
            }
            else
                Console.WriteLine("Buna seara!");

        }

        static void Exercise_14()
        {
            Console.WriteLine("Introduceti un numar: ");
            var numarulIntrodus = Console.ReadLine();
            int value = Convert.ToInt32(numarulIntrodus);

            if (value % 2 == 0)
            {
                Console.WriteLine($"Numarul {value} este numar par");
            }
            else
                Console.WriteLine("Numarul *numar* pe care l’ati introdus este impar!.");
        }

        static void Exercise_13()
        {
            Console.WriteLine("Introduceti un numar: ");
            var numarulIntrodus = Console.ReadLine();
            int value = Convert.ToInt32(numarulIntrodus);

            if (value <= 20)
            {
                Console.WriteLine($"Numarul {value} este mai mic de 20!");
            }
            else if (value >= 40)
            {
                Console.WriteLine($"Numarul {value} este mai mare de 40!");
            }
            else
                Console.WriteLine("Numarul este intre 20 si 40!");
        }

        static void Exercise_12()
        {
            Console.WriteLine("Introduceti un numar: ");
            var numarulIntrodus = Console.ReadLine();
            int value = Convert.ToInt32(numarulIntrodus);

            if (value >= 0)
            {
                Console.WriteLine($"Numarul  {value} este pozitiv.");
            }
            else
                Console.WriteLine($"Numarul {value} este negativ!.");
        }

        static void Exercise_11()
        {
            Console.WriteLine("Introduceti un numar: ");
            var numarulIntrodus = Console.ReadLine();
            int value = Convert.ToInt32(numarulIntrodus);

            if (value <= 20)
            {
                value = value + 5;
                Console.WriteLine($"Numarul final este: {value}");
            }
            else
            {
                value = value - 5;
                Console.WriteLine($"Numarul este {value}");
            }
        }

        static void Exercise_10()
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

        static void Exercise_9()
        {
            Console.WriteLine("Introduceti un cuvant in consola: ");
            var cuvantulIntrodus = Console.ReadLine();

            if (cuvantulIntrodus.Equals("automation"))
            {
                Console.WriteLine("Cuvantul pe care tu l-ai citit este “automation");
            }
            else
                Console.WriteLine("Cuvantul pe care l-ai citit nu este “automation");
        }


        static void Exercise_8()
        {
            Console.WriteLine("Introduceti un numar: ");
            var numarulIntrodus = Console.ReadLine();
            int value = Convert.ToInt32(numarulIntrodus);

            if(value == 20)
            {
                Console.WriteLine($"Numarul {value} este fix 20");
            }
        }

        static void Exercise_7()
        {
            Console.WriteLine("Introduceti un numar: ");
            var numarulIntrodus = Console.ReadLine();
            int value = Convert.ToInt32(numarulIntrodus);

            if(value % 2 == 0)
            {
                Console.WriteLine($"Numarul {value} este numar par");
            }
        }

        static void Exercise_6()
        {
            Console.WriteLine("Introduceti un numar: ");
            var numarulIntrodus = Console.ReadLine();
            int value = Convert.ToInt32(numarulIntrodus);

            if (value > 20 || value < 40)
            {
                Console.WriteLine($"Numarul {value} este mai mare de 20 sau mai mic de 40!");
            }
        }

        static void Exercise_5()
        {
            Console.WriteLine("Introduceti un numar: ");
            var numarulIntrodus = Console.ReadLine();
            int value = Convert.ToInt32(numarulIntrodus);

            if (value >= 0)
            {
                Console.WriteLine($"Numarul  {value} este pozitiv.");
            }
            else
                Console.WriteLine("Numarul este negativ");
        }

        static void Exercise_4()
        {
            Console.WriteLine("Introduceti un numar: ");
            var numarulIntrodus = Console.ReadLine();
            int value = Convert.ToInt32(numarulIntrodus);

            if (value < 20)
            {
                value = value + 5;
                Console.WriteLine($"Numarul final este: {value}");
            }
            else
                Console.WriteLine("Numarul este mai mare ca 20");
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
