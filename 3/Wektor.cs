using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public class Wektor
    {
        private double[] współrzędne;

        public Wektor(byte wymiar)
        {
            współrzędne = new double[wymiar];
        }

        public Wektor(params double[] współrzędne)
        {
            this.współrzędne = współrzędne;
        }

        public double this[byte indeks]
        {
            get { return współrzędne[indeks]; }
            set { współrzędne[indeks] = value; }
        }

        public double Długość
        {
            get { return Math.Sqrt(Obliczenia.IloczynSkalarny(this, this)); }
        }

        public byte Wymiar
        {
            get { return (byte)współrzędne.Length; }
        }

        public static Wektor Suma(params Wektor[] wektory)
        {
            return Obliczenia.Suma(wektory);
        }

        public static Wektor operator +(Wektor v1, Wektor v2)
        {
            return Obliczenia.Dodaj(v1, v2);
        }

        public static Wektor operator -(Wektor v1, Wektor v2)
        {
            return Obliczenia.Odejmij(v1, v2);
        }

        public static Wektor operator *(Wektor v, double skalar)
        {
            return Obliczenia.Pomnóż(v, skalar);
        }

        public static Wektor operator *(double skalar, Wektor v)
        {
            return Obliczenia.Pomnóż(skalar, v);
        }

        public static Wektor operator /(Wektor v, double skalar)
        {
            return Obliczenia.Podziel(v, skalar);
        }



        public override string ToString()
        {
            string separator = " | ";
            string result = string.Join(separator, współrzędne);
            return $"({result})";
        }

    }
}
