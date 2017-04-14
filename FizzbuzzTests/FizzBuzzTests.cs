using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fizzbuzz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz.Tests
{
    [TestClass()]
    public class FizzBuzzTests
    {

        [TestMethod()]
        public void FizzBuzzNotADivisorOfThreeOrFive()
        {
            var actual = FizzBuzz.FizzBuzzInt(2);

            Assert.AreEqual("2", actual);
        }

        [TestMethod()]
        public void FizzBuzzDisvisorOfThree()
        {
            var actual = FizzBuzz.FizzBuzzInt(3);

            Assert.AreEqual("Fizz", actual);
        }

        [TestMethod()]
        public void FizzBuzzDisvisorOfFive()
        {
            var actual = FizzBuzz.FizzBuzzInt(5);

            Assert.AreEqual("Buzz", actual);
        }

        [TestMethod()]
        public void FizzBuzzDisvisorOfThreeAndFive()
        {
            var actual = FizzBuzz.FizzBuzzInt(15);

            Assert.AreEqual("FizzBuzz", actual);
        }

    }
}