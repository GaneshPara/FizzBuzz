using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzApp;

namespace FizzBuzzTesting
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void FizzBuzzApp_MultiplesOfThree()
        {
            FizzBuzz fb = new FizzBuzz();
            string ExpectedResult = "Fizz";
            string ActualResult = fb.CheckFizzBuzz(9);
            Assert.AreEqual(ExpectedResult, ActualResult);
        }

        [TestMethod]
        public void FizzBuzzApp_MultipleOfFive()
        {
            FizzBuzz fb = new FizzBuzz();
            string ExpectedResult = "Buzz";
            string ActualResult = fb.CheckFizzBuzz(20);
            Assert.AreEqual(ExpectedResult, ActualResult);
        }

        [TestMethod]
        public void FizzBuzzApp_MultipleOfThreeandFive()
        {
            FizzBuzz fb = new FizzBuzz();
            string ExpectedResult = "FizzBuzz";
            string ActualResult = fb.CheckFizzBuzz(15);
            Assert.AreEqual(ExpectedResult, ActualResult);
        }

        [TestMethod]
        public void FizzBuzzApp_WithNoMultiples()
        {
            FizzBuzz fb = new FizzBuzz();
            string ExpectedResult = "1";
            string ActualResult = fb.CheckFizzBuzz(1);
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
    }
}
