using System;




namespace Members
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

            WriteResult("Average", stats.AverageGrade);
            WriteResult("Max", (int)stats.MaxGrade);
            WriteResult("Min", (long)stats.MinGrade);
            WriteResult("Min", (long)stats.MinGrade, 1);

        }

        static void WriteResult(string description, float result)
        {

            Console.WriteLine(description + ": " + result);

        }
        static void WriteResult(string description, int result)
        {

            Console.WriteLine(description + ": " + result);

        }
        static void WriteResult(string description, long result)
        {

            Console.WriteLine(description + ": " + result);

        }
        static void WriteResult(string description, long result, long test)
        {

            Console.WriteLine(description + ": " + result);

        }


    }
}
