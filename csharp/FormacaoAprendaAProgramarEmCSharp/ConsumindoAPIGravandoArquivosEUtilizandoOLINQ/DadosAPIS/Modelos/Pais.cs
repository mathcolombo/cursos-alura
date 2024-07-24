using System.Text.Json.Serialization;

namespace DadosAPIS.Modelos;

public class Pais
{
    [JsonPropertyName("nome")]
    public string? Nome { get; set; }
    [JsonPropertyName("capital")]
    public string? Capital { get; set; }
    [JsonPropertyName("populacao")]
    public int? Populacao { get; set; }
    [JsonPropertyName("continente")]
    public string? Continente { get; set; }
    [JsonPropertyName("idioma")]
    public string? Idioma { get; set; }

    public void ExibirDetalhesDoPais()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Capital: {Capital}");
        Console.WriteLine($"Populaçõa: {Populacao}");
        Console.WriteLine($"Continente: {Continente}");
        Console.WriteLine($"Idioma: {Idioma}");
        
    }
}
