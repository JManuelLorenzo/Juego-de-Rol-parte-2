namespace Ucu.Poo.RoleplayGame;

public class Wizard : ICharacters
{
    private int health = 100;
    private int mana;

    public Wizard(string name, int mana)
    {
        this.Name = name;
        this.mana = mana;
        SpellsBook = new SpellsBook();
        Staff = new Staff();

        Objetos.Add(SpellsBook);
        Objetos.Add(Staff);
    }

    public string Name { get; set; }
    
    public SpellsBook SpellsBook { get; set; }
    public Staff Staff { get; set; }

    public List<IItems> Objetos { get; set; } = new List<IItems>();

    public int Health
    {
        get { return health; }
    }

    public int AttackValue
    {
        get { return SpellsBook.AttackValue + Staff.AttackValue + mana; }
    }

    public int DefenseValue
    {
        get { return SpellsBook.DefenseValue + Staff.DefenseValue + mana; }
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

    public void Study()
    {
        this.mana++;
    }

    public string GetInfo() // Cambiado a PascalCase
    {
        string info = $"Nombre: {Name}, Vida: {health}, Mana: {mana}\n";
        info += $"Items:\n";

        foreach (IItems item in Objetos)
        {
            info += $"- {item.GetType().Name} (Ataque: {item.AttackValue}, Defensa: {item.DefenseValue})\n";
        }

        info += $"Total Ataque: {AttackValue}\n";
        info += $"Total Defensa: {DefenseValue}\n";

        return info;
    }
}