using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();


            try
            {

                Console.WriteLine("Prosze podać imię: ");
                diary.Name = Console.ReadLine();
            }
            
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException)
            {

                Console.WriteLine("Coś poszło nie tak..");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }



            diary.NameChanged += OnNameChanged;
            diary.NameChanged += OnNameChanged2;
            diary.NameChanged += OnNameChanged3;
            diary.NameChanged += OnNameChanged4;
            diary.NameChanged += OnNameChanged4;
            diary.NameChanged += OnNameChanged4;
            diary.NameChanged += OnNameChanged4;
            diary.NameChanged -= OnNameChanged4;
            diary.NameChanged -= OnNameChanged4;
            diary.NameChanged -= OnNameChanged4;

          


            diary.Name = "Dzienniczek Marcina";
            diary.Name = "Jacek Hej";

            Console.WriteLine(diary.Name);

        }

        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Zmiana nazwy z {args.EgsistingName} na {args.NewName}");
        }
        private static void OnNameChanged2(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("*****************");
        }
        private static void OnNameChanged3(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("Hello!");
        }
        private static void OnNameChanged4(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("*****************");
        }
    }
}
