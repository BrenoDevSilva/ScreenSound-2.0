//chamando e criando a Classe Banda, e atribuindo o valor "Matue"
Banda matue = new Banda("Matue");

//chamando e criando a Classe Album, e atribuindo o valor "Máquina do Tempo"
Album albumDoMatue = new Album("Máquina do Tempo");

//adicionando a Classe Banda a Classe album
matue.AdicionarAlbum(albumDoMatue);

//chamando a Classe Musica e criando uma musica, definindo ascaracterísticas da musica pelo Construtor da Classe Musica
Musica musica1 = new Musica(matue, "Lágrimas de Diamante")
{
    Duracao = 224,
    Disponivel = true,
};

Musica musica2 = new Musica(matue, "O Vento")
{
    Duracao = 240,
    Disponivel = true,
};

Musica musica3 = new Musica(matue, "Teu Amor")
{
    Duracao = 222,
    Disponivel = false,
};

Musica musica4 = new Musica(matue, "Meu Mundo")
{
    Duracao = 219,
    Disponivel = false,
};

Musica musica5 = new Musica(matue, "S.O.S")
{
    Duracao = 200,
    Disponivel = true,
};

albumDoMatue.AdicionarMusica(musica1);
albumDoMatue.AdicionarMusica(musica2);
albumDoMatue.AdicionarMusica(musica3);
albumDoMatue.AdicionarMusica(musica4);
albumDoMatue.AdicionarMusica(musica5);

//chamando todos os meios de exibição
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
musica3.ExibirFichaTecnica();
musica4.ExibirFichaTecnica();
musica5.ExibirFichaTecnica();
albumDoMatue.ExibirMusicasDoAlbum();
matue.ExibirDiscografia();