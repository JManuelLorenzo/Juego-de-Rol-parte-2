namespace Ucu.Poo.RoleplayGame;

public class Wizard : ICharacters
{
    private int health = 100;
    private int mana;

    public Wizard(string name, int mana)
    {
        this.Name = name;
        this.mana = mana;
    }

    public string Name { get; set; }
    
    public SpellsBook SpellsBook { get; set; }

    public Staff Staff { get; set; }

    public int Health
    {
        get { return health; }
    }

    public int AttackValue
    {
        get
        {
            return SpellsBook.AttackValue + Staff.AttackValue + mana;
        }
    }

    public int DefenseValue
    {
        get
        {
            return SpellsBook.DefenseValue + Staff.DefenseValue + mana;
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
    public void Study()
    {
        this.mana++;
    }
}

