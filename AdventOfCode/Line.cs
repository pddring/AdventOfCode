using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Set
    {
        public Dictionary<string, int> colours;

        public Set(string input)
        {
            colours = new Dictionary<string, int>()
            {
                {"green", 0}, {"red", 0 }, {"blue", 0}
            };
            foreach(Match m in Regex.Matches(input, @"(\d+) (blue|red|green)"))
            {
                int quantity = int.Parse(m.Groups[1].Value);
                string colour = m.Groups[2].Value;
                colours[colour] = quantity;
            }
        }
    }

    internal class Line
    {
        public int GameID;
        public string input;
        public List<Set> sets;

        public Line(string input)
        {
            this.input = input;
            string[] parts = input.Split(":");
            GameID = int.Parse(System.Text.RegularExpressions.Regex.Match(parts[0], @"Game (\d+)").Groups[1].Value);
            parts = parts[1].Split(";");
            sets = new List<Set>();
            foreach (string part in parts)
            {
                sets.Add(new Set(part));
            }
        }

        public bool IsPossible(int red, int green, int blue)
        {
            foreach(Set s in sets)
            {
                if (s.colours["red"] > red)
                    return false;
                if (s.colours["green"] > green)
                    return false;
                if (s.colours["blue"] > blue)
                    return false;

            }
            return true;
        }
    }
}
