



//Create a function that takes a positive integer and returns the next bigger number that can be formed by rearranging its digits. For example:

//12 ==> 21
//513 ==> 531
//2017 ==> 2071
//nextBigger(num: 12)   // returns 21
//nextBigger(num: 513)  // returns 531
//nextBigger(num: 2017) // returns 2071
//If the digits can't be rearranged to form a bigger number, return -1 (or nil in Swift):

//9 ==> -1
//111 ==> -1
//531 ==> -1
//nextBigger(num: 9)   // returns nil
//nextBigger(num: 111) // returns nil
//nextBigger(num: 531) // returns nil



using System;

using System.Linq;


public class Kata
{
    public static long NextBiggerNumber(long n)
    {
        static string Nums(long num) => string.Concat(num.ToString().OrderByDescending(i => i));
        var num = Nums(n);
        if (num == n.ToString()) return -1;
        do
        {
            n++;
        } while (Nums(n) != num);

        return n;
    }
}