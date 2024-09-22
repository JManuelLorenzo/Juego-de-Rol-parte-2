namespace Ucu.Poo.RoleplayGame;

public class Elf : ICharacters
{
    private int health = 100;

    public Elf(string name)
    {
        this.Name = name;
        Bow = new Bow();

        Objetos.Add(Bow);
    }

    public string Name { get; set; }

    public Bow Bow { get; set; }

    public List<IItems> Objetos { get; set; } = new List<IItems>();

    public int Health
    {
        get { return health; }
    }

    public int AttackValue
    {
        get { return Bow.AttackValue * 2; } // Los Elfos hacen el doble de daño con el arco.
    }

    public int DefenseValue
    {
        get { return 0; } // Los Elfos no tienen defensa
    }

    public void ReceiveAttack(int power)
    {
        if (this.DefenseValue < power)
        {
            SetHealth(this.health - (power - this.DefenseValue));
        }
    }

    public void Cure()
    {
        SetHealth(100);
    }

    public void SetHealth(int value)
    {
        this.health = value < 0 ? 0 : value; // Controla el límite inferior
    }

    public string GetInfo() // Cambiado a PascalCase
    {
        string info = $"Nombre: {Name}, Vida: {health}\nItems: Bow\n";

        foreach (IItems item in Objetos)
        {
            info += $"- {item.GetType().Name} (Ataque: {item.AttackValue}, Defensa: {item.DefenseValue})\n";
        }

        info += $"Total Ataque: {AttackValue}\n";
        info += $"Total Defensa: {DefenseValue}\n";

        return info;
    }
}