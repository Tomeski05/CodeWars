



//You are given an array of numbers.
//Check if the array contains of pairs, i.e every number occurs exactly two times. If true, return true, otherwise false.
//Your solution should not modify the input array.


using System.Linq;


public class Kata
{
    public static bool Twins(int[] arr)
    {
        return arr.GroupBy(i => i).All(x => x.Count() == 2);

    }
}