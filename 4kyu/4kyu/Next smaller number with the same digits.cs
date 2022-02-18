


//Write a function that takes a positive integer and returns the next smaller positive integer containing the same digits.

//For example:

//nextSmaller(21) == 12
//nextSmaller(531) == 513
//nextSmaller(2071) == 2017
//Return - 1(for Haskell: return Nothing, for Rust: return None), when there is no smaller number that contains the same digits. Also return -1 when the next smaller number with the same digits would require the leading digit to be zero.

//nextSmaller(9) == -1
//nextSmaller(111) == -1
//nextSmaller(135) == -1
//nextSmaller(1027) == -1 // 0721 is out since we don't write numbers with leading zeros
//some tests will include very large numbers.
//test data only employs positive integers.



using System;
using System.Linq;

public class Kata
{
    public static long NextSmaller(long n)
    {
        var chars = n.ToString();
        for (var i = chars.Length - 1; i > 0; i--)
        {
            if (chars[i] < chars[i - 1])
            {
                var right = chars.Skip(i).ToArray();
                var next = right.Where(a => a < chars[i - 1]).Max();
                right[Array.IndexOf(right, next)] = chars[i - 1];
                var answer = chars.Substring(0, i - 1) + next + string.Concat(right.OrderByDescending(a => a));
                return answer[0] == '0' ? -1 : long.Parse(answer);
            }
        }
        return -1;
    }
}