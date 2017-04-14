using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz
{
    public class FizzBuzz
    {
        public static string FizzBuzzInt(int num)
        {
            if (IsDivisorOfThree(num) && IsDivisorOfFive(num)) { return "FizzBuzz"; }
            if (IsDivisorOfThree(num)) { return "Fizz"; }
            if (IsDivisorOfFive(num)) { return "Buzz"; }
            return num.ToString();
        }

        private static bool IsDivisorOfThree(int num)
        {
            return num % 3 == 0;
        }

        private static bool IsDivisorOfFive(int num)
        {
            return num % 5 == 0;
        }
    }
}
