using _1;

Osoba osoba = new("Adam Nowak")
{
    DataUrodzenia = new DateTime(2000, 1, 1),
    DataŚmierci = new DateTime(2023, 5, 10)
};

Console.WriteLine(
    $"imię: {osoba.Imię}," +
    $"nazwisko: {osoba.nazwisko}," +
    $"Imię i nazwisko: {osoba.ImięNazwisko}," +
    $"wiek: {osoba.Wiek.Value.Days / 365} lat"
    );