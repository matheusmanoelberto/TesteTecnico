int PromptPlayerChoice(string playerName)
{
    Console.WriteLine($"{playerName}, faça sua escolha:");
    Console.WriteLine("1 - Pedra\n2 - Tesoura\n3 - Papel\n0 - Para sair");
    Console.Write("Digite o valor correspondente: ");

    int choice;
    while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 3)
    {
        Console.WriteLine("\nEscolha inválida. Tente novamente.");
        Console.Write("Digite o valor correspondente: ");
    }

    return choice;
}

string DetermineWinner(int player1Choice, int player2Choice)
{
    if (player1Choice == player2Choice)
        return "Empate";

    if ((player1Choice == 1 && player2Choice == 2) || (player1Choice == 2 && player2Choice == 3) || (player1Choice == 3 && player2Choice == 1))
        return "Jogador 1 venceu";
    else
        return "Jogador 2 venceu";
}

bool isPlaying = true;
while (isPlaying)
{
    int player1Choice = PromptPlayerChoice("Jogador 1");
    if (player1Choice == 0)
    {
        Console.WriteLine("Jogo encerrado.");
        break;
    }

    int player2Choice = PromptPlayerChoice("Jogador 2");
    if (player2Choice == 0)
    {
        Console.WriteLine("Jogo encerrado.");
        break;
    }

    string result = DetermineWinner(player1Choice, player2Choice);
    Console.WriteLine(result + "\n");
}
