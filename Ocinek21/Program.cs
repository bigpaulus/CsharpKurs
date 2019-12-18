using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odcinek21
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

            //PassByValueAndRef();

            Immutable();

        }

        private static void Immutable()
        {

            string name = " Marcin ";
            name = name.Trim();

            DateTime date = new DateTime(2015, 3, 10);
            date = date.AddHours(48);


            Console.ReadKey();
        }
     
        
    }
}
