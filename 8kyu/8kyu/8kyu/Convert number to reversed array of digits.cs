
//Convert number to reversed array of digits
//Given a random non-negative number, you have to return the digits of this number within an array in reverse order.

//Example:
//348597 => [7,9,5,8,4,3]
//0 => [0]



using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    class Digitizer
    {
        public static long[] Digitize(long n)
        {
            return $"{n}".Select(c => long.Parse($"{c}")).Reverse().ToArray();
        }
    }
}