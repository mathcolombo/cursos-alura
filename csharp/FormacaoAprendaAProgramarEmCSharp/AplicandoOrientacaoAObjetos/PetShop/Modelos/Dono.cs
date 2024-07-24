namespace PetShop.Modelos;

public class Dono
{
    public string Nome { get; }
    public string Endereco { get; set; }
    public List<Pet> Pets = new List<Pet>();

    public Dono(string nome, string endereco)
    {
        Nome = nome;
        Endereco = endereco;
    }

    public void AdicionarPet(Pet pet)
    {
        Pets.Add(pet);
    }
}
