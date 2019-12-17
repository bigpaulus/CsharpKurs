using System;
using System.Collections.Generic;
using System.Linq;



    namespace Odcinek13
    {
        class Diary
        {
            public Diary()
            {
                ratings = new List<float>();
            Count = Count + 1;
            }


            //Stan (zmienne - pola)
            List<float> ratings;

        public static float MinGrade = 0;
        public static float MaxGrade = 10;
        public static long Count = 0;

            //Zachowania klasy
            public void AddRating(float rating)
            {
                if (rating >= 0 && rating <= 10)
                {
                    ratings.Add(rating);
                }
            }

        public DiaryStatistics Computerstatistics()
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

