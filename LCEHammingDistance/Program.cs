using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCEHammingDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 4;

            Solution sol = new Solution();
            int count = sol.HammingDistance(x, y);

            Console.WriteLine(count);
        }
    }
}
