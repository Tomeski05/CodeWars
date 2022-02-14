


//How can you tell an extrovert from an introvert at NSA? Va gur ryringbef, gur rkgebireg ybbxf ng gur BGURE thl'f fubrf.

//I found this joke on USENET, but the punchline is scrambled. Maybe you can decipher it? According to Wikipedia, ROT13 (http://en.wikipedia.org/wiki/ROT13) is frequently used to obfuscate jokes on USENET.

//Hint: For this task you're only supposed to substitue characters. Not spaces, punctuation, numbers etc. Test examples:

//rot13("EBG13 rknzcyr.") == "ROT13 example.";
//rot13("This is my first ROT13 excercise!" == "Guvf vf zl svefg EBG13 rkprepvfr!"



using System;
using System.Linq;

public class Kata
{
    public static string Rot13(string input)
    {
        var array = input.Select(x => x).ToArray();
        int i = 0;

        foreach (var item in array)
        {
            if ((item >= 'a' && item <= 'm') || (item >= 'A' && item <= 'M'))
                array[i] = (char)(item + 13);
            if ((item >= 'n' && item <= 'z') || (item >= 'N' && item <= 'Z'))
                array[i] = (char)(item - 13);
            i++;

        }

        return string.Join("", array);
    }
}