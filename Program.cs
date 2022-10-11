using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatements1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world of selction statements!");
            Console.WriteLine("===================================");
            Console.WriteLine();

            string gamertag;
            int score;


            score = 0;
            gamertag = "NitroTech 4K";

            if (gamertag == "NitroTech 4K")
            {
                score = 1000;
            }


            Console.WriteLine("Score: " + score);
            

            Console.ReadKey(true);
        }
    }
}
