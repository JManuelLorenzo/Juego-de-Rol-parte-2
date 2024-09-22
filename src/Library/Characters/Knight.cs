namespace Ucu.Poo.RoleplayGame;

public class Knight : ICharacters
{
    private int health = 100;

    public Knight(string name)
    {
        this.Name = name;
        Sword = new Sword();
        Shield = new Shield();
        Armor = new Armor();

        Objetos.Add(Sword);
        Objetos.Add(Shield);
        Objetos.Add(Armor);
    }

    public string Name { get; set; }

    public Sword Sword { get; set; }
    public Shield Shield { get; set; }
    public Armor Armor { get; set; }

    public List<IItems> Objetos { get; set; } = new List<IItems>();

    public int Health
    {
        get { return health; }
    }

    public int AttackValue
    {
        get { return Sword.AttackValue; }
    }

    public int DefenseValue
    {
        get { return Armor.DefenseValue + Shield.DefenseValue; }
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
        string info = $"Nombre: {Name}, Vida: {health}\nItems: Sword, Shield y Armor\n";

        foreach (IItems item in Objetos)
        {
            info += $"- {item.GetType().Name} (Ataque: {item.AttackValue}, Defensa: {item.DefenseValue})\n";
        }

        info += $"Total Ataque: {AttackValue}\n";
        info += $"Total Defensa: {DefenseValue}\n";

        return info;
    }
}