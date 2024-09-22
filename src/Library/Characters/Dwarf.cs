namespace Ucu.Poo.RoleplayGame;

public class Dwarf : ICharacters
{
    private int health = 100;

    public Dwarf(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }

    public Axe Axe { get; set; }

    public Shield Shield { get; set; }

    public Helmet Helmet { get; set; }

    public int Health
    {
        get { return health; }
    }

    public int AttackValue
    {
        get
        {
            return Axe.AttackValue;
        }
    }

    public int DefenseValue
    {
        get
        {
            return Shield.DefenseValue + Helmet.DefenseValue;
        }
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
}

