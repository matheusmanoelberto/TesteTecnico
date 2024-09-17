int[] GenerateFibonacciSequence(int numberOfElements)
{
    if (numberOfElements < 1)
        return Array.Empty<int>();

    var fibonacciSequence = new int[numberOfElements];
    fibonacciSequence[0] = 0;

    if (numberOfElements > 1)
    {
        fibonacciSequence[1] = 1;
        for (int i = 2; i < numberOfElements; i++)
        {
            fibonacciSequence[i] = fibonacciSequence[i - 1] + fibonacciSequence[i - 2];
        }
    }

    return fibonacciSequence;
}

Console.Write("Digite o número de elementos para gerar na sequência de Fibonacci: ");
if (!int.TryParse(Console.ReadLine(), out int numberOfElements) || numberOfElements < 0)
{
    Console.WriteLine("Por favor, insira um número inteiro positivo válido.");
    return;
}

int[] fibonacciSequence = GenerateFibonacciSequence(numberOfElements);
Console.WriteLine($"A sequência de Fibonacci é: {string.Join(", ", fibonacciSequence)}");
