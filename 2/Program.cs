using _2;

// Wypisanie wyliczonych długośći
Prostokat prostokat = Prostokat.ArkuszPapieru("A2");
Console.WriteLine($"Długość boku A: {prostokat.BokA} mm");
Console.WriteLine($"Długość boku B: {prostokat.BokB} mm");

// Sprawdzanie wyjątków
// arkusz.BokA = 0;
// arkusz.BokB = -1;
// prostokat = Prostokat.ArkuszPapieru("test");
prostokat = Prostokat.ArkuszPapieru("Z1");