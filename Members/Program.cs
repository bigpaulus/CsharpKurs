using System;




namespace Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();

            diary.NameChanged += new NameChangedDelegate(OnNameChanged);
            diary.NameChanged += new NameChangedDelegate(OnNameChanged2);
            diary.NameChanged += new NameChangedDelegate(OnNameChanged3);
            diary.NameChanged += new NameChangedDelegate(OnNameChanged4);
            diary.NameChanged += new NameChangedDelegate(OnNameChanged4);
            diary.NameChanged += new NameChangedDelegate(OnNameChanged4);

            diary.Name = "Dzienniczek Marcina";
            diary.Name = "Jacek Hej";

            Console.WriteLine(diary.Name);

        }

        private static void OnNameChanged(string existingname, string newName)
        {
            Console.WriteLine($"Zmiana nazwy z {existingname} na {newName}");
        }
        private static void OnNameChanged2(string existingname, string newName)
        {
            Console.WriteLine("*****************");
        }
        private static void OnNameChanged3(string existingname, string newName)
        {
            Console.WriteLine("Hello!");
        }
        private static void OnNameChanged4(string existingname, string newName)
        {
            Console.WriteLine("*****************");
        }
    }
}
