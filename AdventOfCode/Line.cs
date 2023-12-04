using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Line
    {
        public string Definition;
        public List<int> winningNumbers;
        public List<int> yourNumbers;
        public int GameID;

        public static List<Line> ReadLines(string path)
        {
            string[] strings = File.ReadAllLines(path);
            List<Line> lines = new List<Line>();
            foreach(string s in strings)
            {
                lines.Add(new Line(s));
            }
            return lines;
        }

        public Line(string line)
        {
            Definition = line;
            winningNumbers = new List<int>();
            yourNumbers = new List<int>();

            Match m = Regex.Match(line, @"Card\s+(\d+):([\s\d]+)\|([\s\d]+)");
            GameID = int.Parse(m.Groups[1].Value); 
            foreach(Match n in Regex.Matches(m.Groups[2].Value, @"(\d+)"))
            {
                winningNumbers.Add(int.Parse(n.Value));
            }
            foreach (Match n in Regex.Matches(m.Groups[3].Value, @"(\d+)"))
            {
                yourNumbers.Add(int.Parse(n.Value));
            }
        }
    }
}
