﻿class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }

    public int duracaoTotal => musicas.Sum(m => m.Duracao);
    
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"Para ouvir esse álbum completo você precisa de {duracaoTotal} segundos.");
    }
}