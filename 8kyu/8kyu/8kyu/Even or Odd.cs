﻿


//Create a function that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.


using System;

namespace Solution
{
    public class SolutionClass
    {
        public static string EvenOrOdd(int number)
        {
            // Code goes here ...  
            if (number % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }

        }
    }
}