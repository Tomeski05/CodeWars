﻿


//Hello,

//I am Jomo Pipi

//and today we will be evaluating an expression like this:

//(there are an infinite number of radicals)

//{ x + \sqrt{ x + \sqrt{ x + \sqrt{ x + ...} } }
//​
//for a given value x

//Simple!

//arguments passed in will be 1 or greater



using System;

public class JomoPipi
{
    public static double evaluateFunction(int x)
    {
        var result = Math.Sqrt(x);
        for (int i = 0; i < 100; i++)
        {
            result = Math.Sqrt(result + x);
        }
        return result;
    }
}