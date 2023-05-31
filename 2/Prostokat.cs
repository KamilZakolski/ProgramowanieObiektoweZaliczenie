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

        public static Dictionary<char, decimal> wysokoscArkusza0 = new Dictionary<char, decimal>()
        {
            ['A'] = 1189,
            ['B'] = 1414,
            ['C'] = 1297
        };

        public static Prostokat ArkuszPapieru(string format)
        {
            if (format.Length != 2)
            {
                throw new ArgumentException("Nieprawidłowy format arkusza, arkusz powinien być w postaci 'Xi'.");
            }

            char x = format[0];

            if (!wysokoscArkusza0.ContainsKey(x))
            {
                throw new ArgumentException("Nieprawidłowy klucz, klucz powinien równać się: A lub B lub C.");
            }

            byte i;
            byte.TryParse(format[1].ToString(), out i);

            decimal wysokosc = wysokoscArkusza0[x];
            double pierwiastekZDwoch = Math.Sqrt(2);
            double bokA = Convert.ToDouble(wysokosc) / Math.Pow(pierwiastekZDwoch, i);
            double bokB = bokA / pierwiastekZDwoch;

            return new Prostokat(bokA, bokB);
        }
    }
}
