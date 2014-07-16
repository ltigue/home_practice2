using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Array;

namespace pins_example
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pins = { 3, 2, 1, 5, 6 };
            int[] push = pins;
            Array.Reverse(pins);
            Console.WriteLine(push);
        }
    }
}
