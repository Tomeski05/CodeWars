


//Write a simple parser that will parse and run Deadfish.

//Deadfish has 4 commands, each 1 character long:

//i increments the value (initially 0)
//d decrements the value
//s squares the value
//o outputs the value into the return array
//Invalid characters should be ignored.

//Deadfish.Parse("iiisdoso") => new int[] { 8, 64 };



using System.Collections.Generic;

public class Deadfish
{
    public static int[] Parse(string program)
    {
        var output = new List<int>();

        int value = 0;

        foreach (var instruction in program)
        {
            switch (instruction)
            {
                case 'i':
                    ++value;
                    break;
                case 'd':
                    --value;
                    break;
                case 's':
                    value *= value;
                    break;
                case 'o':
                    output.Add(value);
                    break;
            }
        }

        return output.ToArray();
    }
}