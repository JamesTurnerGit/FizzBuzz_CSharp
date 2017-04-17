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
            if (IsDivisableBy(num,3) && IsDivisableBy(num,5)) { return "FizzBuzz"; }
            if (IsDivisableBy(num,3)) { return "Fizz"; }
            if (IsDivisableBy(num,5)) { return "Buzz"; }
            return num.ToString();
        }

        private static bool IsDivisableBy(int num,int divisor)
        {
            return num % divisor == 0;
        }
    }
}
