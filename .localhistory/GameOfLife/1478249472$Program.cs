using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            const int worldSize = 30;
            string[,] world = new string[worldSize, worldSize];

            for (int i = 0; i < worldSize - 1; i++)
            {
                Console.Write("x");
                for (int j = 0; j < worldSize - 1; j++)
                {
                    Console.Write("o");
                }
                Console.WriteLine();
            }
        }
    }
}


//Random rnd = new Random();
//int isBacteriaRandomizer = rnd.Next(0, 2);                          //5th chance of starting with a bacteria
//                    if (isBacteriaRandomizer == 0)
//                    {
//                        world[i, j] = "x";
//                        Console.Write(world[i, j]);
//                    }
//                    else
//                    {
//                        world[i, j] = "o";
//                    }