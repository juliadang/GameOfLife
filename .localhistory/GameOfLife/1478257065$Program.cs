using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Program
    {
        const string bacteria = "o";
        const int worldHeight = 20;
        const int worldWidth = 50;
        static string[,] world = new string[worldHeight, worldWidth];
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            CreateWorld();
            TheRules();
            Console.ReadKey();
        }

        private static void TheRules()
        {
            

            for (int i = 1; i < worldHeight - 1; i++)
            {
                for (int j = 1; j < worldWidth - 1; j++)
                {
                    if (world[i, j] == bacteria)
                    {
                        int numberOfNeighbours = 0;
                        numberOfNeighbours = CheckNeigbours(i, j);
                        world[i, j] = " ";
                    }

                    if (world[i, j] != bacteria)
                    {
                        int numberOfNeighbours = 0;
                        numberOfNeighbours = CheckNeigbours(i, j);
                    }
                }
            }
        }

        private static int CheckNeigbours(int iPosition, int jPosition)
        {
            int numberOfNeighbours = 0;

            for (int i = 0; i < worldHeight - 1; i++)
            {
                for (int j = 0; j < worldWidth - 1; j++)
                {
                    if (world[iPosition, jPosition - 1] == bacteria)
                        numberOfNeighbours++;
                    if (world[iPosition - 1, jPosition - 1] == bacteria)
                        numberOfNeighbours++;
                    if (world[iPosition + 1, jPosition - 1] == bacteria)
                        numberOfNeighbours++;
                    if (world[iPosition - 1, jPosition] == bacteria)
                        numberOfNeighbours++;
                    if (world[iPosition - 1, jPosition + 1] == bacteria)
                        numberOfNeighbours++;
                    else if (world[iPosition + 1, jPosition] == bacteria)
                        numberOfNeighbours++;
                    else if (world[iPosition, jPosition + 1] == bacteria)
                        numberOfNeighbours++;
                    else if (world[iPosition + 1, jPosition + 1] == bacteria)
                        numberOfNeighbours++;
                }
            }

            return numberOfNeighbours;
        }
        private static void CreateWorld()
        {
            for (int i = 0; i < worldHeight - 1; i++)
            {
                for (int j = 0; j < worldWidth - 1; j++)
                {
                    int chanceOfBacteria = rnd.Next(1, 5);
                    if (chanceOfBacteria == 1)
                        Console.Write("o");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}

