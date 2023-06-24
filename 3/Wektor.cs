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

        public Wektor(params double[] współrzędne)
        {
            this.wspolrzedne = współrzędne;
        }

        public double this[byte indeks]
        {
            get { return wspolrzedne[indeks]; }
            set { wspolrzedne[indeks] = value; }
        }

        public double Dlugosc
        {
            get { return Math.Sqrt(Obliczenia.IloczynSkalarny(this, this)); }
        }

        public byte Wymiar
        {
            get { return (byte)wspolrzedne.Length; }
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
            return Obliczenia.Odejmowanie(v1, v2);
        }

        public static Wektor operator *(Wektor v, double skalar)
        {
            return Obliczenia.Mnozenie(v, skalar);
        }

        public static Wektor operator *(double skalar, Wektor v)
        {
            return Obliczenia.Mnozenie(skalar, v);
        }

        public static Wektor operator /(Wektor v, double skalar)
        {
            return Obliczenia.Dzielenie(v, skalar);
        }



        public override string ToString()
        {
            string separator = " | ";
            string result = string.Join(separator, wspolrzedne);
            return $"({result})";
        }

    }
}
