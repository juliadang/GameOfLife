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
            Random rnd = new Random();
            rnd.Next(0,5);  //5th chance of starting with a bacteria
            const int worldSize = 50; 
            string[,] world = new string[worldSize, worldSize];

            for (int i = 0; i < worldSize - 1; i++)
            {
                for (int j = 0; j < worldSize - 1; j++)
                {

                }
            }
        }
    }
}
