//Screen Sound - Relembrando C# 

string mensagemDeBoasVindas = "Bem-vindos ao projeto Screen Sound!";
//List<string> ListaDeBandas = new List<string>();
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();



void ExibirMensagemDeBoasVindas() 

{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine("*********************************");
}

void ExibirOpcoesDeMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para avaliar uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a opção escolhida: ");
    // ponto de exclamação no final informa que não aceita valor nulo
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: AvaliarBanda();
            break;
        case 3: MostrarBandasRegistradas();
            break;
        case 4: MediaDeBandas();
            break;
        case 0: Console.WriteLine("Adios! ");
            break;
        default: Console.WriteLine("Opção invalida!");
            break;
       

    }
}
        
void RegistrarBanda()
{
    Console.Clear();
        Console.WriteLine("Registro de Bandas");
        Console.Write("Digite o nome da banda: ");
        string nomeBanda = Console.ReadLine()!; // O ponto de exclamação indica que não queremos trabalhar com nulos
        bandasRegistradas.Add(nomeBanda, new List<int> { 1 });
        Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!"); // O $ antes das aspas duplas é a interpolação de string, uma forma mais fácil de inserir a variavel
        Thread.Sleep(2000); //essa função espera em milisegundos
        ExibirOpcoesDeMenu(); //Aqui estou chamando as opções do menu de volta
        Console.Clear();
        
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("\nExibindo bandas registradas: \n");
    foreach (string banda in bandasRegistradas.Keys) 
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("Digite uma tecla para voltar ao menu principal!");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDeMenu();


}

void AvaliarBanda()
{
    Console.Clear();
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDeMenu();
    }
    else 
    {
        Console.WriteLine("\nA banda não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDeMenu();
    }
}

void MediaDeBandas()
{
    Console.Clear();
    Console.Write("Digite o nome da banda que deseja exibir a média: ");
    string nomeBanda = Console.ReadLine()!;
    List<int> notasDaBanda = bandasRegistradas[nomeBanda];
    Console.WriteLine($"\nA média da banda {nomeBanda} é {notasDaBanda.Average()}.");
    Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDeMenu();

}





ExibirMensagemDeBoasVindas();
ExibirOpcoesDeMenu();
