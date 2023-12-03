using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Line
    {
        public string Definition;
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
        }
    }
}
