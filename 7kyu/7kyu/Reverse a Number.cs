﻿



//Given a number, write a function to output its reverse digits. (e.g. given 123 the answer is 321)

//Numbers should preserve their sign; i.e.a negative number should still be negative when reversed.

//Examples
// 123 ->  321
//-456 -> -654
//1000 ->    1



using System;
using System.Linq;

public class Kata
{
    public int ReverseNumber(int n)
    {
        int reverse = 0;
        while (n != 0)
        {
            var t = n % 10;
            reverse = (reverse * 10) + t;
            n = n / 10;
        }
        return reverse;
    }
}