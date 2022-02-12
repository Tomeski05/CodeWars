

//Task:
//You have to write a function pattern which returns the following Pattern (See Pattern & Examples) upto n number of rows.

//Note: Returning the pattern is not the same as Printing the pattern.
//Rules/Note:
//If n< 1 then it should return "" i.e. empty string.
//There are no whitespaces in the pattern.
//Pattern:
//(n)(n - 1)(n - 2)...4321
//(n)(n - 1)(n - 2)...432
//(n)(n - 1)(n - 2)...43
//(n)(n - 1)(n - 2)...4...............
//..............(n)(n - 1)(n - 2)
//(n)(n - 1)
//(n)
//Examples:
//pattern(4):

//4321
//432
//43
//4
//pattern(11):

//1110987654321
//111098765432
//11109876543
//1110987654
//111098765
//11109876
//1110987
//111098
//11109
//1110
//11
//Hint: Use \n in string to jump to next line




using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public string Pattern(int n)
    {
        List<string> list = new List<string>();
        for (var i = 1; i <= n; i++)
        {
            var s = "";
            for (var j = n; i <= j; j--)
            {
                s += j;
            }
            list.Add(s);
        }
        return string.Join("\n", list);
    }
}