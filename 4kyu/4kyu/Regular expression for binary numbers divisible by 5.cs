


//Define a regular expression which tests if a given string representing a binary number is divisible by 5.

//Examples:
//// 5 divisable by 5
//Regex.IsMatch('101', DivisibleByFive) == true

//// 135 divisable by 5
//Regex.IsMatch('10000111', DivisibleByFive) == true

//// 666 not divisable by 5
//Regex.IsMatch('0000001010011010', DivisibleByFive) == false
//Note:
//This can be solved by creating a Finite State Machine that evaluates if a string representing a number in binary base is divisible by given number.

//The detailed explanation for dividing by 3 is here

//The FSM diagram for dividing by 5 is here




public class Kata
{
    public const string DivisibleByFive = "^(0|1(10)*(0|11)(01*01|01*00(10)*(0|11))*1)+$";
}