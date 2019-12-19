using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutable
{
    class Program
    {

        static void Main(string[] args)
        {

            Immutable();
        }

        private static void Immutable()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            string name = "     Marcin     ";
            name = name.Trim();
            Console.WriteLine(name);

            DateTime date = new DateTime(2019,12,18);
            date = date.AddDays(3);
            Console.WriteLine(date);



            Console.ReadKey();
        }

    }
}
