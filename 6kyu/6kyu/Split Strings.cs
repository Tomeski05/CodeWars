﻿


//Complete the solution so that it splits the string into pairs of two characters. If the string contains an odd number of characters then it should replace the missing second character of the final pair with an underscore ('_').

//Examples:

//SplitString.Solution("abc"); // should return ["ab", "c_"]
//SplitString.Solution("abcdef"); // should return ["ab", "cd", "ef"]



using System;
using System.Linq;
public class SplitString
{
    public static string[] Solution(string str)
    {
        if (str.Length % 2 != 0)
            str += "_";
        return Enumerable.Range(0, str.Length)
       .Where(x => x % 2 == 0)
       .Select(x => str.Substring(x, 2))
       .ToArray();
    }
}