namespace Ucu.Poo.RoleplayGame;

public class Archer
{
    private int health = 100;

    public Archer(string name)
    {
        this.Name = name;
        Bow = new Bow();
        Helmet = new Helmet();

        Objetos.Add(Bow);
        Objetos.Add(Helmet);
    }

    public string Name { get; set; }

    public Bow Bow { get; set; }
    public Helmet Helmet { get; set; }

<<<<<<< Updated upstream
=======
    public List<IItems> Objetos { get; set; } = new List<IItems>();

    public int Health
    {
        get { return health; }
    }

>>>>>>> Stashed changes
    public int AttackValue
    {
        get { return Bow.AttackValue; }
    }

    public int DefenseValue
    {
        get { return Helmet.DefenseValue; }
    }

    public int Health
    {
        get
        {
            return this.health;
        }
        private set
        {
            this.health = value < 0 ? 0 : value;
        }
    }

    public void ReceiveAttack(int power)
    {
        if (this.DefenseValue < power)
        {
            this.Health -= power - this.DefenseValue;
        }
    }

    public void Cure()
    {
        this.Health = 100;
    }

    public string GetInfo() // Cambiado a PascalCase
    {
        string info = $"Nombre: {Name}, Vida: {health}\nItems: Bow y Helmet\n";

        foreach (IItems item in Objetos)
        {
            info += $"- {item.GetType().Name} (Ataque: {item.AttackValue}, Defensa: {item.DefenseValue})\n";
        }

        info += $"Total Ataque: {AttackValue}\n";
        info += $"Total Defensa: {DefenseValue}\n";

        return info;
    }
}