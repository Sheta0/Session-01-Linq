using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01
{
    internal static class IntExtentions
    {
        // Extension method 
        // Must be in a static non generic class
        public static int Reverse(this int number)
        {
            int reversedNumber = 0, lastDigit;
            while(number > 0)
            {
                lastDigit = number % 10;
                reversedNumber = reversedNumber * 10 + lastDigit;
                number /= 10;
            }

            return reversedNumber;
        }
        
        public static long Reverse(this long number)
        {
            long reversedNumber = 0, lastDigit;
            while(number > 0)
            {
                lastDigit = number % 10;
                reversedNumber = reversedNumber * 10 + lastDigit;
                number /= 10;
            }

            return reversedNumber;
        }
    }
}
