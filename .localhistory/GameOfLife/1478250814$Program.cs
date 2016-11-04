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
            Random rnd = new Random();

            for (int i = 0; i < worldHeight - 1; i++)
            {
                for (int j = 0; j < worldWidth - 1; j++)
                {
                    int chanceOfBacteria = rnd.Next(1, 5);
                    if (chanceOfBacteria == 1)
                    {
                        Console.Write("o");
                    }
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