using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Kata.CodeWars.LargeFactorial
{
    public class Kata
    {
        static string Multiply(string num1, int num2)
        {
            int carry = 0;
            string result = "";

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(num1[i].ToString());
                int product = digit * num2 + carry;
                carry = product / 10;
                result = (product % 10).ToString() + result;
            }

            while (carry > 0)
            {
                result = (carry % 10).ToString() + result;
                carry /= 10;
            }

            return result;
        }

        public static string Factorial(int n)
        {
            if (n < 0)
            {
                return null;
            }
            else if (n == 0 || n == 1)
            {
                return "1";
            }
            else
            {
                string factorial = "1";

                for (int i = 2; i <= n; i++)
                {
                    factorial = Multiply(factorial, i);
                }

                return factorial;
            }
        }
    }
}
