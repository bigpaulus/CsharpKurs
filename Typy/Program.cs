using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typy
{
    class Program
    {
        static void Givename(ref Diary diary)
        {
            diary = new Diary();
            diary.Name = "Nowy Dzienniczek Marcina";
        }

        static void IncrementNumber(ref int number)
        {
            number += 42;
        }
        static void Main(string[] args)
        { 

            Diary d1 = new Diary();
            Diary d2 = d1;

            Givename(ref d2);

           
            Console.WriteLine(d2.Name);

            int x1 = 4;
            IncrementNumber(ref x1);

            Console.WriteLine(x1);

           



            Console.ReadKey();
        }
        
    }
}
