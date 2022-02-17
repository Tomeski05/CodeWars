



//Wikipedia: The regular paperfolding sequence, also known as the dragon curve sequence, is an infinite automatic sequence of 0s and 1s defined as the limit of inserting an alternating sequence of 1s and 0s around and between the terms of the previous sequence:

//1

//1 1 0

//1 1 0 1 1 0 0

//1 1 0 1 1 0 0 1 1 1 0 0 1 0 0...

//Note how each intermediate sequence is a prefix of the next.

//Define a generator PaperFold that sequentially generates the values of this sequence:

//1 1 0 1 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 1 1 0 0 0 1 1 0 0 1 0 0...

//It will be tested for up to 1 000 000 values.




using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static IEnumerable<int> PaperFold()
    {
        var sequence = new List<int> { 1 };

        while (sequence.Count < 1000000)
        {
            var temp = sequence.Count;
            sequence.Add(1);
            for (int index = temp - 1; index >= 0; index--)
            {
                sequence.Add(sequence[index] * (-1) + 1);
            }
        }
        return sequence;
    }
}