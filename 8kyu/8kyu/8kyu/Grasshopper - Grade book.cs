

//Grade book
//Complete the function so that it finds the average of the three scores passed to it and returns the letter value associated with that grade.

//Numerical Score	Letter Grade
//90 <= score <= 100	'A'
//80 <= score < 90	'B'
//70 <= score < 80	'C'
//60 <= score < 70	'D'
//0 <= score < 60	'F'
//Tested values are all between 0 and 100. Theres is no need to check for negative values or values greater than 100.


using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static char GetGrade(int s1, int s2, int s3)
    {
        //Your code goes here...
        var array = new[] { s1, s2, s3 }.Average();

        if (array >= Math.Min(90, 100)) return 'A';
        if (array >= Math.Min(80, 90)) return 'B';
        if (array >= Math.Min(70, 80)) return 'C';
        if (array >= Math.Min(60, 70)) return 'D';
        return 'F';
    }
}