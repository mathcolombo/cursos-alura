namespace Podcast;

public class Podcast
{
    public string Host;
    public string Nome;
    public List<Episodio> Episodios = new List<Episodio>();
    public int TotalDeEspisodios;

    public Podcast()
    {
        
    }

    public void AdicionarEpisodio()
    {
        Console.Clear();
        Console.WriteLine("ADICIONAR EPISÓDIO");
        Console.WriteLine("____________________");   

        Console.Write("Ordem: ");
        int ordem = int.Parse(Console.ReadLine()!);
        Console.Write("Título: ");
        string titulo = Console.ReadLine()!;
        Console.Write("Duração: ");
        int duracao = int.Parse(Console.ReadLine()!);
        
        Episodios.Add(new Episodio(ordem, titulo, duracao));

        foreach (Episodio episodio in Episodios)
        {
            Console.WriteLine($">{episodio.Titulo} ");           
        }

        Thread.Sleep(3000);
        
    }

    public void ExibirDetalhes()
    {
        Console.Clear();
        Console.WriteLine("DETALHES DOS EPISÓDIOS");
        Console.WriteLine("_______________________");        
        
        foreach (Episodio episodio in Episodios)
        {
            Console.WriteLine($">> {episodio.Resumo} <<");
            Console.WriteLine("========================================");
        }
        Thread.Sleep(3000);
    }
}
