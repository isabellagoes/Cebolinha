string fraseDigitada, fraseCebolinha;

Console.Write("Digite uma frase: ");
fraseCebolinha = Console.ReadLine()!;

fraseComDislalia = fraseCebolinha
    .Replace("r", "l")
    .Replace("R", "L");

Console.WriteLine($"Cebolinha: {fraseCebolinha}");
