    using ScreenSoundRemastered.Modelos;

namespace ScreenSoundRemastered.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($">> {genero}");
        }
    }
    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($">> {artista}");
        }
    }
    public static void FiltrarMusicasPorArtista(List<Musica> musicas, string artista)
    {
        var musicasPorArtista = musicas.Where(musica => musica.Artista!.Equals(artista)).Select(musica => musica.Nome).ToList();
        foreach(var musica in musicasPorArtista)
        {
            Console.WriteLine($">> {musica}");
        }
    }

    public static void FiltrarPorTom(List<Musica> musicas, string tom)
    {
        var musicasPorTom = musicas.Where(musica => musica.tons[musica.Tom].Equals(tom)).ToList();
        foreach(var musica in musicasPorTom)
        {
            Console.WriteLine($">> {musica.Nome} - {musica.Artista}");
        }
    }
}
