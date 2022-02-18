



//Snail Sort
//Given an n x n array, return the array elements arranged from outermost elements to the middle element, traveling clockwise.

//array = [[1,2,3],
//         [4,5,6],
//         [7,8,9]]
//snail(array) #=> [1,2,3,6,9,8,7,4,5]
//For better understanding, please follow the numbers of the next array consecutively:

//array = [[1, 2, 3],
//         [8,9,4],
//         [7,6,5]]
//snail(array) #=> [1,2,3,4,5,6,7,8,9]



using System;
using System.Collections.Generic;

public class SnailSolution
{
    public static int[] Snail(int[][] array)
    {
        int left = 0;
        int right = array[0].Length - 1;
        int top = 0;
        int bottom = array.Length - 1;

        List<int> result = new List<int>();
        while (true)
        {
            if (left > right)
            {
                return result.ToArray();
            }

            if (left == right)
            {
                for (int i = top; i <= bottom; i++)
                {
                    result.Add(array[i][right]);
                }

                return result.ToArray();
            }

            for (int i = left; i < right; i++)
            {
                result.Add(array[top][i]);
            }

            for (int i = top; i < bottom; i++)
            {
                result.Add(array[i][right]);
            }

            for (int i = right; i > left; i--)
            {
                result.Add(array[bottom][i]);
            }

            for (int i = bottom; i > top; i--)
            {
                result.Add(array[i][left]);
            }

            left++;
            right--;
            top++;
            bottom--;
        }
    }
}