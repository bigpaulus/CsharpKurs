﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace Members


{
    public class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
        }
        //Stan (zmienne - pola)
        private List<float> ratings;

        private string _name;

        public string Name
        {
            get
            {
                return _name.ToUpper();
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Nazwa nie może być pusta");


                        }

                if (_name != value && NameChanged != null)
                {
                    NameChangedEventArgs args = new NameChangedEventArgs();
                    args.EgsistingName = _name;
                    args.NewName = value;


                    NameChanged(this, args);
                }

                _name = value;

            }
        }

        //Delegate
        public event NameChangedDelegate NameChanged;

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
