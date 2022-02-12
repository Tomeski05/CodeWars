


//#Order Countries in Olympics Games

//In Olympic games countries are ranked based on the gold, and then silver, and then bronze medals.

//You get a list of countries in form of a dictionary; the key is the country name, and the value is a string that indicate the number of gold, silver and bronze medals.

//For example in this list:

//Dictionary<string, string> list = new Dictionary<string, string>()
//            {
//                {"China","54,32,44"},
//                {"Korea","55,33,45"},
//                {"Iraq","54,33,45"},
//                {"Iran","54,33,45"},
//                {"Norway","56,32,45"},
//                {"Finland","55,34,45"}
//            };
//China has 54 gold medals, 32 silver medals and 44 bronze medals.

//The result should be a string ordering the countries and separating them by - In abovementioned example the output should be:

//Norway - Finland - Korea - Iran - Iraq - China

//If two counties get similar medals, then you sort them based on alphabetical order.



using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static string OrderCountries(Dictionary<string, string> list)
    {
        var medals = list.OrderByDescending(country => int.Parse(country.Value.Split(',')[0]))
                         .ThenByDescending(country => int.Parse(country.Value.Split(',')[1]))
                         .ThenByDescending(country => int.Parse(country.Value.Split(',')[2]))
                         .ThenBy(country => country.Key)
                         .Select(country => country.Key);

        return string.Join("-", medals);
    }
}