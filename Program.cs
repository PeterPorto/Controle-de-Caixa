// Spotify da Shopee

using System.ComponentModel;
using System.Formats.Tar;

string mensagemDeBoasVindas = "Boas vindas ao Spotify da Shopee";
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 5 });
bandasRegistradas.Add("Beatles", new List<int>());


void ExibirLOGO()
{
    Console.WriteLine("𝕤𝕡𝕠𝕥𝕚𝕗𝕪 𝕕𝕒 𝕤𝕙𝕠𝕡𝕖𝕖");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLOGO();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média da banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine() ?? string.Empty;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: BandasRegistradas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: ExibirMedia();
            break;
        case -1: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDasFuncoes("registrar bandas");
    Console.Write("Digite a banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine() ?? string.Empty;
    bandasRegistradas.Add(nomeDaBanda, new List <int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void BandasRegistradas()
{
    Console.Clear();
    ExibirTituloDasFuncoes("bandas Registradas");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDasFuncoes(string titulo)
{
    int quantidaDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidaDeLetras , '*');
    Console.WriteLine (asteriscos);
    Console.WriteLine (titulo);
    Console.WriteLine (asteriscos + "\n");
}
void AvaliarUmaBanda()
{   
    Console.Clear();
    ExibirTituloDasFuncoes("avaliar Banda");
    Console.Write("digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"qual nota a banda {nomeDaBanda} merece?");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas [nomeDaBanda].add(nota);
        Console.WriteLine($"a nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();

    } else 
    {
        Console.WriteLine($"\n a banda {nomeDaBanda} nao foi encontrada!");
        Console.WriteLine("digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }

}

void ExibirMedia()
console.Clear();
ExibirTituloDasFuncoes("exibir media da banda");
Console.Write("digite o nome da banda que deseja exibir a media");
string nomeDaBanda = Console.ReadLine()!;
if (bandasRegistradas.ContainsKey (nomeDaBanda))
{
    List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
    Console.WriteLine($"\nA media da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
    Console.WriteLine("digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
} else 
{
    Console.WriteLine($"\n a banda {nomeDaBanda} nao foi encontrada!");
        Console.WriteLine("digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
}

ExibirLOGO();
ExibirOpcoesDoMenu();
