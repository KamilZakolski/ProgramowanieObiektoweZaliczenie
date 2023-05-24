using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Prostokat
    {
        private double bokA, bokB;

        public Prostokat(double a, double b)
        {
            bokA = a;
            bokB = b;
        }

        public double BokA
        {
            get => bokA;
            set
            {
                if (double.IsFinite(value) && value > 0)
                {
                    bokA = value;
                }
                throw new ArgumentException("Długość boku musi być skończoną nieujemną liczbą.");
            }
        }

        public double BokB
        {
            get => bokB;
            set
            {
                if (double.IsFinite(value) && value > 0)
                {
                    bokB = value;
                }
                throw new ArgumentException("Długość boku musi być skończoną nieujemną liczbą.");
            }
        }

        public static Dictionary<char, decimal> wysokośćArkusza0 = new Dictionary<char, decimal>()
        {
            ['A'] = 1189,
            ['B'] = 1414,
            ['C'] = 1297
        };

    }
}
