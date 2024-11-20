using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectreAmplitude
{
    internal class Couple
    {
        // assesseurs
        public int FirstValue { get; set; }
        public double SecondValue { get; set; }

        //constructeur
        public Couple(int firstValue, double secondValue)
        {
            FirstValue = firstValue;
            SecondValue = secondValue;
        }

        public override string ToString()
        {
            return $"({FirstValue}, {SecondValue})";
        }
    }
}
