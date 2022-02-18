



//Mount the Bowling Pins!
//Task:
//Did you ever play Bowling? Short: You have to throw a bowl into 10 Pins arranged like this:


//I I I I  # each Pin has a Number:    7 8 9 10
// I I I                                4 5 6
//  I I                                  2 3
//   I                                    1

//You will get an Array with Numbers, e.g.: [3,5,9] and remove them from the field like this:


//I I   I
// I   I
//  I   
//   I   

//Return a string with the current field.

//Note that:
//You begin a new line with \n
//Each Line must be 7 chars long
//Fill the missing pins with a whitespace
//Have fun!



namespace BowlingPins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Bowling
    {
        public string BowlingPins(int[] arr)
        {
            var pins = new Dictionary<int, string>()
            {
                [7] = "I ",
                [8] = "I ",
                [9] = "I ",
                [10] = "I\n",
                [4] = " I",
                [5] = " I ",
                [6] = "I \n",
                [2] = "  I",
                [3] = " I  \n",
                [1] = "   I   "
            };
            foreach (var i in arr)
            {
                pins[i] = pins[i].Replace("I", " ");
            }
            return string.Join("", pins.Select(x => x.Value));
        }
    }
}