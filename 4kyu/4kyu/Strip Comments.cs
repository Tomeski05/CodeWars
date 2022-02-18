



//Complete the solution so that it strips all text that follows any of a set of comment markers passed in. Any whitespace at the end of the line should also be stripped out.

//Example:

//Given an input string of:

//apples, pears # and bananas
//grapes
//bananas !apples
//The output expected would be:

//apples, pears
//grapes
//bananas
//The code would be called like so:

//string stripped = StripCommentsSolution.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new[] { "#", "!" })
//// result should == "apples, pears\ngrapes\nbananas"
///



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class StripCommentsSolution
{


    public static string StripComments(string text, string[] commentSymbols)
    {
        var splitted = text.Split(new char[] { '\n' })
            .Select(str =>
            {
                foreach (var commSymb in commentSymbols)
                    if (str.Contains(commSymb))
                        str = str.Remove(str.IndexOf(commSymb));

                return str.TrimEnd();
            });

        return string.Join('\n', splitted);
    }
}