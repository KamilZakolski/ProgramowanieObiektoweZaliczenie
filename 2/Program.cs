using _2;

Prostokat prostokat = new Prostokat(2, 3);

Console.WriteLine(prostokat.BokA);

foreach (var item in Prostokat.wysokoscArkusza0)
{
    Console.WriteLine("Klucz: {0}, Wartość: {1}", item.Key, item.Value);
}

Prostokat arkusz = Prostokat.ArkuszPapieru("A2");
Console.WriteLine();
