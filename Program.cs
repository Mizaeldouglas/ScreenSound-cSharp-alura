using ScreenSound;
using ScreenSound.Podcasts;

var episodio1 = new Episodio(60, "1", "RPG de mesa de D&D", "RPG de mesa");
var episodio2 = new Episodio(30, "2", "Falando Sobre o Game que ganhou o Game Years", "Baldus Gate 3");
var convidado1 = new Convidado("Mizael");
var convidado2 = new Convidado("Rafael");
episodio2.AdicionarConvidado(convidado1);
episodio2.AdicionarConvidado(convidado2);


var podcast1 = new Podcast("Jovem Nerd", "Nerdcast");
podcast1.AdicionarEpisodio(episodio1);
podcast1.AdicionarEpisodio(episodio2);
podcast1.ExibirEpisodios();



// var album1 = new Album("A night at the opera");
//
// var musca1 = new Musica("Love of my life", "Queen", 213, true);
// var musca2 = new Musica("Bohemian Rhapsody", "Queen", 354, true);
//
// album1.AdicionarMusica(musca1);
// album1.AdicionarMusica(musca2);
// album1.ExibirMusicaDoAlbum();
//
// var banda1 = new Banda("Queen");
//
// banda1.AdicionarAlbum(album1);
// banda1.ExibirDiscografia();
