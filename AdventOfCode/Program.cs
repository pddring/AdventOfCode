using System.Runtime.Intrinsics.Arm;
using System.Text.RegularExpressions;

namespace AdventOfCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Line> lines = Line.ReadLines("PuzzleInput.txt");

            int sum = 0;
            /*
             * Part 1
            foreach(EngineItem n in Line.numbers)
            {
                bool adjacent = false;
                foreach(EngineItem s in Line.symbols)
                {
                    if(n.AdjacentTo(s))
                    {
                        adjacent = true;
                        Console.WriteLine($"{n} is adjacant to {s}");
                        sum += n.Value;
                        break;
                    }
                }
                if(adjacent == false)
                {
                    Console.WriteLine($"{n} is not an engine part");
                }

            }*/

            foreach(EngineItem s in Line.symbols)
            {
                if(s.Symbol == "*")
                {
                    int adjacentNumberCount = 0;
                    int gearRatio = 1;
                    foreach(EngineItem n in Line.numbers)
                    {
                        if(n.AdjacentTo(s))
                        {
                            adjacentNumberCount++;
                            if (adjacentNumberCount > 2)
                                break;
                            gearRatio *= n.Value;
                        }
                    }
                    if(adjacentNumberCount == 2)
                    {
                        Console.WriteLine($"{s} is a gear with a ratio of {gearRatio}");
                        sum += gearRatio;
                    }
                }
            }

            // display the sum
            Console.WriteLine($"Sum: {sum}");


            


        }
    }
}