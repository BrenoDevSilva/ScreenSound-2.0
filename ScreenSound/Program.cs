Musica musica1 = new Musica();
musica1.nome = "teste1";
musica1.artista = "teste1";
musica1.duracao = 333;
musica1.disponivel = true;

Musica musica2 = new Musica();
musica2.nome = "teste2";
musica2.artista = "teste2";
musica2.duracao = 444;
musica2.disponivel = false;

musica1.ExibirFichaTecnica();
Console.WriteLine("");
musica2.ExibirFichaTecnica();

Console.WriteLine("");
musica1.ExibirNArtista();
musica2.ExibirNArtista();

