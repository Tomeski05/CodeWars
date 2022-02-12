


//Create a function that returns the total of a meal including tip and tax. You should not tip on the tax.

//You will be given the subtotal, the tax as a percentage and the tip as a percentage. Please round your result to two decimal places.


using System;

public class Kata
{
    public static double CalculateTotal(double subtotal, int tax, int tip)
    {
        return Math.Round(subtotal * (1 + (tax + tip) / 100.0), 2);
    }
}