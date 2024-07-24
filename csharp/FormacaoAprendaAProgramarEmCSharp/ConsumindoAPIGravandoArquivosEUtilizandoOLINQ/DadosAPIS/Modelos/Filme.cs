using System.Text.Json.Serialization;

namespace DadosAPIS.Modelos;

internal class Filme
{
    [JsonPropertyName("title")]
    public string? Titulo { get; set;}
    [JsonPropertyName("year")]
    public string? Lancamento { get; set;}
    [JsonPropertyName("crew")]
    public string Producao { get; set; }
    [JsonPropertyName("imDbRating")]
    public string ImdbRating { get; set; }

    public void ExibirDetalhesDoFilme()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Ano de lançamento: {Lancamento}");
        Console.WriteLine($"Produção: {Producao}");
        Console.WriteLine($"IMDB: {ImdbRating}");
    }
}

