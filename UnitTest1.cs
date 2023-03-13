using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KPO_lab2_4._26_unit_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsCorrect_10000and3000_trueReturned()
        {
            // arrange 
            float averageCarCost = 10000;
            float averageMotoCost = 3000;
            bool expected = true;

            // act
            bool actual = KPO_lab2_4._26.Program.IsCorrect(averageCarCost, averageMotoCost);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsCorrect_6000and4000_falseReturned()
        {
            // arrange 
            float averageCarCost = 6000;
            float averageMotoCost = 4000;
            bool expected = false;

            // act
            bool actual = KPO_lab2_4._26.Program.IsCorrect(averageCarCost, averageMotoCost);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsCorrect_20000and3000_trueReturned()
        {
            // arrange 
            float averageCarCost = 20000;
            float averageMotoCost = 3000;
            bool expected = true;

            // act
            bool actual = KPO_lab2_4._26.Program.IsCorrect(averageCarCost, averageMotoCost);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsCorrect_7500and4000_trueReturned()
        {
            // arrange 
            float averageCarCost = 7500;
            float averageMotoCost = 4000;
            bool expected = false;

            // act
            bool actual = KPO_lab2_4._26.Program.IsCorrect(averageCarCost, averageMotoCost);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsCorrect_11000and4000_trueReturned()
        {
            // arrange 
            float averageCarCost = 11000;
            float averageMotoCost = 4000;
            bool expected = false;

            // act
            bool actual = KPO_lab2_4._26.Program.IsCorrect(averageCarCost, averageMotoCost);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
