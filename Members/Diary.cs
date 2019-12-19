using System;
using System.Collections.Generic;
using System.Linq;


namespace Members
{
    class Diary
    {
        //Stan (zmienne - pola)
        List<float> ratings = new List<float>();

        //Zachowania klasy
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        internal DiaryStatistics ComputerStatistics()
        {
            DiaryStatistics stats = new DiaryStatistics();
            float sum = 0f;

            foreach (var rating in ratings)
            {
                sum = sum + rating;
            }

            stats.AverageGrade = sum / ratings.Count();
            stats.MaxGrade = ratings.Max();
            stats.MinGrade = ratings.Min();

            return stats;
        
        }
    }
}
