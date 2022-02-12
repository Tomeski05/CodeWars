


//Complete the function circleArea so that it will return the area of a circle with the given radius. Round the returned number to two decimal places (except for Haskell). If the radius is not positive or not a number, return false.

//Example:

//Kata.CalculateAreaOfCircle("-123"); //throws ArgumentException
//Kata.CalculateAreaOfCircle("0"); //throws ArgumentException
//Kata.CalculateAreaOfCircle("43.2673"); //return 5881.25
//Kata.CalculateAreaOfCircle("68"); //return 14526.72
//Kata.CalculateAreaOfCircle("number"); //throws ArgumentException



using System;


public class Kata
{
    public static double CalculateAreaOfCircle(string radius)
    {
        //Console.WriteLine(radius);
        if (radius.Contains(",")) throw new ArgumentException();
        if (double.TryParse(radius, out double d))
        {
            if (d < 1) throw new ArgumentException();
            return Math.Round(Math.PI * Math.Pow(d, 2), 2);
        }

        throw new ArgumentException();
    }
}