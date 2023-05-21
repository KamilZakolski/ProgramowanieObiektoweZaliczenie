using _1;

Osoba osoba = new("Adam Nowak");

Console.WriteLine(osoba.ImięNazwisko);
Console.WriteLine(osoba.Imię);
Console.WriteLine(osoba.nazwisko);
osoba.DataUrodzenia = new DateTime(2013, 5, 20);
osoba.DataŚmierci = new DateTime(2020, 5, 20);
Console.WriteLine(osoba.Wiek);