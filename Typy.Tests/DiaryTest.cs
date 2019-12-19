using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Typy.Tests
{
    [TestClass]
    public class DiaryTest
    {
        [TestMethod]
        public void CalculateMaxGrade()
        {
            Diary diary = new Diary();
            diary.AddRating(9);
            diary.AddRating(3);
            diary.AddRating(4);
            diary.AddRating(7);
            diary.AddRating(8);
            diary.AddRating(10);

            DiaryStatistics stats = diary.Computerstatistics();

            Assert.AreEqual(10f, stats.MaxGrade);
        }
        [TestMethod]
        public void PassByValueClass()
        {
            Diary diary = new Diary();
            diary.Name = "Jacek";

            Setname(diary);

            Assert.AreEqual("Marcin", diary.Name);
        }


        [TestMethod]
        public void PassByValueInt()
        {
            int x1 = 5;
            IncrementNumber(x1);

            Assert.AreEqual(5, x1);
        }


        [TestMethod]
        public void PassByRefInt()
        {
            int x1 = 5;
            IncrementNumber(ref x1);

            Assert.AreEqual(15, x1);
        }
        private void IncrementNumber(ref int number)
        {
            number = 15;
        }
        private void IncrementNumber(int number)
        {
            number = 15;
        }

        private void Setname(Diary diary)
        {
            diary.Name = "Marcin";
        }
    }
}
