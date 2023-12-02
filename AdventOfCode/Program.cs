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

            foreach(Line line in PuzzleInput)
            {

            }

            // display the result
            Console.WriteLine($"");


            


        }
    }
}