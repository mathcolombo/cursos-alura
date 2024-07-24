namespace PetShop.Modelos;

public static class MenuPrincipal
{
    public static void Menu()
    {
        Console.Clear();
        
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine(">>> MENU PRINCIPAL <<<");

        Console.WriteLine("[ 1 ] Cadastrar");
        Console.WriteLine("[ 2 ] Exibir");
        Console.WriteLine("[ 3 ] Marcar consulta");
        Console.WriteLine("[ 0 ] SAIR");

        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        Console.Write("Digite sua opção: ");    
        int opcao = int.Parse(Console.ReadLine()!);

        switch(opcao)
        {
            case 0:
                break;
            case 1:
                Cadastro.MenuCadastrar();
                break;
            case 2:
                Exibicao.MenuExibir();
                break;
            case 3:
                //MarcarConsulta();
                break;
            default:
                Console.WriteLine($"\nOpção inválida");
                Menu();
                break;          
        }
    }
}
