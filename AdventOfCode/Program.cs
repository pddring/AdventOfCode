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
                if(line.IsPossible(12, 13, 14))
                {
                    Console.WriteLine($"{line.input} is playable");
                    sum += line.GameID;
                } else
                {
                    Console.WriteLine($"{line.input} is not playable");
                }
            }

            // display the result
            Console.WriteLine($"Sum: {sum}");


            


        }
    }
}