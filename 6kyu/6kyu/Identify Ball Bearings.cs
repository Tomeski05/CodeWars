



//Failure on the factory floor!! One box of 'deluxe' ball-bearings has been mixed in with all the boxes of 'normal' ball-bearings! We need your help to identify the right box!

//Information
//What you know about the bearings:

//'deluxe' ball - bearings weigh exactly 11 grams
//'normal' ball-bearings weigh exactly 10 grams
//Besides weight, both kinds of ball-bearings are identical
//There are (effectively) infinite bearings in each box
//To help you identify the right box, you also have access to a Super Scale™ which will tell you the exact weight of anything you give it. Unfortunately, getting it ready for each measurement takes a long time, so you only have time to use it once!

//Task
//Write a function which accepts two arguments:

//bearings: A list of the bearing types contained in each 'box'. (length between 1 and 200 inclusive)
//weigh: a function which accepts a collection of bearings, returning the total weight of all. Can only be used once!
//Your function should identify and return the single 'deluxe' bearing sample from bearings.

//Example
//public static Bearing IdentifyBb(Bearing[] bearings, Func<IEnumerable<Bearing>, long> weigh)
//{
//    Bearing a = bearings[0],
//            b = bearings[1],
//            c = bearings[2];
//    if (weigh(a, b) == 20)
//        // bearings 'a' and 'b' must both be 10, so 'c' must be deluxe
//        return c;
//    if (weigh(a) == 10) // Error: weigh has already been used!
//        return b;
//    return a;
//}



using System;
using System.Collections.Generic;

class UserSolution
{
    public static Bearing IdentifyBb(Bearing[] bearings, Func<IEnumerable<Bearing>, long> weigh)
    {
        List<Bearing> bearings2 = new List<Bearing>();

        for (var i = 0; i < bearings.Length; i++)
        {
            for (var j = 1; j <= i + 1; j++)
            {
                bearings2.Add(bearings[i]);
            }
        }

        long weight = weigh(bearings2);

        for (var i = 0; i < bearings.Length; i++)
        {
            for (var j = 1; j <= i + 1; j++)
            {
                weight -= 10;
            }
        }
        return bearings[weight - 1];
    }
}