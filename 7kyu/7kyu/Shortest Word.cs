


//Simple, given a string of words, return the length of the shortest word(s).

//String will never be empty and you do not need to account for different data types.



using System;

public class Kata
{
    public static int FindShort(string s)
    {
        string[] strArr = s.Split(' ');
        int maxx = int.MaxValue;

        foreach (string item in strArr)
        {
            if (item.Length < maxx)
            {
                maxx = item.Length;
            }
        }
        return maxx;
    }
}