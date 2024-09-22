namespace Ucu.Poo.RoleplayGame;

public class Wizard
{
    private int health = 100;

    public Wizard(string name)
    {
        this.Name = name;
<<<<<<< Updated upstream
=======
        this.mana = mana;
        SpellsBook = new SpellsBook();
        Staff = new Staff();

        Objetos.Add(SpellsBook);
        Objetos.Add(Staff);
>>>>>>> Stashed changes
    }

    public string Name { get; set; }

    public SpellsBook SpellsBook { get; set; }
    public Staff Staff { get; set; }

<<<<<<< Updated upstream
    public int AttackValue
    {
        get
        {
            return SpellsBook.AttackValue + Staff.AttackValue;
        }
=======
    public List<IItems> Objetos { get; set; } = new List<IItems>();

    public int Health
    {
        get { return health; }
    }

    public int AttackValue
    {
        get { return SpellsBook.AttackValue + Staff.AttackValue + mana; }
>>>>>>> Stashed changes
    }

    public int DefenseValue
    {
<<<<<<< Updated upstream
        get
        {
            return SpellsBook.DefenseValue + Staff.DefenseValue;
        }
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
=======
        get { return SpellsBook.DefenseValue + Staff.DefenseValue + mana; }
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
        this.Health = 100;
    }
}
=======
        SetHealth(100);
    }

    public void SetHealth(int value)
    {
        this.health = value < 0 ? 0 : value; // Controla el límite inferior
    }

    public void Study()
    {
        this.mana++;
    }

    public string GetInfo() // Cambiado a PascalCase
    {
        string info = $"Nombre: {Name}, Vida: {health}, Mana: {mana}\n";
        info += $"Items: Staff, Spellbook\n";

        foreach (IItems item in Objetos)
        {
            info += $"- {item.GetType().Name} (Ataque: {item.AttackValue}, Defensa: {item.DefenseValue})\n";
        }

        info += $"Total Ataque: {AttackValue}\n";
        info += $"Total Defensa: {DefenseValue}\n";

        return info;
    }
}
>>>>>>> Stashed changes
