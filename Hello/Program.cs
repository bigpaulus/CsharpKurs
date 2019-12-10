using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();

            for (; ;)
            {
                Greetings();
                Age();
                Settings();



                //foreach (var item in args)
                //{

                //    Console.WriteLine("Witaj!" + item);

                //}
            }
        }

        private static void ValueTypes()
        {
            int maxint = int.MaxValue;
            int minint = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxint=" + maxint);
            Console.WriteLine("minint=" + minint);
            Console.WriteLine("maxLong=" + maxLong);
            Console.WriteLine("minLong=" + minLong);
        }

        /// <summary>
        /// Ustawienia programu.
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
        /// <summary>
        /// Ustalanie wieku i jego weryfikacja.
        /// </summary>
        private static void Age()
        {
            Console.Write("Wpisz ile masz lat:");

            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age > 17)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Brawo! jesteś pełnoletni, możesz wypić browara!");
            }
            else if (result == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wprowadziłeś niepoprawny wiek, wpisz ponownie w postaci liczby!");
            }


            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Możemy Ci zaoferować jedynie mleko..");
            }
        }
        /// <summary>
        /// Powitanie i prośba i imię.
        /// </summary>
        private static void Greetings()
        {
            Console.Write("Wpisz swoje imię: ");
            string name = Console.ReadLine();


            Console.WriteLine("Witaj," + name);
        }
    }
}
