



//Given two arrays of strings a1 and a2 return a sorted array r in lexicographical order of the strings of a1 which are substrings of strings of a2.

//Example 1:
//a1 = ["arp", "live", "strong"]

//a2 = ["lively", "alive", "harp", "sharp", "armstrong"]

//returns["arp", "live", "strong"]

//Example 2:
//a1 = ["tarp", "mice", "bull"]

//a2 = ["lively", "alive", "harp", "sharp", "armstrong"]

//returns[]

//Notes:
//Arrays are written in "general" notation. See "Your Test Cases" for examples in your language.
//In Shell bash a1 and a2 are strings. The return is a string where words are separated by commas.
//Beware: r must be without duplicates.



using System.Collections.Generic;
using System.Linq;

public class WhichAreIn
{
    public static string[] inArray(string[] array1, string[] array2)
    {
        return array1.Where(a => array2.Any(b => b.Contains(a))).OrderBy(s => s).ToArray();
    }
}