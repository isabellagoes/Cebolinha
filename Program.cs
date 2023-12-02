string fraseDigitada, fraseCebolinha;

Console.Write("Digite uma frase: ");
fraseDigitada = Console.ReadLine()!;

fraseCebolinha = fraseDigitada
    .Replace("r", "l")
    .Replace("R", "L");

Console.WriteLine($"Cebolinha: {fraseCebolinha}");
