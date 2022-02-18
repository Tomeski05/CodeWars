


//We want to approximate the sqrt function. Usually this function takes a floating point number and returns another floating point number, but in this kata we're going to work with integral numbers instead.

//Your task is to write a function that takes an integer n and returns either

//an integer k if n is a square number, such that k * k == n or
//a range (k, k+1), such that k * k < n and n < (k+1) *(k + 1).
//Examples
//Assert.AreEqual(2, Kata.SqrtApproximation(4));
//Assert.AreEqual(new int[] { 2, 3 }, Kata.SqrtApproximation(5));
//Note: pow() and sqrt() functions are disabled.

//Remarks
//In dynamic languages, return either a single value or an array/list. In Haskell, use Either.



using System;

public class Kata
{
    public static object SqrtApproximation(int number)
    {
        double result;

        for (result = 0; result * result < number; result++) { }

        if (result * result == number)
        {
            return result;
        }

        for (int i = 0; i <= 2; i++)
        {
            result = (result / 2) + (number / (2 * result));
        }

        return new int[] { (int)result, (int)result + 1 };
    }
}