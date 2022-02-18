



//Find the sum of the digits of all the numbers from 1 to N (both ends included).

//Examples
//# N = 4
//1 + 2 + 3 + 4 = 10

//# N = 10
//1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + (1 + 0) = 46

//# N = 12
//1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + (1 + 0) + (1 + 1) + (1 + 2) = 51



using System;

public class TwistedSum
{
    public static long Solution(long n)
    {
        long summ = default;
        for (int i = 1; i <= n; i++)
        {
            if (i >= 10)
            {
                long j = i;
                while (j != 0)
                {
                    summ += j % 10;
                    j /= 10;
                }
            }
            else
                summ += i;
        }
        return summ;
    }
}