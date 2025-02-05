﻿



//Each element in the periodic table has a symbol associated with it. For instance, the symbol for the element Yttrium is Y. A fun thing to do is see if we can form words using symbols of elements strung together. The symbol for Einsteinium is Es, so the symbols for Yttrium and Einsteinium together form:

//Y + Es = YEs

//Yes! Ignoring capitalization, we can think of any string of letters formed by the concatenation of one or more element symbols as an elemental word -- per the above, yes is an elemental word. There is only one combination of element symbols that can form yes, but in general, there may be more than one combination of element symbols that can form a given elemental word. Let's call each different combination of element symbols that can form a given elemental word word an elemental form of word.

//Your task is to implement the function elementalForms(word), which takes one parameter (the string word), and returns an array (which we'll call forms). If word can be formed by combining element symbols from the periodic table, then forms should contain one or more sub-arrays, each consisting of strings of the form 'elementName (elementSymbol)', for each unique combination of elements that can form word.

//Example
//The word 'snack' can be formed by concatenating the symbols of 3 different combinations of elements:

//----------------------------------------------------
//| 1 | 2 | 3 |
//| ---------------------------------------------------
//| Sulfur(S) | Sulfur(S) | Tin(Sn) |
//| Nitrogen(N) | Sodium(Na) | Actinium(Ac) |
//| Actinium(Ac) | Carbon(C) | Potassium(K) |
//| Potassium(K) | Potassium(K) |                |
//----------------------------------------------------
//So elementalForms('snack') should return the following array:

//{
//    { "Sulfur (S)", "Nitrogen (N)", "Actinium (Ac)", "Potassium (K)"},
//  { "Sulfur (S)", "Sodium (Na)", "Carbon (C)", "Potassium (K)"},
//  { "Tin (Sn)", "Actinium (Ac)", "Potassium (K)"}
//}
//Guidelines
//Symbols can have length 1, 2 or 3 (this kata uses pre-2016 temporary symbols for elements 113, 115, 117 and 118).
//Capitalization does not matter:
//ElementalForms("beach")
//// { {"Beryllium (Be)", "Actinium (Ac)", "Hydrogen (H)"} }
//ElementalForms("BEACH")
//// { {"Beryllium (Be)", "Actinium (Ac)", "Hydrogen (H)"} }
//The order of the returned sub-arrays does not matter, but the order of the strings within each sub-array does matter -- they should be in the order that "spells out" word.
//If word is not an elemental word (that is, no combination of one or more element symbols can form word), return an empty array.
//You do not need to check the type of word. It will always be a (possibly empty) string.
//Finally, a dictionary ELEMENTS has been preloaded and is accessible from your code, which is a mapping from each element symbol to its corresponding full name (e.g.ELEMENTS["Na"] == "Sodium").

//Have fun!




using static Preloaded.Elements;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{

    public class ElementalWords
    {
        public static string[][] ElementalForms(string word)
        {
            List<List<String>> attempts = new List<List<string>>();

            word = word.ToLower();

            foreach (var element in ELEMENTS.Keys)
            {
                String current = $"{ELEMENTS[element]} ({element})";

                if (word.Length < element.Length)
                {
                    continue;
                }

                if (word == element.ToLower())
                {
                    List<string> output = new List<string>() { current };
                    attempts.Add(output);
                    continue;
                }

                if (word.Substring(0, element.Length) == element.ToLower())
                {
                    var attemptsToAdd = ElementalForms(word.Substring(element.Length)).Select(a => a.ToList()).ToList();

                    foreach (var attemptToad in attemptsToAdd)
                    {
                        attemptToad.Insert(0, current);

                        attempts.Add(attemptToad);
                    }
                }
            }

            return attempts.Select(a => a.ToArray()).ToArray();
        }
    }
}