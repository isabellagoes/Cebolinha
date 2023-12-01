string fraseDigitada, fraseCebolinha;

Console.Write("Digite uma frasease: ");
fraseCebolinha = Console.ReadLine()!;

fraseComDislalia = fraseCebolinha
    .Replace("r", "l")
    .Replace("R", "L");

Console.WriteLine($"Cebolinha: {fraseCebolinha}");
