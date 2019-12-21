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
            Console.WriteLine("Podaj swój wiek: ");
            age = int.Parse(Console.ReadLine());

            string test = age >= 18 ? "Jesteś pełnoletni" : "Jesteś dzieckiem";
            Console.WriteLine(test);
           
            Console.ReadKey();

            //Console.WriteLine("Podaj swoje imię: ");
            //name = Console.ReadLine();

            //if (age <= 10)

            //{
            //    if (name == "Marcin")
            //    {
            //        Method1();
            //    }
            //}
            //else if (age < 20)
            //{
            //    Method2();
            //}
            //else if (age < 30)
            //{
            //    Method3();
            //}
            //else
            //{
            //    Console.WriteLine("Masz 30 lub więcej lat");
            //}
            //Console.ReadKey();
        }

        private static void Method3()
        {
            Console.WriteLine("Twój wiek jest większy lub równy 30 i wynosi: " + age);
        }

        private static void Method2()
        {
            Console.WriteLine("Twój wiek jest większy niż 10 lecz mniejszy niż 20 i wynosi: " +age);
        }

        private static void Method1()
        {
            Console.WriteLine("Masz 10 lub mniej lat, dokładnie masz: " + age);
        }
        
    }
}
