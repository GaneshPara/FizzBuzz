using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzApp;

namespace FizzBuzzTesting
{
    [TestClass]
    public class FizzBuzzTest
    {
        FizzBuzz fb = new FizzBuzz();

        [TestMethod]
        public void FizzBuzzApp_MultiplesOfThree()
        {
            string ExpectedResult = "Fizz";
            string ActualResult = fb.CheckFizzBuzz(9);
            Assert.AreEqual(ExpectedResult, ActualResult);
        }

        [TestMethod]
        public void FizzBuzzApp_MultipleOfFive()
        {            
            string ExpectedResult = "Buzz";
            string ActualResult = fb.CheckFizzBuzz(20);
            Assert.AreEqual(ExpectedResult, ActualResult);
        }

        [TestMethod]
        public void FizzBuzzApp_MultipleOfThreeandFive()
        {            
            string ExpectedResult = "FizzBuzz";
            string ActualResult = fb.CheckFizzBuzz(15);
            Assert.AreEqual(ExpectedResult, ActualResult);
        }

        [TestMethod]
        public void FizzBuzzApp_WithNoMultiples()
        {            
            string ExpectedResult = "1";
            string ActualResult = fb.CheckFizzBuzz(1);
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
    }
}
