



//Write reverseList function that simply reverses lists.



using System;

using System.Linq;

namespace Solution
{
    public static class Program
    {
        public static int[] reverseList(int[] list)
        {
            return list.Reverse().ToArray();
        }
    }
}