// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso" };

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
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
            Console.WriteLine("A opção escolhida foi " + opc);
            break;
        case 2:
            Console.WriteLine("A opção escolhida foi " + opc);
            break;
        case 3:
            Console.WriteLine("A opção escolhida foi " + opc);
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

ExibirLogo();
ExibirOpcoesDoMenu();
