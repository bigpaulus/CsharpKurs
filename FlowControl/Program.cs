using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    class Program
    {
        public static int age;

        public static string name;

        static void Main(string[] args)
        {
            //InsructioIf();

            //InstructionSwitch();


            //for (int i = 0; i < 3; i++)
            //{
            //    for (int a = 0; a < 2; a++)
            //    {
            //        Console.WriteLine("wartość i : {0} oraz wartość a : {1}", i,a);
            //    }

            //}

            //int i = 1;
            //while (i > 3)

            //{
            //    Console.WriteLine("Wartość i {0}", i);
            //    i++;
            //}

            //do
            //{
            //    Console.WriteLine("Wartość i {0}", i);
            //   i++;

            //} while (i>3);

            //int[] tab = { 1, 2, 3, 5, 8, 12, 21 };
            //foreach (var item in tab)
            //{
            //    Console.WriteLine(item);
            //}

            //for (; ; )
            //{
            //    Console.WriteLine("Podaj Imię:");
            //    string text = Console.ReadLine();
            //    Console.WriteLine("Masz na imię {0} ", text);
            //}

            int[] ages = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //foreach (var age in ages)
            //{
            //    if (age == 2)
            //    {
            //        Console.WriteLine("Wiek wynosi: {0}", age);
            //            continue;
            //        Console.WriteLine("Hello");


            //    }
            //    if (age == 4)
            //    {
            //        Console.WriteLine("Wiek wynosi: {0}", age);
            //            break;
            //        Console.WriteLine("Hello");
            //    }

            //}

            //foreach (var age in ages)
            //{
            //    if (age == 2)
            //    {
            //        Console.WriteLine("Wiek wynosi: {0}", age);
            //        goto skip;
            //        Console.WriteLine("Hello");


            //    }


            //}

            ////jakiś kod

            //skip:
            //Console.WriteLine("Hello!");

            checkage(ages);

            Console.ReadKey();
            
        }

        private static void checkage(int[] ages)
        {
            foreach (var agem in ages)
            {
                if (age == 3)
                {
                    Console.WriteLine("Wiek wynosi: {0}",age);
                    return;
                }

            }
        }

        private static void InstructionSwitch()
        {
            Console.WriteLine("Podaj Imię: ");
            name = Console.ReadLine();


            switch (name)
            {
                case "Marcin":
                    Method1();
                    break;
                case "Tomek":
                    Method2();
                    Method3();
                    break;
                case "Ania":
                    Method1();
                    Method2();
                    Method3();

                    break;

                default:
                    Method4();
                    break;
            }
        }

        private static void InsructioIf()
        {
            Console.WriteLine("Podaj swój wiek: ");
            age = int.Parse(Console.ReadLine());

            string test = age >= 18 ? "Jesteś pełnoletni" : "Jesteś dzieckiem";
            Console.WriteLine(test);

            Console.ReadKey();

            Console.WriteLine("Podaj swoje imię: ");
            name = Console.ReadLine();

            if (age <= 10)

            {
                if (name == "Marcin")
                {
                    Method1();
                }
            }
            else if (age < 20)
            {
                Method2();
            }
            else if (age < 30)
            {
                Method3();
            }
            else
            {
                Console.WriteLine("Masz 30 lub więcej lat");
            }
            Console.ReadKey();
        }

        private static void Method4()
        {
            Console.WriteLine("jesteś w metodzie 4");
        }

        private static void Method3()
        {
            Console.WriteLine("jesteś w metodzie 3");
        }

        private static void Method2()
        {
            Console.WriteLine("jesteś w metodzie 2");
        }

        private static void Method1()
        {
            Console.WriteLine("jesteś w metodzie 1");
        }
        
    }
}
