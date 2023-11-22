using System;
using System.Text.RegularExpressions;

class ValidDateFinder
{
    static void Main()
    {
        string input = "Hdjsh as2323234jghsd hjsdg sdhk 12212021 idf32432 32423 d34234jh dfh";
        string validDate = FindValidDate(input);

        if (validDate != null)
        {
            Console.WriteLine("Valid date found: " + validDate);
        }
        else
        {
            Console.WriteLine("No valid date found in the input.");
        }
    }

    private static string FindValidDate(string input)
    {
        // Define a regular expression for a date pattern (MMDDYYYY)
        Regex regex = new Regex(@"\b(0[1-9]|1[0-2])(0[1-9]|[12][0-9]|3[01])(19|20)\d\d\b");
        Match match = regex.Match(input);

        if (match.Success)
        {
            return match.Value;
        }
        else
        {
            return null;
        }
    }
}






