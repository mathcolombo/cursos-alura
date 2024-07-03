using System.Text.Json;
using ScreenSoundRemastered.Modelos;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musica = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musica[0].ExibirDetalhesDaMusica();
    }
    catch(Exception e)
    {
        Console.WriteLine("Conexão não estabelecida");
        Console.WriteLine(e.Message);       
    }
}