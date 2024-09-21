namespace Ucu.Poo.RoleplayGame;

public class Wizard
{
    private int health = 100;
    public Wizard(string name, int mana)
    {
        this.Name = name;
        this.Mana = mana;
    }

    public string Name { get; set; }
    private int Mana { get; set; }
    public SpellsBook SpellsBook { get; set; }

    public Staff Staff { get; set; }

    public int AttackValue
    {
        get
        {
            return SpellsBook.AttackValue + Staff.AttackValue + Mana;
        }
    }

    public int DefenseValue
    {
        get
        {
            return SpellsBook.DefenseValue + Staff.DefenseValue + Mana;
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

    public void Study()
    {
        this.Mana ++;
    }
}
