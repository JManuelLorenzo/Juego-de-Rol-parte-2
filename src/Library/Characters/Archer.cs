namespace Ucu.Poo.RoleplayGame;

public class Archer : ICharacters
{
    private int health = 100;

    public Archer(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }
    
    public Bow Bow { get; set; }

    public Helmet Helmet { get; set; }

    public int Health
    {
        get { return health; }
    }

    public int AttackValue
    {
        get
        {
            return Bow.AttackValue;
        }
    }

    public int DefenseValue
    {
        get
        {
            return Helmet.DefenseValue;
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
