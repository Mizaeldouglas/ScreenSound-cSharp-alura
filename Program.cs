using ScreenSound;

var album1 = new Album();
album1.Nome = "A night at the opera";

var musca1 = new Musica("Love of my life", "Queen", 213, true);
var musca2 = new Musica("Bohemian Rhapsody", "Queen", 354, true);
album1.AdicionarMusica(musca1);
album1.AdicionarMusica(musca2);
album1.ExibirMusicaDoAlbum();







// var musica1 = new Musica("Roxane", "The Police", 320, true);
// musica1.Disponivel = false;
// musica1.ExibirFichaTecnica();
//
//
// Console.WriteLine("\n**************************************************************************\n");
//
//
// var musica2 = new Musica("vertigo", "U2", 320, true);
// musica2.ExibirFichaTecnica(); 
//
