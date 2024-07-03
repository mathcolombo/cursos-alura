using System.Text.Json;
using DadosAPIS.Modelos;

using (HttpClient client = new HttpClient())
{
    try 
    {
        int number = 0;

        string respostaFilme = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        var filme = JsonSerializer.Deserialize<List<Filme>>(respostaFilme)!;
        filme[number].ExibirDetalhesDoFilme();

        string respostaPais = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
        var pais = JsonSerializer.Deserialize<List<Pais>>(respostaPais)!;
        pais[number].ExibirDetalhesDoPais();

       //string respostaCarro = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");

        //string respostaLivro = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");



    }
    catch(Exception e)
    {
        Console.WriteLine("Conexão não estabelecida");
        Console.WriteLine(e.Message);        
    }
}