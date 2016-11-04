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
            PlaceFirstGenerationBacteria();

            while (Console.ReadLine() != "q")
            {
                TheRules();
                NextGeneration();
            }
        }

        private static void NextGeneration()
        {
            Console.Clear();

            for (int i = 0; i < worldHeight - 1; i++)
            {
                for (int j = 0; j < worldWidth - 1; j++)
                {
                    if (world[i, j] == bacteria)
                        Console.Write(bacteria);
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
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

                        //Rule 1: A location that has zero or oneneighbors will be empty in the next generation. If a cell was in that location, it dies of loneliness.
                        if (numberOfNeighbours <= 1)
                            world[i, j] = " ";

                        //Rule 2: A location with two neighbors is stable—that is,if it contained a cell, it still contains a cell.  If it was empty, it's still empty.
                        if (numberOfNeighbours == 2)
                            world[i, j] = bacteria;

                        //Rule 3: A location with three neighbors will contain a cell in the next generation. If it was unoccupied before, a new cell is born.  If it currently contains a cell, the cell remains.  Good times.
                        if (numberOfNeighbours == 3)
                            world[i, j] = bacteria;

                        //Rule 4: A location with four or more neighbors will be empty in the next generation. If there was a cell in that location, it dies of overcrowding.
                        if (numberOfNeighbours == 4)
                            world[i, j] = " ";
                    }

                    if (world[i, j] != bacteria)
                    {
                        int numberOfNeighbours = 0;
                        numberOfNeighbours = CheckNeigbours(i, j);

                        //Rule 1: A location that has zero or oneneighbors will be empty in the next generation. If a cell was in that location, it dies of loneliness.
                        if (numberOfNeighbours <= 1)
                            world[i, j] = " ";

                        //Rule 2: A location with two neighbors is stable—that is,if it contained a cell, it still contains a cell.  If it was empty, it's still empty.
                        if (numberOfNeighbours == 2)
                            world[i, j] = " ";

                        //Rule 3: A location with three neighbors will contain a cell in the next generation. If it was unoccupied before, a new cell is born.  If it currently contains a cell, the cell remains.  Good times.
                        if (numberOfNeighbours == 3)
                            world[i, j] = bacteria;

                        //Rule 4: A location with four or more neighbors will be empty in the next generation. If there was a cell in that location, it dies of overcrowding.
                        if (numberOfNeighbours == 4)
                            world[i, j] = " ";
                    }
                }
            }
        }

        private static int CheckNeigbours(int iPosition, int jPosition)
        {
            int numberOfNeighbours = 0;

            if (jPosition > 0)
            {
                if (world[iPosition, jPosition - 1] == bacteria)
                    numberOfNeighbours++;
            }

            if (iPosition > 0 && jPosition > 0)
            {
                if (world[iPosition - 1, jPosition - 1] == bacteria)
                    numberOfNeighbours++;
            }

            if (iPosition > 0)
            {
                if (world[iPosition - 1, jPosition] == bacteria)
                    numberOfNeighbours++;
            }

            if (jPosition < worldHeight - 1 && iPosition > 0)
            {
                if (world[iPosition - 1, jPosition + 1] == bacteria)
                    numberOfNeighbours++;
            }



            if (iPosition < worldHeight - 1 && jPosition > 0)
            {
                if (world[iPosition + 1, jPosition - 1] == bacteria)
                    numberOfNeighbours++;
            }

            if (iPosition < worldHeight - 1)
            {
                if (world[iPosition + 1, jPosition] == bacteria)
                    numberOfNeighbours++;
            }
            if (jPosition < worldWidth - 1)
            {
                if (world[iPosition, jPosition + 1] == bacteria)
                    numberOfNeighbours++;
            }
            if (iPosition < worldHeight - 1 && jPosition < worldWidth - 1)
            {
                if (world[iPosition + 1, jPosition + 1] == bacteria)
                    numberOfNeighbours++;
            }
            return numberOfNeighbours;
        }
        private static void PlaceFirstGenerationBacteria()
        {
            for (int i = 0; i < worldHeight - 1; i++)
            {
                for (int j = 0; j < worldWidth - 1; j++)
                {
                    int chanceOfBacteria = rnd.Next(1, 4);
                    if (chanceOfBacteria == 1)
                        world[i, j] = bacteria;
                }
            }
        }
    }
}

