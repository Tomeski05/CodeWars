

//Create a function called shortcut to remove the lowercase vowels (a, e, i, o, u ) in a given string.

//Examples
//"hello"     -->  "hll"
//"codewars"  -->  "cdwrs"
//"goodbye"   -->  "gdby"
//"HELLO"     -->  "HELLO"
//don't worry about uppercase vowels
//y is not considered a vowel for this kata


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


public class Kata
{
    public static string Shortcut(string input)
    {
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' }; 

        return string.Concat(input.Where(i => !vowels.Contains(i)).ToArray()); 
    }
}