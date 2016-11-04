using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Randomizer
    {
        private readonly Random rnd = new Random();
        private int rndNumber;

        public Randomizer()
        {
            this.rndNumber = GenerateRandomNumber();
        }

        private int GenerateRandomNumber()
        {
            return this.rnd.Next();
        }
    }
}
