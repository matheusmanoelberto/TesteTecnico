bool EhPalindromo(string texto)
{
    texto = texto.Replace(" ", "").ToLower();
    for (int i = 0, j = texto.Length - 1; i < j; i++, j--)
    {
        if (texto[i] != texto[j])
            return false;
    }
    return true;
}

while (true)
{
    Console.WriteLine("Digite uma palavra ou frase (ou digite 0 para sair):");
    string entrada = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(entrada))
    {
        Console.WriteLine("Por favor, insira um texto válido.");
        continue;
    }

    if (entrada == "0") break;

    Console.WriteLine($"'{entrada}' é palíndromo? {EhPalindromo(entrada)}");
}
