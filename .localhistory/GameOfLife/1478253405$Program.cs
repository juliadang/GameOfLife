﻿using System;
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
        static string[,] world = new string[worldWidth, worldHeight];
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            CreateWorld();
            TheRules();
            CheckNeigbours();
        }

        private static void TheRules()
        {
            int numberOfNeighbours = 0;

            for (int i = 0; i < worldHeight - 1; i++)
            {
                for (int j = 0; j < worldWidth - 1; j++)
                {
                    if (world[i, j] == bacteria)
                    {
                        numberOfNeighbours = CheckNeigbours();
                    }

                    if (world[i, j] != bacteria)
                    {
                        numberOfNeighbours = CheckNeigbours();
                    }
                }
            }
        }

        private static int CheckNeigbours(int i, int j)
        {
            int numberOfNeighbours = 0;

            for (int i = 0 + 1; i < worldHeight - 2; i++)
            {
                for (int j = 0 + 1; j < worldWidth - 2; j++)
                {
                    if (world[i,j] > 0 && world[i, j] < worldHeight - 1)
                    {

                    }



                    if (world[i, j - 1] == bacteria)
                        numberOfNeighbours++;
                    else if (world[i - 1, j] == bacteria)
                        numberOfNeighbours++;
                    if (world[i + 1, j] == bacteria)
                        numberOfNeighbours++;
                    if (world[i, j + 1] == bacteria)
                        numberOfNeighbours++;
                    if (world[i - 1, j - 1] == bacteria)
                        numberOfNeighbours++;
                    if (world[i + 1, j + 1] == bacteria)
                        numberOfNeighbours++;
                    if (world[i + 1, j - 1] == bacteria)
                        numberOfNeighbours++;
                    if (world[i - 1, j + 1] == bacteria)
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
