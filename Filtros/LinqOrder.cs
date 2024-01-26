namespace songs.Filtros;

public class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas
            .OrderBy(m=> m.Artista)
            .Select(m=> m.Artista)
            .Distinct()
            .ToList();
        
        Console.WriteLine("Lista de artistas ordenados");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"-{artista}");
        }
    }
}