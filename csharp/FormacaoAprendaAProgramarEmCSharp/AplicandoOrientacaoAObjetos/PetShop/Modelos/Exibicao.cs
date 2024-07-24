namespace PetShop.Modelos;

public class Exibicao
{
    public static void MenuExibir()
    {
        Console.Clear();
        
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine(">>> MENU DE EXIBIÇÃO <<<");

        Console.WriteLine("[ 1 ] Cliente");
        Console.WriteLine("[ 2 ] Pet");
        Console.WriteLine("[ 3 ] Médico");
        Console.WriteLine("[ 0 ] VOLTAR");

        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        Console.Write("Digite sua opção: ");    
        int opcao = int.Parse(Console.ReadLine()!);

        switch(opcao)
        {
            case 0:
                MenuPrincipal.Menu();
                break;
            case 1:
                ExibirCliente();               
                break;
            case 2:
                ExibirPet();
                break;
            case 3:
                break;
            default:
                Console.WriteLine($"\nOpção inválida");
                break;
                
        }

        MenuExibir();
    }

    public static void ExibirCliente()
    {
        Console.Clear();
        Console.WriteLine(">>> CADASTRO DE PET <<<");

        Console.Write("Digite o nome do cliente: ");
        string nomeCliente = Console.ReadLine()!;
        
        foreach (Dono cliente in Cadastro.clientes)
        {
            if(cliente.Nome == nomeCliente)
            {
                Console.WriteLine($"\nNome: {cliente.Nome}");
                Console.WriteLine($"Endereço: {cliente.Endereco}");
                foreach (Pet pet in cliente.Pets)
                {
                    int cont = 1;
                    Console.WriteLine($"Pet {cont}: {pet.Nome}");                   
                }
            }
        }
        Console.Write($"Aperte uma tecla para sair");
        Console.ReadKey();       
    }

    public static void ExibirPet()
    {
        Console.Clear();
        Console.WriteLine(">>> CADASTRO DE PET <<<");

        Console.Write("Digite o nome do pet: ");
        string nomePet = Console.ReadLine()!;
        
        foreach (Pet pet in Cadastro.petsCadastrados)
        {
            if(pet.Nome == nomePet)
            {
                Console.WriteLine($"\nNome: {pet.Nome}");
                Console.WriteLine($"Raça: {pet.Raca}");
                Console.WriteLine($"Idade: {pet.Idade}");
                Console.WriteLine($"Endereço: {pet.Dono.Nome}");

            }
        }
        Console.Write($"Aperte uma tecla para sair");
        Console.ReadKey();       
    }
}
