using System.Text.RegularExpressions;

namespace AdventOfCode
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Line> lines = Line.ReadLines("PuzzleInput.txt");
            Dictionary<int, int> cardCount = new Dictionary<int, int>();
            

            int sum = 0;

            /*
            Part 1
            foreach (Line line in lines)
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
            */

            foreach(Line line in lines)
            {
                cardCount[line.GameID] = 1;
            }

            foreach (Line line in lines)
            {
                int winners = 0;
                foreach (int n in line.winningNumbers)
                {
                    if (line.yourNumbers.Contains(n))
                    {
                        winners++;
                    }
                }
                Console.WriteLine($"Card {line.GameID} has {winners} winners");
                for(int i = line.GameID + 1; i <= line.GameID + winners; i++)
                {
                    Console.WriteLine($"So you win a copy of {i}");
                    cardCount[i] += cardCount[line.GameID];
                }
            }

            foreach(int i in cardCount.Keys) {
                Console.WriteLine($"You have a total of {cardCount[i]} copies of card {i}");
                sum += cardCount[i];
            }

            // display the sum
            Console.WriteLine($"Sum: {sum}");


            


        }
    }
}