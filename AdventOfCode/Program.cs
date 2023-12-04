using System.Text.RegularExpressions;

namespace AdventOfCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Line> lines = Line.ReadLines("PuzzleInput.txt");

            int sum = 0;

            foreach(Line line in lines)
            {
                int winners = 0;
                foreach(int n in line.winningNumbers)
                {
                    if(line.yourNumbers.Contains(n))
                    {
                        winners++;
                    }
                }
                int score = (int)Math.Pow(2, winners - 1);
                Console.WriteLine($"Game {line.GameID} is worth {score} points ({winners} cards match)");
                sum += score;
            }

            // display the sum
            Console.WriteLine($"Sum: {sum}");


            


        }
    }
}