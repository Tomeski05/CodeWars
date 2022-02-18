


//Given the string representations of two integers, return the string representation of the sum of those integers.

//For example:

//sumStrings('1', '2') // => '3'
//A string representation of an integer will contain no characters besides the ten numerals "0" to "9".


using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

public class Kata
{

    public static string sumStrings(string a, string b)
    {
        BigInteger val1, val2;
        BigInteger.TryParse(a, out val1);
        BigInteger.TryParse(b, out val2);

        return (val1 + val2).ToString();
    }


}