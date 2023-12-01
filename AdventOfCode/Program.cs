using System.Text.RegularExpressions;

namespace AdventOfCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Day 1
            string[] lines = File.ReadAllLines("PuzzleInput.txt");

            int sum = 0;

            foreach(string line in lines)
            {
                // find first digit
                string firstDigit = Regex.Match(line, @"^.*?(\d)").Groups[1].Value;

                // find last digit
                string lastDigit = Regex.Match(line, @".*(\d)").Groups[1].Value;

                Console.WriteLine($"Trying to calculate the calibration value for {line}: {firstDigit} {lastDigit}");

                // concatenate and convert to integer
                sum += int.Parse(firstDigit + lastDigit);
            }

            // display the sum
            Console.WriteLine($"Sum: {sum}");


            


        }
    }
}