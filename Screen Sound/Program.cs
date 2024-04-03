
// Screen Sound

const string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗ ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");
    Console.Write("Digite a sua opção: ");
    int opc = int.Parse(Console.ReadLine());

    switch (opc)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            Console.WriteLine("A opção escolhida foi " + opc);
            break;
        case -1:
            Console.WriteLine("A opção escolhida foi " + opc);
            break;
        default:
            Console.WriteLine("Tchau tchau :)");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("**********************");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (!bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        bandasRegistradas.Add(nomeDaBanda, new List<int>());
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} já está registrada.");
    }
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("************************************");
    Console.WriteLine("Exibindo todas as bandas registradas");
    Console.WriteLine("************************************");
    foreach (var banda in bandasRegistradas)
    {
        Console.WriteLine($"Banda: {banda.Key}");
    }
    Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
    Console.ReadKey();
    ExibirOpcoesDoMenu();
}

void AvaliarUmaBanda()
{
    Console.Clear();
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}.");
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
    }
    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    ExibirOpcoesDoMenu();
}


ExibirLogo();
ExibirOpcoesDoMenu();