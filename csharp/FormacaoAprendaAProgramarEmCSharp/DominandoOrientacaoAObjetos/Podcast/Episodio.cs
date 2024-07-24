namespace Podcast;

public class Episodio
{
    public int Duracao {get; set;}
    public int Ordem {get; set;}
    public string Titulo {get; set;}
    public string Resumo => $"{Ordem}. {Titulo} - {Duracao}m";
    public List<string> Convidados = new List<string>();

    public Episodio()
    {
        
    }
    public Episodio(int ordem, string Titulo, int Duracao) 
    {
        this.Ordem = ordem;
        this.Titulo = Titulo;
        this.Duracao = Duracao;
    }

    public void AdicionarConvidado(string convidado)
    {
        Convidados.Add(convidado);
        Console.WriteLine($"Convidado {convidado} adicionado com sucesso!!");
        Thread.Sleep(2000);      
    }
}
