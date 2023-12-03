using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class EngineItem
    {
        int x, y;
        string item;

        public string Symbol
        {
            get
            {
                return item;
            }
        }

        public int Value
        {
            get
            {
                return int.Parse(item);
            }
        }
        public int Left
        {
            get { 
                return x; 
            }
        }

        public int Right
        {
            get
            {
                return x + item.Length - 1;
            }
        }

        public int Top
        {
            get
            {
                return y;
            }
        }

        public int Bottom
        {
            get
            {
                return y;
            }
        }

        public EngineItem(string item, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.item = item;
        }

        public override string ToString()
        {
            return $"{item} at {x},{y}";
        }

        public bool AdjacentTo(EngineItem item)
        {
            if (item.Bottom < this.Top - 1)
                return false;
            if (item.Top > this.Bottom + 1)
                return false;
            if (item.Right < this.Left - 1)
                return false;
            if (item.Left > this.Right + 1)
                return false;
            return true;
        }
    }
    internal class Line
    {
        public int LineNumber;
        public string Definition;
        public static List<EngineItem> numbers = new List<EngineItem>();
        public static List<EngineItem> symbols = new List<EngineItem>();

        public static List<Line> ReadLines(string path)
        {
            string[] strings = File.ReadAllLines(path);
            List<Line> lines = new List<Line>();
            int i = 0;
            foreach(string s in strings)
            {
                lines.Add(new Line(s, i++));
            }
            return lines;
        }

        public Line(string line, int LineNumber)
        {
            Definition = line;
            this.LineNumber = LineNumber;
            foreach(Match m in Regex.Matches(line, @"(\d+)"))
            {
                numbers.Add(new EngineItem(m.Groups[1].Value, m.Groups[1].Index, LineNumber));
            }

            foreach (Match m in Regex.Matches(line, @"([^0-9\n.])"))
            {
                symbols.Add(new EngineItem(m.Groups[1].Value, m.Groups[1].Index, LineNumber));
            }
        }
    }
}
