﻿


//John and his wife Ann have decided to go to Codewars. On the first day Ann will do one kata and John - he wants to know how it is working - 0 kata.

//Let us call a(n) -and j(n) - the number of katas done by Ann - and John - at day n. We have a(0) = 1 and in the same manner j(0) = 0.

//They have chosen the following rules:

//On day n the number of katas done by Ann should be n minus the number of katas done by John at day t, t being equal to the number of katas done by Ann herself at day n - 1

//On day n the number of katas done by John should be n minus the number of katas done by Ann at day t, t being equal to the number of katas done by John himself at day n - 1

//Whoops! I think they need to lay out a little clearer exactly what there're getting themselves into!

//Could you write:
//functions ann(n) and john(n) that return the list of the number of katas Ann/John does on the first n days;
//functions sum_ann(n) and sum_john(n) that return the total number of katas done by Ann/John on the first n days
//Examples:
//john(11)-- >  [0, 0, 1, 2, 2, 3, 4, 4, 5, 6, 6]
//ann(6)-- >  [1, 1, 2, 2, 3, 3]

//sum_john(75)-- > 1720
//sum_ann(150)-- > 6930
//Note:
//Keep an eye on performance.



using System;
using System.Linq;
using System.Collections.Generic;

public class Johnann
{

    private static readonly List<long> AnnList = new List<long>();
    private static readonly List<long> JohnList = new List<long>();



    public static List<long> John(long n)
    {
        BuildArray(n);
        return JohnList;
    }
    public static List<long> Ann(long n)
    {
        BuildArray(n);
        return AnnList;
    }

    public static long SumJohn(long n)
    {
        return John(n).Sum();
    }

    public static long SumAnn(long n)
    {
        return Ann(n).Sum();
    }

    private static void BuildArray(long length)
    {
        AnnList.Clear();
        JohnList.Clear();

        for (int index = 0; index < length; index++)
        {
            AnnList.Add(1);
            JohnList.Add(0);
        }

        for (int index = 1; index < length; index++)
        {
            AnnList[index] = index - JohnList[(int)AnnList[index - 1]];
            JohnList[index] = index - AnnList[(int)JohnList[index - 1]];
        }
    }


}