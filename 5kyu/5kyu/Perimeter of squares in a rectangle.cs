﻿


//The drawing shows 6 squares the sides of which have a length of 1, 1, 2, 3, 5, 8. It's easy to see that the sum of the perimeters of these squares is : 4 * (1 + 1 + 2 + 3 + 5 + 8) = 4 * 20 = 80

//    Hint:
//See Fibonacci sequence

//Ref:
//http://oeis.org/A000045

//The function perimeter has for parameter n where n + 1 is the number of squares (they are numbered from 0 to n) and returns the total perimeter of all the squares.

//perimeter(5)  should return 80
//perimeter(7)  should return 216



using System;
using System.Numerics;

public class SumFct
{
    public static BigInteger perimeter(BigInteger n)
    {
        var a = new BigInteger();
        var b = new BigInteger(1);
        var c = new BigInteger(1);
        var summ = new BigInteger();

        for (int i = 0; i <= (int)n; i++)
        {
            a = b;
            b = c;
            c = a + b;
            summ = summ + a;
        }

        return summ * 4;
    }
}