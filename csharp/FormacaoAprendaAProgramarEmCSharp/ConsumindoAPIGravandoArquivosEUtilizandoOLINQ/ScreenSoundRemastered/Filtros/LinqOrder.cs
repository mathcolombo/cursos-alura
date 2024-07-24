using ScreenSoundRemastered.Modelos;

namespace ScreenSoundRemastered.Filtros;

internal class LinqOrder
{
    public static void ExibirArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        foreach(var artista in artistasOrdenados)
        {
            Console.WriteLine($">> {artista}");
        }
    }
}
