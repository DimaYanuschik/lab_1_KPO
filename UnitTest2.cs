using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KPO_lab2_2_no_rec_unit_tests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void FindNumber_5_3returnd()
        {
            // arrange
            int n = 3;
            long expected = 1;

            // act            
            long actual = KPO_lab2_2_no_rec.Program.FindNumber(n);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindNumber_7_8returnd()
        {
            // arrange
            int n = 7;
            long expected = 8;

            // act            
            long actual = KPO_lab2_2_no_rec.Program.FindNumber(n);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindNumber_9_21returnd()
        {
            // arrange
            int n = 9;
            long expected = 21;

            // act            
            long actual = KPO_lab2_2_no_rec.Program.FindNumber(n);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindNumber_12_89returnd()
        {
            // arrange
            int n = 12;
            long expected = 89;

            // act            
            long actual = KPO_lab2_2_no_rec.Program.FindNumber(n);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindNumber_50_7778742049returnd()
        {
            // arrange
            int n = 50;
            long expected = 7778742049;

            // act            
            long actual = KPO_lab2_2_no_rec.Program.FindNumber(n);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
