namespace songs.Filtros;

public class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
       var todosOsGeneros =  musicas
           .Select(generos => generos.Genero)
           .Distinct()
           .ToList();
       foreach (var genero in todosOsGeneros)
       {
           Console.WriteLine($"-{genero}");
       }
    }

    public static void FiltrarArtistaPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas
            .Where(musica => musica.Genero!.Contains(genero))
            .Select(musica => musica.Artista)
            .Distinct();

        Console.WriteLine("Exibindo os artistas por gênero musical:");
        foreach (var artista in artistasPorGeneroMusical  )
        {
            Console.WriteLine($"-{artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas
            .Where(musica => musica.Artista!.Equals(nomeDoArtista))
            .ToList();
        Console.WriteLine(nomeDoArtista);
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"-{musica.Nome}");
        }
    }

    public static void FiltrarMusicasPorAno(List<Musica> musicas, int ano)
    {
        var musicasPorAno = musicas
            .Where(m => m.Ano! == ano)
            .Select(m=> m.Nome)
            .Distinct()
            .ToList();
        
        Console.WriteLine($"Músicas filtradas por ano: {ano}");
        foreach (var m in musicasPorAno)
        {
            Console.WriteLine(m);
        }
    }
    
    public static void ExibirMusicasComTonalidadeCSharp(List<Musica> musicas)
    {
        var consulta  = musicas
            .Where(m => m.Tonalidade.Equals("C#"))
            .Select(m => m.Nome).Distinct().ToList();

        Console.WriteLine("Exibindo músicas com tonalidade C#.");
        Console.WriteLine(consulta.Count);
        foreach (var m in consulta)
        {
            Console.WriteLine(m);
        }
    }
}