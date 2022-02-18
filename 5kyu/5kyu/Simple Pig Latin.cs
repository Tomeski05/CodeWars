



//Move the first letter of each word to the end of it, then add "ay" to the end of the word. Leave punctuation marks untouched.

//Examples
//Kata.PigIt("Pig latin is cool"); // igPay atinlay siay oolcay
//Kata.PigIt("Hello world !");     // elloHay orldway !



using System;

public class Kata
{
    public static string PigIt(string str)
    {
        string[] words = str.Split(' ');
        string result = "";
        foreach (string word in words)
        {
            if (word.Length > 1)
            {
                result += word.Substring(1) + word[0] + "ay ";
            }
            else
            {
                result += word + " ";
            }
        }
        return result.Trim();
    }
}