using System.Text.RegularExpressions;

string NormalizeGrittedText(string text)
{
    text = Regex.Replace(text, @"[!]{2,}", "!");
    text = Regex.Replace(text, @"[\?]{2,}", "?");
    text = Regex.Replace(text, @"(\?+!+|!+\?+)", "?!");

    return text;
}

Console.WriteLine("Digite a frase para ser normalizada (ou '0' para encerrar):");
string input;
while ((input = Console.ReadLine()) != "0")
{
    string normalizedText = NormalizeGrittedText(input);
    Console.WriteLine($"Texto normalizado: {normalizedText}");
    Console.WriteLine("\nDigite outra frase (ou 'sair' para encerrar):");
}

Console.WriteLine("Programa encerrado.");
