using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Randomizer
    {
        public Randomizer(int probability)
        {
            return IsBacteria(probability);
        }

        private static object IsBacteria(int probability)
        {
            bool isBacteria;
            Random rnd = new Random();
            int rndBacteria = rnd.Next(1, probability);
            if (rndBacteria == 1)
                isBacteria = true;
            return isBacteria;
        }
    }
}
