//List<string> bandsList = new List<string>();
Dictionary<string, List<int>> bandsList = new Dictionary<string, List<int>>();

void ShowLogo() 
{
    Console.WriteLine(@"
        
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    Console.WriteLine("Bem vindo ao Screen Sound");
    Console.Write(".");
    Thread.Sleep(700);
    Console.Write(".");
    Thread.Sleep(700);
    Console.Write(".");
    Thread.Sleep(1000);
    Console.Clear();
    
}

void ShowMenu()
{
    while(true)
    {
        ShowTitle("Menu");

        Console.WriteLine("-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲");
        Console.WriteLine("\n[ 1 ] Registrar uma banda");
        Console.WriteLine("\n[ 2 ] Mostrar todas as bandas");
        Console.WriteLine("\n[ 3 ] Avaliar uma banda");
        Console.WriteLine("\n[ 4 ] Exibir média de uma banda");
        Console.WriteLine("\n[ 0 ] SAIR");
        Console.WriteLine("-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅-̅");
        
        Console.Write("Digite sua opção: ");
        string temp = Console.ReadLine()!;
                                
        if(temp.Equals(0))
            break;

        Director(int.Parse(temp));
    }
    Console.WriteLine("Até mais ;)");
    
}

void Director(int opcUser)
{
    switch(opcUser)
    {
        case 1:
            RegisterBand();
            break;
        case 2:
            ShowBands();        
            break;
        case 3:
            RateBand();
            break;
        case 4:
            Console.WriteLine("Opção 4");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void RegisterBand()
{
    Console.Clear();
    ShowTitle("Registro de banda");
    
    Console.Write("Digite o nome da banda: ");
    string bandName = Console.ReadLine()!;
    bandsList.Add(bandName, new List<int>());
    Console.WriteLine($"A banda {bandName} foi registrada com sucesso!!");
    Thread.Sleep(2000);
    Console.Clear();
}

void RateBand()
{
    Console.Clear();
    ShowTitle("Avaliar banda");

    Console.Write("Banda à avaliar: ");
    string bandName = Console.ReadLine()!;
    
    if(bandsList.ContainsKey(bandName))
    {

    } else
    {
        Console.WriteLine("Banda não registrada!! deseja registrá-la?");
        Console.Write("[Y / N] ");
        string temp = Console.ReadLine()!;

        if(temp.Equals("Y"))
            RegisterBand();
    }
}

void ShowBands()
{
    Console.Clear();
    Console.WriteLine(">> Bandas registradas <<");   
    foreach (string band in bandsList.Keys)
        Console.Write($"{band}, ");
    Thread.Sleep(3500);
    Console.Clear();
}

void ShowTitle(string title)
{
    int lettersNum = title.Length;
    string formattTitle = string.Empty.PadLeft(lettersNum, '=');
    Console.WriteLine(formattTitle);
    Console.WriteLine(title);
    Console.WriteLine(formattTitle + "\n");
}

ShowLogo();
ShowMenu();