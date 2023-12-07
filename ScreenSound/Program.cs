using ScreenSound.Menus;
using ScreenSound.Modelos;

Banda TheWeekEnd = new("The WeekEnd");
TheWeekEnd.AdicionarNota(new Avaliacao(10));
TheWeekEnd.AdicionarNota(new Avaliacao(8));
TheWeekEnd.AdicionarNota(new Avaliacao(6));
Banda Pilotos = new("21Pilotos");

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(TheWeekEnd.Nome, TheWeekEnd);
bandasRegistradas.Add(Pilotos.Nome, Pilotos);

Dictionary<int, Menu> opcoesDoMenu = new();
opcoesDoMenu.Add(1, new MenuRegistrarBanda());
opcoesDoMenu.Add(2, new MenuRegistrarAlbum());
opcoesDoMenu.Add(3, new MenuBandasRegistradas());
opcoesDoMenu.Add(4, new MenuAvaliarBanda());
opcoesDoMenu.Add(5, new MenuAvaliarAlbum());
opcoesDoMenu.Add(6, new MenuExibirDetalhes());
opcoesDoMenu.Add(-1, new MenuSair());

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para avaliar um album");
    Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoesDoMenu.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerMostrado = opcoesDoMenu[opcaoEscolhidaNumerica];
        menuASerMostrado.Executar(bandasRegistradas);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
    }
    else Console.WriteLine("Opção inválida");
}

ExibirOpcoesDoMenu();