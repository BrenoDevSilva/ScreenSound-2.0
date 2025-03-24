class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Arista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel is true)
        {
            Console.WriteLine("Música dísponivel no Plano.");
        }
        else
        {
            Console.WriteLine("Assine o Plano+ para liberar a música.");
        }
    }
}
