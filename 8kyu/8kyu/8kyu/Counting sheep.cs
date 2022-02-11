


//Consider an array/list of sheep where some sheep may be missing from their place.
//We need a function that counts the number of sheep present in the array (true means present).

//For example,

//[true, true, true, false,
//  true, true, true, true,
//  true, false, true, false,
//  true, false, false, true,
//  true, true, true, true,
//  false, false, true, true]
//The correct answer would be 17.

//Hint: Don 't forget to check for bad values like null/undefined


using System;
using System.Linq;

public static class Kata
{
    public static int CountSheeps(bool[] sheeps)
    {
        int sum = 0;
        for (var i = 0; i < sheeps.Length; i++)
        {
            if (sheeps[i])
            {
                sum += 1;
            }
        }
        return sum;
    }
}