using System;


namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();

            diary.AddRating(5);
            diary.AddRating(8.5f);
            diary.AddRating(4.7f);


            DiaryStatistics stats = diary.ComputerStatistics();

            Console.WriteLine("Średnia wartość:  " + stats.AverageGrade);
            Console.WriteLine("Maksymalna ocena:  " + stats.MaxGrade);
            Console.WriteLine("Minimalna ocena:  " + stats.MinGrade);
        }
    }
}
