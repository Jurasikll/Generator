using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Base_Generator gen = new Base_Generator();
            List<byte> testFR = new List<byte>() { 45,31,27,42,87,26,93,58,62,29};
            gen.set_map_params(10, 10, 10, testFR);
            foreach(byte i in gen.LevelsFillRatio)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
