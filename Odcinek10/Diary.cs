﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace Odcinek10

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

        public float CalculateAverage()
        {
            float sum = 0, avg = 0;
            foreach (var rating in ratings)
            {
                sum = sum + rating;
            }

            avg = sum / ratings.Count();
            return avg;
        }

        public float GiveMaxRating()
        {
            return ratings.Max();
        }
        public float GiveMinRating()
        {
            return ratings.Min();
        }
    }
}
