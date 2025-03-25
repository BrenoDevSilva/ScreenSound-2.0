Album albumDoMatue = new Album();
albumDoMatue.Nome = "Máquina do Tempo";

Musica musica1 = new Musica();
musica1.Nome = "Lágrimas de Diamante";
musica1.Duracao = 224;

Musica musica2 = new Musica();
musica2.Nome = "O Vento";
musica2.Duracao = 240;

Musica musica3 = new Musica();
musica3.Nome = "Teu Amor";
musica3.Duracao = 222;

Musica musica4 = new Musica();
musica4.Nome = "Meu Mundo";
musica4.Duracao = 219;

Musica musica5 = new Musica();
musica5.Nome = "S.O.S";
musica5.Duracao = 200;

albumDoMatue.AdicionarMusica(musica1);
albumDoMatue.AdicionarMusica(musica2);
albumDoMatue.AdicionarMusica(musica3);
albumDoMatue.AdicionarMusica(musica4);
albumDoMatue.AdicionarMusica(musica5);

albumDoMatue.ExibirMusicasDoAlbum();