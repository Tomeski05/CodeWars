﻿



//Background:
//You're working in a number zoo, and it seems that one of the numbers has gone missing!

//Zoo workers have no idea what number is missing, and are too incompetent to figure it out, so they're hiring you to do it for them.

//In case the zoo loses another number, they want your program to work regardless of how many numbers there are in total.

//Task:
//Write a function that takes a shuffled list of unique numbers from 1 to n with one element missing (which can be any number including n). Return this missing number.

//Note: huge lists will be tested.

//Examples:
//[1, 3, 4]  =>  2
//[1, 2, 3]  =>  4
//[4, 2, 3]  =>  1



using System.Linq;
public class Kata
{

    public static int FindNumber(int[] array)
    {
        array = array.OrderBy(a => a).ToArray();
        int r = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != i + 1)
            {
                r = i + 1;
                break;
            }
        }
        if (r == 0) r = array.Length + 1;
        return r;
    }
}