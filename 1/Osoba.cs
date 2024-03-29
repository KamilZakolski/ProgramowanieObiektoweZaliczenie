﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Osoba
    {
        public Osoba(string imięNazwisko)
        {
            ImięNazwisko = imięNazwisko;
        }

        private string? imię;
        public string? nazwisko;
        public DateTime? DataUrodzenia = null;
        public DateTime? DataŚmierci = null;

        public string? Imię
        {
            get => imię;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(Imię));
                }
                else
                {
                    imię = value;
                }
            }
        }

        public string ImięNazwisko
        {
            get => $"{Imię} {nazwisko}";
            set
            {
                string[] rozbicie = value.Split(' ');
                Imię = rozbicie[0];
                nazwisko = (rozbicie.Length > 1) ? rozbicie[^1] : "";
            }
        }

        public TimeSpan? Wiek 
        {
            get
            {
                if (DataUrodzenia == null)
                {
                    return null;
                }
                if (DataŚmierci == null)
                {
                    return DateTime.Today - DataUrodzenia.Value;
                }
                else
                {
                    return DataŚmierci.Value - DataUrodzenia.Value;
                }
            }
        }
    }
}
