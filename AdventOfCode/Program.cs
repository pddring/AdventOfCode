using System.Text.RegularExpressions;

namespace AdventOfCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("PuzzleInput.txt");
            List<Line> PuzzleInput = new List<Line>();
            foreach(string input in lines)
            {
                PuzzleInput.Add(new Line(input));
            }

            int sum = 0;
            foreach(Line line in PuzzleInput)
            {
                Set s = line.GetMinimumRequired();
                int power = s.GetPower();
                sum += power;
                Console.WriteLine($"{line.input}: min required: {s} Power: {power}");
            }

            // display the result
            Console.WriteLine($"Sum: {sum}");
        }
    }
}