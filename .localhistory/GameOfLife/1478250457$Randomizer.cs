using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Randomizer
    {
        private static readonly Random rnd = new Random();
        private int rndNumber;

        public Randomizer(int probability)
        {
            this.rndNumber = GenerateRandomNumber(probability);
        }

        private static int GenerateRandomNumber(int probability)
        {
            return rnd.Next(1, probability);
        }
    }
}
