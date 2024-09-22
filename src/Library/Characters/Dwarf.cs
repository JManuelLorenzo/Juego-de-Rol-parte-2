namespace Ucu.Poo.RoleplayGame;

public class Dwarf : ICharacters
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

    public List<IItems> Objetos { get; set; } = new List<IItems>();

    public int Health
    {
        get { return health; }
    }

    public int AttackValue
    {
        get { return Axe.AttackValue; }
    }

    public int DefenseValue
    {
        get { return Shield.DefenseValue + Helmet.DefenseValue; }
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
        string info = $"Nombre: {Name}, Vida: {health}\nItems: Axe, Shield y Helmet\n";

        foreach (IItems item in Objetos)
        {
            info += $"- {item.GetType().Name} (Ataque: {item.AttackValue}, Defensa: {item.DefenseValue})\n";
        }

        info += $"Total Ataque: {AttackValue}\n";
        info += $"Total Defensa: {DefenseValue}\n";

        return info;
    }
}
