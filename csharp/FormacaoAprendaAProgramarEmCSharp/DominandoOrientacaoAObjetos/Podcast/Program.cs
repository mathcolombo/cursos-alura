namespace Podcast;
public class Program
{

    public static Podcast podcast = new Podcast();
    public static Episodio episodio = new Episodio();

    public static void Main()
    {
        ShowMenu();
    }

    public static void ShowMenu()
    {
        Console.Clear();
        
        Console.WriteLine($"=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine($"[ 1 ] Exibir detalhes de um episódio");
        Console.WriteLine($"[ 2 ] Adicionar um episódio");
        Console.WriteLine($"[ 3 ] Adicionar convidados");
        Console.WriteLine($"[ 0 ] SAIR");
        Console.WriteLine($"=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        int opcao = int.Parse(Console.ReadLine()!);
        if(opcao == 0) return;
        Direcionador(opcao);
    }

    public static void Direcionador(int opcao) {
        switch(opcao)
        {
            case 1:
                podcast.ExibirDetalhes();
                break;
            case 2:
                podcast.AdicionarEpisodio();
                break;
            case 3:
                Console.Write($"Adicionar convidado em qual episódio? ");
                int ordem = int.Parse(Console.ReadLine()!);

                Console.Write($"Digite o nome do convidado: ");
                podcast.Episodios[ordem-1].AdicionarConvidado(Console.ReadLine()!);
                break;
            default:
                Console.WriteLine("Por favor digite uma opção válida");                              
                break;
        }
        ShowMenu();
    }
}