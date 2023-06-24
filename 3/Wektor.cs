using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public class Wektor
    {
        private double[] wspolrzedne;

        public Wektor(byte wymiar)
        {
            wspolrzedne = new double[wymiar];
        }

        public Wektor(params double[] wspolrzedne)
        {
            this.wspolrzedne = wspolrzedne;
        }

        public double Dlugosc
        {
            get { return IloczynSkalarny(this, this); }
        }

        public byte Wymiar
        {
            get { return (byte)wspolrzedne.Length; }
        }

        public double this[byte indeks]
        {
            get { return wspolrzedne[indeks]; }
        }

        public static double IloczynSkalarny(Wektor V, Wektor W)
        {
            if (V.Wymiar != W.Wymiar)
            {
                throw new ArgumentException("Wektory muszą być tego samego wymiaru");
            }

            double iloczynSkalarny = 0;
            for (byte i = 0; i < V.Wymiar; i++)
            {
                iloczynSkalarny += V[i] * W[i];
            }

            return iloczynSkalarny;
        }

        public static Wektor Suma(params Wektor[] Wektory)
        {
            if (Wektory.Length == 0)
            {
                throw new ArgumentException("Brak wektorów");
            }

            byte wymiar = Wektory[0].Wymiar;
            for (int i = 1; i < Wektory.Length; i++)
            {
                if (Wektory[i].Wymiar != wymiar)
                {
                    throw new ArgumentException("Wektory muszą być tego samego wymiaru");
                }
            }

            double[] sumaWspolrzednych = new double[wymiar];
            foreach (Wektor w in Wektory)
            {
                for (byte i = 0; i < wymiar; i++)
                {
                    sumaWspolrzednych[i] += w[i];
                }
            }

            return new Wektor(sumaWspolrzednych);
        }

        public static Wektor operator +(Wektor V, Wektor W)
        {
            if (V.Wymiar != W.Wymiar)
            {
                throw new ArgumentException("Wektory muszą być tego samego wymiaru");
            }

            double[] sumaWspolrzednych = new double[V.Wymiar];
            for (byte i = 0; i < V.Wymiar; i++)
            {
                sumaWspolrzednych[i] = V[i] + W[i];
            }

            return new Wektor(sumaWspolrzednych);
        }

        public static Wektor operator -(Wektor V, Wektor W)
        {
            if (V.Wymiar != W.Wymiar)
            {
                throw new ArgumentException("Wektory muszą być tego samego wymiaru");
            }

            double[] roznicaWspolrzednych = new double[V.Wymiar];
            for (byte i = 0; i < V.Wymiar; i++)
            {
                roznicaWspolrzednych[i] = V[i] - W[i];
            }

            return new Wektor(roznicaWspolrzednych);
        }

        public static Wektor operator *(Wektor V, double skalar)
        {
            double[] noweWspolrzedne = new double[V.Wymiar];
            for (byte i = 0; i < V.Wymiar; i++)
            {
                noweWspolrzedne[i] = V[i] * skalar;
            }

            return new Wektor(noweWspolrzedne);
        }

        public static Wektor operator *(double skalar, Wektor V)
        {
            return V * skalar;
        }

        public static Wektor operator /(Wektor V, double skalar)
        {
            if (skalar == 0)
            {
                throw new ArgumentException("Skalar nie może równać się zero.");
            }

            double[] noweWspolrzedne = new double[V.Wymiar];
            for (byte i = 0; i < V.Wymiar; i++)
            {
                noweWspolrzedne[i] = V[i] / skalar;
            }

            return new Wektor(noweWspolrzedne);
        }

        public override string ToString()
        {
            return string.Join(", ", wspolrzedne);
        }
    }
}
