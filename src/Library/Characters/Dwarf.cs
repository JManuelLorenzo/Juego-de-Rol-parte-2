namespace Ucu.Poo.RoleplayGame;

public class Dwarf
{
    private int health = 100;

    public Dwarf(string name)
    {
        this.Name = name;
        Axe = new Axe();
        Shield = new Shield();
        Helmet = new Helmet();
        
        Objetos.Add(Axe);
        Objetos.Add(Shield);
        Objetos.Add(Helmet);
    }
    
    public string Name { get; set; }

    public Axe Axe { get; set; }
    public Shield Shield { get; set; }
    public Helmet Helmet { get; set; }

<<<<<<< Updated upstream
    public int AttackValue
    {
        get
        {
            return Axe.AttackValue;
        }
    }
=======
    public List<IItems> Objetos { get; set; } = new List<IItems>();

    public int Health => health;
>>>>>>> Stashed changes

    public int AttackValue => Axe.AttackValue;

    public int DefenseValue => Shield.DefenseValue + Helmet.DefenseValue;

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
<<<<<<< Updated upstream
}
=======

    public string GetInfo() // Cambiado a PascalCase
    {
        string info = $"Nombre: {Name}, Vida: {health}\nItems: Axe, Shield y Helmet\n"; // Se podria utilizar una foreach para establecer los nombres de forma adaptativa.

        foreach (IItems item in Objetos)
        {
            info += $"- {item.GetType().Name} (Ataque: {item.AttackValue}, Defensa: {item.DefenseValue})\n"; // Cierre de comillas corregido
        }

        info += $"Total Ataque: {AttackValue}\n";
        info += $"Total Defensa: {DefenseValue}\n";

        return info;
    }
}
>>>>>>> Stashed changes
