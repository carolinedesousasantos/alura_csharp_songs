using System.Text.Json;
using songs;
using songs.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        // Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musicas[0].ExibirDetalhesDaMusica();
        Console.WriteLine();
        
       //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
       //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
       // Console.WriteLine("Rock");
       // LinqFilter.FiltrarArtistaPorGeneroMusical(musicas,"rock");
       // Console.WriteLine("Blues");
       // LinqFilter.FiltrarArtistaPorGeneroMusical(musicas,"blues");
       // LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
       // LinqFilter.FiltrarMusicasPorAno(musicas, 2016);

       // var musicasFavoritasCaroline = new MusicasFavoritas("Caroline");
       // musicasFavoritasCaroline.AdicionarMusicasFavoritas(musicas[2]);
       // musicasFavoritasCaroline.AdicionarMusicasFavoritas(musicas[345]);
       // musicasFavoritasCaroline.AdicionarMusicasFavoritas(musicas[1451]);
       // musicasFavoritasCaroline.AdicionarMusicasFavoritas(musicas[1898]);
       // musicasFavoritasCaroline.AdicionarMusicasFavoritas(musicas[600]);
       //
       // musicasFavoritasCaroline.ExibirMusicasFavoritas();
       //
       // musicasFavoritasCaroline.GerarArquivoJson();
       // Console.WriteLine();
       // musicasFavoritasCaroline.GerarDocumentoTXTComAsMusicasFavoritas();

       LinqFilter.ExibirMusicasComTonalidadeCSharp(musicas);
    }
    catch (Exception exception)
    {
        Console.WriteLine($"Ocorreu um problema: {exception.Message}");
    }

}