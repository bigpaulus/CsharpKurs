using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice
{
    class Program
    {
        static void Main(string[] args)
        {

            //const int StudentsNumber = 5;
            //int[] scores = new int[StudentsNumber];

            //int totalScore = 0;

            //foreach (var score in scores)
            //{
            //    totalScore = totalScore + score;
            //}

            Arrays();

        }

        private static void Arrays()
        {
            float[] ratings;

            ratings = new float[4];
            //ratings[0] = 4.2f;
            //ratings[1] = 6.7f;
            //ratings[2] = 3;
            //ratings[3] = 8.5f;

            AddRatings(ratings);

            foreach (var rating in ratings)
            {
                Console.WriteLine(rating);
            }

        }

        private static void AddRatings(float[] ratings)
        {
            if (ratings.Length >= 4)
            {
                ratings[0] = 4.2f;
                ratings[1] = 6.7f;
                ratings[2] = 3;
                ratings[3] = 8.5f;
            }
        }
    }
}
