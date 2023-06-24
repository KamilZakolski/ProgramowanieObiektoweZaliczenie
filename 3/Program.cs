using _3;

Wektor v1 = new Wektor(1, 2, 3);
Wektor v2 = new Wektor(4, 5, 6);
Wektor v3 = new Wektor(7, 8, 9);

Wektor suma = Wektor.Suma(v1, v2, v3);
Console.WriteLine("Suma: " + suma);

Wektor roznica = v3 - v2;
Console.WriteLine("Różnica: " + roznica);

Wektor iloczynSkalar = v1 * 2.5;
Console.WriteLine("Iloczyn skalarny: " + iloczynSkalar);

Wektor iloraz = v2 / 2;
Console.WriteLine("Iloraz: " + iloraz);

double dlugosc = v2.Dlugosc;
Console.WriteLine("Długość: " + dlugosc);
