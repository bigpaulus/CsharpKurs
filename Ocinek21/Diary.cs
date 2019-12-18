﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace Odcinek21

{
    class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
        }
        //Stan (zmienne - pola)
        private List<float> ratings;

        public string Name;

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
