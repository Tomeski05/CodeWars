



//Complete the method/function so that it converts dash/underscore delimited words into camel casing. The first word within the output should be capitalized only if the original word was capitalized (known as Upper Camel Case, also often referred to as Pascal case).

//Examples
//"the-stealth-warrior" gets converted to "theStealthWarrior"
//"The_Stealth_Warrior" gets converted to "TheStealthWarrior"



using System;

public class Kata
{
    public static string ToCamelCase(string str)
    {
        string s = "";

        for (int i = 0; i < str.Length; ++i)
        {
            if (str[i] == '-' || str[i] == '_')
            {
                s += Char.ToUpper(str[i + 1]);
                i++;
            }

            else
            {
                s += str[i];
            }
        }

        return s;
    }
}