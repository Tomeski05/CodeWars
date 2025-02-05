﻿


//Do you know how to make a spiral? Let's test it!
//Classic definition: A spiral is a curve which emanates from a central point, getting progressively farther away as it revolves around the point.

//Your objective is to complete a function createSpiral(N) that receives an integer N and returns an NxN two-dimensional array with numbers 1 through NxN represented as a clockwise spiral.

//Return an empty array if N < 1 or N is not int / number

//Examples:

//N = 3 Output:[[1,2,3],[8,9,4],[7,6,5]]

//1    2    3
//8    9    4
//7    6    5
//N = 4 Output:[[1,2,3,4],[12,13,14,5],[11,16,15,6],[10,9,8,7]]

//1   2   3   4
//12  13  14  5
//11  16  15  6
//10  9   8   7
//N = 5 Output:[[1,2,3,4,5],[16,17,18,19,6],[15,24,25,20,7],[14,23,22,21,8],[13,12,11,10,9]]

//1   2   3   4   5
//16  17  18  19  6
//15  24  25  20  7
//14  23  22  21  8
//13  12  11  10  9




using System;
public class TheClockwiseSpiral
{
    public static int[,] CreateSpiral(int N)
    {
        int[,] matrix = new int[N, N];
        int numValue = 1;
        int c1 = 0, c2 = N - 1;

        while (numValue <= N * N)
        {
            //Right direction
            for (int i = c1; i <= c2; i++)
                matrix[c1, i] = numValue++;
            //Down direction 
            for (int j = c1 + 1; j <= c2; j++)
                matrix[j, c2] = numValue++;
            //Left direction
            for (int i = c2 - 1; i >= c1; i--)
                matrix[c2, i] = numValue++;
            //Up direction
            for (int j = c2 - 1; j >= c1 + 1; j--)
                matrix[j, c1] = numValue++;
            c1++;
            c2--;
        }
        return matrix;
    }
}