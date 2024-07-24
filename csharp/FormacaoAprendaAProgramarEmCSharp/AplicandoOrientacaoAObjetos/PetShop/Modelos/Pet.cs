namespace PetShop.Modelos;

public class Pet
{
    public string Nome { get; }
    public string Raca { get; }
    public int Idade { get; }
    public Dono Dono { get; }

    public Pet(string nome, string raca, int idade, Dono dono)
    {
        Nome = nome;
        Raca = raca;
        Idade = idade;
        Dono = dono;
    }
}
