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

            }

            // display the sum
            Console.WriteLine($"Sum: {sum}");


            


        }
    }
}