using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odcinek13
{
    class Program
    {
        static void Main(string[] args)
        {
           Diary diary = new Diary();
            diary.AddRating(3f);
            diary.AddRating(5f);
            diary.AddRating(8.4f);

            Console.WriteLine(Diary.MaxGrade);

            Diary diary2 = new Diary(); 
            Diary diary3 = new Diary(); 
            Diary diary4 = new Diary(); 
            Diary diary5 = new Diary(); 
            Diary diary6 = new Diary();

            Console.WriteLine(Diary.Count);


            DiaryStatistics stats = diary.Computerstatistics();
           
            
        }
    }
}
