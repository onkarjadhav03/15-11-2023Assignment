using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment13
{
    public class Mtds
    {
        public void userinp(string str)
        {
            string[] words = str.Split(' ');

            Console.WriteLine("number of words"+words.Length);
        }

        public void mail(string str)
        {
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            Regex regex = new Regex(pattern);
            if(regex.IsMatch(str))
            {
                Console.WriteLine("valid email");
            }
            else
            {
                Console.WriteLine("invalid email");
            }
        }

        public void mobile(string number)
        {
            string pattern = @"^\d{10}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(number))
            {
                Console.WriteLine("valid mobile no");
            }
            else
            {
                Console.WriteLine("invalid mobile no");
            }
        }

        public void PerformCustomRegexSearch(string text, string pattern)
        {
            try
            {
                // Create a Regex object with the custom pattern
                Regex regex = new Regex(pattern);

                // Use the Matches method to find all matches in the text
                MatchCollection matches = regex.Matches(text);

                // Display the matches found
                if (matches.Count > 0)
                {
                    Console.WriteLine($"Matches found ({matches.Count}):");
                    foreach (Match match in matches)
                    {
                        Console.WriteLine($"  {match.Value} at index {match.Index}");
                    }
                }
                else
                {
                    Console.WriteLine("No matches found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
