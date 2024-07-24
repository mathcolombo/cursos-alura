using System.Net.WebSockets;

namespace PetShop.Modelos;

public class Cadastro
{
    public static List<Dono> clientes = new List<Dono>();
    public static List<Pet> petsCadastrados = new List<Pet>();
    public static List<Medico> medicos = new List<Medico>();
    public static void MenuCadastrar()
    {
        Console.Clear();
        
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine(">>> MENU DE CADASTRO <<<");

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
                CadastrarCliente();
                break;
            case 2:
                CadastrarPet();
                break;
            case 3:
                CadastrarMedico();
                break;
            default:
                Console.WriteLine($"\nOpção inválida");
                break;               
        }

        MenuCadastrar();
    }

    public static void CadastrarCliente()
    {
        Console.Clear();
        Console.WriteLine(">>> CADASTRO DE CLIENTE <<<");

        Console.Write("\nNome: ");
        string nome = Console.ReadLine()!;
        Console.Write("Endereço: ");
        string endereco = Console.ReadLine()!;
        
        Console.Write($"Deseja cadastrar algum pet? ");
        if((Console.ReadLine()!.ToUpper()).Equals("Y")) CadastrarPet();
        

        clientes.Add(new Dono(nome, endereco));
        Console.WriteLine("CLIENTE CADASTRADO COM SUCESSO!!");

        Thread.Sleep(2500);
    }

    public static void CadastrarPet()
    {
        Console.Clear();
        Console.WriteLine(">>> CADASTRO DE PET <<<");

        Console.WriteLine("\nDono: ");
        string nomeDoDono = Console.ReadLine()!;
        int idDono = 0;

        for(int c = 0; c < clientes.Count ; c++)
        {
            if((clientes[c].Nome).Equals(nomeDoDono)) idDono = c;
        }

        Console.Write("Nome: ");
        string nome = Console.ReadLine()!;
        Console.Write("Raça: ");
        string raca = Console.ReadLine()!;
        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine()!);

        clientes[idDono].AdicionarPet(new Pet(nome, raca, idade, clientes[idDono]));
        Console.WriteLine("PET CADASTRADO COM SUCESSO!!");

        Thread.Sleep(2500);
    }

    public static void CadastrarMedico()
    {
        Console.Clear();
        Console.WriteLine(">>> CADASTRO DE MÉDICO <<<");

        Thread.Sleep(2500);
    }
}
