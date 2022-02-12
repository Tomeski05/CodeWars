



//You have two arrays in this kata, every array contain only unique elements.
//Your task is to calculate number of elements in first array which also are in second array.



using System;
using System.Linq;
public class Kata
{

    public static int MatchArrays(int[] v, int[] r)
    {
        return v.Intersect(r).Count();
    }

}