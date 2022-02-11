


//Complete the solution so that it reverses the string passed into it.

//'world'  =>  'dlrow'
//'word'   =>  'drow'


using System;

public static class Kata
{
    public static string Solution(string str)
    {
        string rev = "";
        for (int i = str.Length; i > 0; i--)
        {
            rev += str[i - 1];
        }
        return rev;
    }
}