using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarMusica : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        
        ExibirTituloDaOpcao("Registro de músicas");
        Console.Write("Digite a banda cujo a música deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write("Agora digite o título do álbum: ");
            string nomeDoAlbum = Console.ReadLine()!;

            if(banda.Albuns.Any(a => a.Nome.Equals(nomeDoAlbum)))
            {
                Album album = banda.Albuns.First(a => a.Nome.Equals(nomeDoAlbum));
                Console.Write("Agora digite o nome da música a ser registrada: ");
                string nomeDaMusica = Console.ReadLine()!;
                //album.AdicionarMusica(nomeDaMusica);
                
            }
            else
            {
                Console.WriteLine($"A música {nomeDoAlbum} de {nomeDaBanda} foi registrado com sucesso!");
                Thread.Sleep(4000);
                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
