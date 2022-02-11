


//Write a function called repeatStr which repeats the given string string exactly n times.

//repeatStr(6, "I") // "IIIIII"
//repeatStr(5, "Hello") // "HelloHelloHelloHelloHello"


using System;

public static class Program
{
    public static string RepeatStr(int n, string s)
    {
        var sum = "";
        for (int i = 0; i < n; i++)
        {
            sum += s;
        }
        return sum;
    }
}

//using System;
//using System.Linq;

//namespace Solution
//{
//    public static class Program
//    {
//        public static string RepeatStr(int n, string s)
//        {
//            return string.Concat(Enumerable.Repeat(s, n));
//        }
//    }
//}