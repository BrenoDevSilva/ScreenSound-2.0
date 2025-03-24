Musica musica1 = new Musica();
musica1.Nome = "teste1";
musica1.Artista = "teste1";
musica1.Duracao = 333;
musica1.Disponivel = true;
Console.WriteLine(musica1.Disponivel);

Musica musica2 = new Musica();
musica2.Nome = "teste2";
musica2.Artista = "teste2";
musica2.Duracao = 444;
musica2.Disponivel = false;

musica1.ExibirFichaTecnica();
Console.WriteLine("");
musica2.ExibirFichaTecnica();