using System.Text.Json;
using ScreenSoundRemastered.Modelos;
using ScreenSoundRemastered.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //musicas[0].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "blues");
        //LinqFilter.FiltrarMusicasPorArtista(musicas, "Post Malone");
        LinqFilter.FiltrarPorTom(musicas, "C");

        // var musicasPreferidasTeste = new MusicasPreferidas("Teste");
        // musicasPreferidasTeste.AdicionarMusicaPreferida(musicas[0]);
        // musicasPreferidasTeste.AdicionarMusicaPreferida(musicas[377]);
        // musicasPreferidasTeste.AdicionarMusicaPreferida(musicas[4]);
        // musicasPreferidasTeste.AdicionarMusicaPreferida(musicas[6]);
        // musicasPreferidasTeste.AdicionarMusicaPreferida(musicas[1467]);
        // musicasPreferidasTeste.ExibirMusicasPreferidas();

        // Console.WriteLine($"---------------");
    
        // var musicasPreferidasTeste2 = new MusicasPreferidas("Teste 2");
        // musicasPreferidasTeste2.AdicionarMusicaPreferida(musicas[500]);
        // musicasPreferidasTeste2.AdicionarMusicaPreferida(musicas[637]);
        // musicasPreferidasTeste2.AdicionarMusicaPreferida(musicas[428]);
        // musicasPreferidasTeste2.AdicionarMusicaPreferida(musicas[13]);
        // musicasPreferidasTeste2.AdicionarMusicaPreferida(musicas[71]);
        // musicasPreferidasTeste2.ExibirMusicasPreferidas();
        // musicasPreferidasTeste2.GerarArquivoJson();
    }
    catch(Exception e)
    {
        Console.WriteLine("Conexão não estabelecida");
        Console.WriteLine(e.Message);       
    }
}