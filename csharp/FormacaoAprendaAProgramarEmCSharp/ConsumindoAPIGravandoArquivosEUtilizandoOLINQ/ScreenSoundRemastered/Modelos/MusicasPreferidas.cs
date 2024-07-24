using System.Text.Json;

namespace ScreenSoundRemastered.Modelos;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicasPreferidas;
    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasPreferidas = new List<Musica>();
    }

    public void AdicionarMusicaPreferida(Musica musica)
    {
        ListaDeMusicasPreferidas.Add(musica); 
    }

    public void ExibirMusicasPreferidas()
    {
        Console.WriteLine($"Playlist {Nome}");
        
        foreach(Musica musica in ListaDeMusicasPreferidas)
        {
            Console.WriteLine($">> {musica.Nome} - {musica.Artista}");
        }
    }
    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasPreferidas
        });
        string nomeDoArquivo = $"musicas-preferidas-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"Arquivo criado no caminho - {Path.GetFullPath(nomeDoArquivo)}");
    }
}
