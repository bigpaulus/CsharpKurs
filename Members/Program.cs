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


            //DiaryStatistics stats = diary.ComputerStatistics();

            //WriteResult("Average", stats.AverageGrade, 3,5,7,8,9);
            //WriteResult("Max", (int)stats.MaxGrade);
            //WriteResult("Min", (long)stats.MinGrade);
            //WriteResult("Min", stats.MinGrade, 1);

            diary.Name = "Dzienniczek Marcina";
            diary.Name = "";
            diary.Name = null;
            Console.WriteLine(diary.Name);

        }

        static void WriteResult(string description, params float[] result)
        {

            Console.WriteLine(description + ": " + result[0] + "  " + result[4]);

        }
        static void WriteResult(string description, int result)
        {

            Console.WriteLine(description + ": " + result);

        }
        static void WriteResult(string description, long result)
        {

            Console.WriteLine(description + ": " + result);

        }
        static void WriteResult(string description, float result, long test)
        {

            Console.WriteLine($"{description}: {result:F3}: {2}: {3}: {4}: {5}");

        }


    }
}
