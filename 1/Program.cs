using _1;

Osoba osoba = new("Adam Nowak")
{
    DataUrodzenia = new DateTime(2000, 1, 1),
    DataŚmierci = new DateTime(2023, 5, 10)
};

// Wypisanie wartości
Console.WriteLine(
    "Wypisanie wartości: \n" +
    $"imię: {osoba.Imię}, \n" +
    $"nazwisko: {osoba.nazwisko}, \n" +
    $"Imię i nazwisko: {osoba.ImięNazwisko}, \n" +
    $"Data urodzenia: {osoba.DataUrodzenia}, \n" +
    $"Data śmierci: {osoba.DataŚmierci},  \n" +
    $"wiek: {osoba.Wiek.Value.Days / 365} lat \n\n"
    );

// Sprawdzanie wyjątków
Console.WriteLine("Wyjątek właściwości ImięNazwisko:");
osoba.ImięNazwisko = "Bob";
Console.WriteLine($"zwraca null za nazwisko: {osoba.nazwisko} \n");

Console.WriteLine("Wyjątek Wiek DataUrodzenia - dzisiejsza data:");
osoba.DataŚmierci = null;
Console.WriteLine($"Wiek: {osoba.Wiek.Value.Days / 365} lat \n");

Console.WriteLine("Wyjątek DataUrodzenia właściwości Wiek:");
osoba.DataUrodzenia = null;
Console.WriteLine($"Zwraca null za Wiek: {osoba.Wiek} \n");

Console.WriteLine("Wyjątki właściwości Imię:");
osoba.Imię = null;
Console.WriteLine(osoba.Imię);