using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = File.ReadAllLines("test.txt");
            int[] pos = { 0, 0 };
            List<int[]> houses = new List<int[]>();
            foreach (char c in data[0])
            {
                if (c == '>')
                {
                    pos[0]++;
                }
                else if (c == '<')
                {
                    pos[0]--;
                }
                else if (c == '^')
                {
                    pos[1]++;
                }
                else if (c == 'v')
                {
                    pos[1]--;
                }

                if (houses.Contains(c) == false)
                {
                    houses.Add(pos);
                }
            }
        }
    }
}
