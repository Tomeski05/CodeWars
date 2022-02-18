



//Task
//Consider two following representations of a non-negative integer:

//A simple decimal integer, constructed of a non-empty sequence of digits from 0 to 9;

//An integer with at least one digit in a base from 2 to 16 (inclusive), enclosed between # characters, and preceded by the base, which can only be a number between 2 and 16 in the first representation. For digits from 10 to 15 characters a, b, ..., f and A, B, ..., F are used.

//Additionally, both representations may contain underscore (_) characters; they are used only as separators for improving legibility of numbers and can be ignored while processing a number.

//Your task is to determine whether the given string is a valid integer representation.

//Note: this is how integer numbers are represented in the programming language Ada.

//Example
//For line = "123_456_789", the output should be true;

//For line = "16#123abc#", the output should be true;

//For line = "10#123abc#", the output should be false;

//For line = "10#10#123ABC#", the output should be false;

//For line = "10#0#", the output should be true;

//For line = "10##", the output should be false.

//Input/Output
//[input] string line
//A non-empty string.

//[output] a boolean value
//true if line is a valid integer representation, false otherwise.




namespace myjinxin
{
    using System;
    using System.Text.RegularExpressions;
    public class Kata
    {
        public bool AdaNumber(string line)
        {
            string[] elements = line.Replace("_", "").Split('#');
            int nBase = 0;

            if (Regex.IsMatch(line.Replace("_", ""), @"^[0-9]{1,}$"))
            {
                return true;
            }
            else if (elements.Length == 3 &&
                int.TryParse(elements[0], out nBase) &&
                nBase <= 16 &&
                nBase >= 2)
            {
                switch (nBase)
                {
                    case 2:
                        if (Regex.IsMatch(elements[1], @"^[01]{1,}$"))
                        {
                            return true;
                        }
                        break;
                    case 3:
                        if (Regex.IsMatch(elements[1], @"^[0-2]{1,}$"))
                        {
                            return true;
                        }
                        break;
                    case 4:
                        if (Regex.IsMatch(elements[1], @"^[0-3]{1,}$"))
                        {
                            return true;
                        }
                        break;
                    case 5:
                        if (Regex.IsMatch(elements[1], @"^[0-4]{1,}$"))
                        {
                            return true;
                        }
                        break;
                    case 6:
                        if (Regex.IsMatch(elements[1], @"^[0-5]{1,}$"))
                        {
                            return true;
                        }
                        break;
                    case 7:
                        if (Regex.IsMatch(elements[1], @"^[0-6]{1,}$"))
                        {
                            return true;
                        }
                        break;
                    case 8:
                        if (Regex.IsMatch(elements[1], @"^[0-7]{1,}$"))
                        {
                            return true;
                        }
                        break;
                    case 9:
                        if (Regex.IsMatch(elements[1], @"^[0-8]{1,}$"))
                        {
                            return true;
                        }
                        break;
                    case 10:
                        if (Regex.IsMatch(elements[1], @"^[0-9]{1,}$"))
                        {
                            return true;
                        }
                        break;
                    case 11:
                        if (Regex.IsMatch(elements[1], @"^[0-9aA]{1,}$"))
                        {
                            return true;
                        }
                        break;
                    case 12:
                        if (Regex.IsMatch(elements[1], @"^[0-9abAB]{1,}$"))
                        {
                            return true;
                        }
                        break;
                    case 13:
                        if (Regex.IsMatch(elements[1], @"^[0-9a-cA-C]{1,}$"))
                        {
                            return true;
                        }
                        break;
                    case 14:
                        if (Regex.IsMatch(elements[1], @"^[0-9a-dA-D]{1,}$"))
                        {
                            return true;
                        }
                        break;
                    case 15:
                        if (Regex.IsMatch(elements[1], @"^[0-9a-eA-E]{1,}$"))
                        {
                            return true;
                        }
                        break;
                    case 16:
                        if (Regex.IsMatch(elements[1], @"^[0-9a-fA-F]{1,}$"))
                        {
                            return true;
                        }
                        break;
                }
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}