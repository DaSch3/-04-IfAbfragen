using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfAbfragen
{
    class Program
    {
        static void Main(string[] args)
        {
            int alter = 10;

            if (alter >= 18)
            {
                Console.WriteLine("Du bist alt genug!");
            }
            else
            {
                Console.WriteLine("Du bist nicht alt genug!");
            }

            Console.ReadKey();
        }
    }
}
