string textoDigitada, textoDislalia;

Console.Write("Digite uma frase: ");
textoDigitada = Console.ReadLine()!;

textoDislalia = textoDigitada
    .Replace("r", "l")
    .Replace("R", "L");

Console.WriteLine(textoDislalia);




