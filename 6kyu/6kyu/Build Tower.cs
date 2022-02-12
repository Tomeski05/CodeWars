



//Build Tower
//Build Tower by the following given argument:
//number of floors (integer and always greater than 0).

//Tower block is represented as *

//Python: return a list;
//JavaScript: returns an Array;
//C#: returns a string[];
//PHP: returns an array;
//C++: returns a vector<string>;
//Haskell: returns a[String];
//Ruby: returns an Array;
//Lua: returns a Table;
//Have fun!

//for example, a tower of 3 floors looks like below

//[
//  '  *  ',
//  ' *** ',
//  '*****'
//]
//and a tower of 6 floors looks like below

//[
//  '     *     ',
//  '    ***    ',
//  '   *****   ',
//  '  *******  ',
//  ' ********* ',
//  '***********'
//]
//Go challenge Build Tower Advanced once you have finished this :)



using System;
using System.Linq;

public class Kata
{
    public static string[] TowerBuilder(int nFloors)
    {
        string[] result = new string[nFloors];

        for (var i = 1; i <= nFloors * 2; i += 2)
        {
            var space = (nFloors * 2 - i) / 2;
            result[i / 2] = new string(' ', space) + new string('*', i) + new string(' ', space);
        }

        return result;
    }
}