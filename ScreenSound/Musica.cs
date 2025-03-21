class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Arista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if (disponivel is true)
        {
            Console.WriteLine("Música dísponivel no Plano.");
        }
        else
        {
            Console.WriteLine("Assine o Plano+ para liberar a música.");
        }
    }

    public void ExibirNArtista()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
    }
}