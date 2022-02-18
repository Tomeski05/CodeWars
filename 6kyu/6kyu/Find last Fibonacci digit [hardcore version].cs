


//Just like in the "father" kata, you will have to return the last digit of the nth element in the Fibonacci sequence (starting with 1,1, to be extra clear, not with 0,1 or other numbers).

//You will just get much bigger numbers, so good luck bruteforcing your way through it ;)

//Kata.LastFibDigit(1) == 1
//Kata.LastFibDigit(2) == 1
//Kata.LastFibDigit(3) == 2
//Kata.LastFibDigit(1000) == 5
//Kata.LastFibDigit(1000000) == 5



public class Kata
{
    public static int LastFibDigit(long n)
    {
        if (n == 1) return 1;
        n %= 60;
        int first = 0;
        int second = 1;
        int result = 0;

        for (int i = 2; i <= n; i++)
        {
            result = (first + second) % 10;
            first = second;
            second = result;
        }
        return result;
    }
}