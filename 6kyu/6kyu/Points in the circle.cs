


//You have the radius of a circle with the center in point (0,0).

//Write a function that calculates the number of points in the circle where (x, y) -the cartesian coordinates of the points - are integers.

//Example: for radius = 2 the result should be 13.

//0 <= radius <= 1000



public class Kata
{
    public static int pointsNumber(int radius)
    {
        int count = 0;
        for (int i = -radius; i <= radius; i++)
            for (int j = -radius; j <= radius; j++)
                if (i * i + j * j <= radius * radius) count++;
        return count;
    }
}