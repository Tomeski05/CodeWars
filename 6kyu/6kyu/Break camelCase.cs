


//Complete the solution so that the function will break up camel casing, using a space between words.

//Example
//"camelCasing"  =>  "camel Casing"
//"identifier"   =>  "identifier"
//""             =>  ""



public class Kata
{
    public static string BreakCamelCase(string str)
    {
        string output = "";

        for (int i = 0; i < str.Length; i++)
        {
            char letter = str[i];

            if (char.IsUpper(letter))
            {
                string stringLetter = letter.ToString();
                output += (" " + letter);
            }
            else
            {
                output += letter.ToString();
            }
        }
        return output;
    }
}