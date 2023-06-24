using _5;

Macierz<int> m1 = new Macierz<int>(2, 2);
m1[0, 0] = 1;
m1[0, 1] = 2;
m1[1, 0] = 3;
m1[1, 1] = 4;

Macierz<int> m2 = new Macierz<int>(2, 2);
m2[0, 0] = 1;
m2[0, 1] = 2;
m2[1, 0] = 3;
m2[1, 1] = 4;

Macierz<int> m3 = new Macierz<int>(2, 2);
m3[0, 0] = 5;
m3[0, 1] = 6;
m3[1, 0] = 7;
m3[1, 1] = 8;

Console.WriteLine(m1 == m2);
Console.WriteLine(m1 == m3);
Console.WriteLine(m1 != m3);

