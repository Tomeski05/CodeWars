


//Task
//Some people run along a straight line in the same direction. They start simultaneously at pairwise distinct positions and run with constant speed (which may differ from person to person).

//If two or more people are at the same point at some moment we call that a meeting. The number of people gathered at the same point is called meeting cardinality.

//For the given starting positions and speeds of runners find the maximum meeting cardinality assuming that people run infinitely long. If there will be no meetings, return -1 instead.

//Example
//For startPosition = [1, 4, 2] and speed = [27, 18, 24],

//the output should be 3.

//Input/Output
//[input] integer array startPosition

//A non-empty array of integers representing starting positions of runners (in meters).

//Constraints: 2 ≤ startPosition.length ≤ 15, -1000 ≤ startPosition[i] ≤ 1000.

//[input] integer array speed

//Array of positive integers of the same length as startPosition representing speeds of the runners (in meters per minute).

//Constraints: speed.length = startPosition.length, 1 ≤ speed[i] ≤ 30.

//[output] an integer

//The maximum meeting cardinality or -1 if there will be no meetings.



namespace myjinxin
{
    using System;

    public class Kata
    {
        public int RunnersMeetings(int[] StartPosition, int[] speed)
        {
            int output = 1, d, s, cnt, time;
            for (int i = 0; i < StartPosition.Length; i++)
            {
                for (int j = i + 1; j < StartPosition.Length; j++)
                {
                    d = Math.Abs(StartPosition[j] - StartPosition[i]);
                    s = Math.Abs(speed[i] - speed[j]);

                    if (s <= 0 && d != 0)
                        continue;
                    time = StartPosition[i] * s + speed[i] * d;
                    cnt = 0;

                    for (int k = 0; k < StartPosition.Length; k++)
                    {
                        if (StartPosition[k] * s + speed[k] * d == time)
                            cnt++;
                    }
                    if (cnt == 0)
                        continue;

                    if (cnt > output)
                        output = cnt;
                }
            }
            return output < 2 ? -1 : output;
        }
    }
}