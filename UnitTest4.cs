using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KPO_lab2_3._26_unit_tests
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void AmountOfAnyM_50()
        {
            // arrange
            int n = 50;
            string expected = ($"64: 0\n" +
                $"32: 1\n" +
                $"16: 1\n" +
                $"8: 0\n" +
                $"4: 0\n" +
                $"2: 1\n" +
                $"1: 0");

            // act
            string actual = KPO_lab2_3._26.Program.AmountOfAnyM(n);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AmountOfAnyM_100()
        {
            // arrange
            int n = 100;
            string expected = ($"64: 1\n" +
                $"32: 1\n" +
                $"16: 0\n" +
                $"8: 0\n" +
                $"4: 1\n" +
                $"2: 0" +
                $"\n" +
                $"1: 0");

            // act
            string actual = KPO_lab2_3._26.Program.AmountOfAnyM(n);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AmountOfAnyM_200()
        {
            // arrange
            int n = 200;
            string expected = ($"64: 3\n" +
                $"32: 0\n" +
                $"16: 0\n" +
                $"8: 1\n" +
                $"4: 0\n" +
                $"2: 0\n" +
                $"1: 0");

            // act
            string actual = KPO_lab2_3._26.Program.AmountOfAnyM(n);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AmountOfAnyM_400()
        {
            // arrange
            int n = 400;
            string expected = ($"64: 6\n" +
                $"32: 0\n" +
                $"16: 1\n" +
                $"8: 0\n" +
                $"4: 0\n" +
                $"2: 0\n" +
                $"1: 0");

            // act
            string actual = KPO_lab2_3._26.Program.AmountOfAnyM(n);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AmountOfAnyM_800()
        {
            // arrange
            int n = 800;
            string expected = ($"64: 12\n" +
                $"32: 1\n" +
                $"16: 0\n" +
                $"8: 0\n" +
                $"4: 0\n" +
                $"2: 0\n" +
                $"1: 0");

            // act
            string actual = KPO_lab2_3._26.Program.AmountOfAnyM(n);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
