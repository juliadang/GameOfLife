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
            CreateWorld();
        }

        private static void CreateWorld()
        {
            const int worldHeight = 30;
            const int worldWidth = 50;
            string[,] world = new string[worldWidth, worldHeight];

            for (int i = 0; i < worldHeight - 1; i++)
            {
                Console.Write("x");
                for (int j = 0; j < worldWidth - 1; j++)
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