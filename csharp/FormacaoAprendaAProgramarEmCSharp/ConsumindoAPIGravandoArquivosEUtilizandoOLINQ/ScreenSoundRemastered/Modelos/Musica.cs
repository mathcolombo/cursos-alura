using System.Text.Json.Serialization;

namespace ScreenSoundRemastered.Modelos;

internal class Musica
{
    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("key")]
    public int Tom { get; set;}
    [JsonPropertyName("duration_ms")]
    public int? Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
    public string[] tons = ["C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"];

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Tom: {tons[Tom]}");
        Console.WriteLine($"Duração: {Duracao / 1000} segundos");
        Console.WriteLine($"Gênero: {Genero}");
    }
}
