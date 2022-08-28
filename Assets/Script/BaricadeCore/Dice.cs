using System;

namespace BaricadeCore
{
    public class Dice
    {
        int nbFace;

        public Dice(int nbFace)
        {
            this.nbFace = nbFace;
        }

        public Dice() : this(6) { }

        public int Launch()
        {
            Random alea = RandomController.GetRandom();
            return (alea.Next(nbFace) + 1);
        }
    }
}
