
namespace ConsoleApp2
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(=|\/)(?<locationName>[A-Z][A-Za-z]{2,})\1";

            Regex regex = new Regex(pattern);
            MatchCollection locations = regex.Matches(text);

            int travelPoints = 0;
            foreach (Match location in locations)
            {
                travelPoints += location.Groups["locationName"].Length;
            }
            Console.Write($"Destinations: ");
            foreach (Match location in locations)
            {
                
                Console.Write($"{location.Groups["locationName"]}, ");
            }
            
            
            //Console.WriteLine($"Destinations: {string.Join(", ", locations.Select(x => x.Groups["locationName"]))}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
