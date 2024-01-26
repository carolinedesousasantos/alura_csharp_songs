namespace songs;
using System.Text.Json;

public class MusicasFavoritas
{
    public string? Nome { get; set; }
    public List<Musica> ListaMusicasFavoritas { get;}

    public MusicasFavoritas(string? nome)
    {
        Nome = nome;
        ListaMusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaMusicasFavoritas.Add(musica);
    }
    
    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas -> {Nome}");
        foreach (var musica in ListaMusicasFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaMusicasFavoritas
        });
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
        
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo Json foi criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }
    
    public void GerarDocumentoTXTComAsMusicasFavoritas()
    {
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.txt";
        using (StreamWriter arquivo = new StreamWriter(nomeDoArquivo))
        {
            arquivo.WriteLine($"Músicas favoritas do {Nome}\n");
            foreach (var musica in ListaMusicasFavoritas)
            {
                arquivo.WriteLine($"- {musica.Nome}");
            }
            arquivo.Close();
        }
        Console.WriteLine($"txt gerado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }

}