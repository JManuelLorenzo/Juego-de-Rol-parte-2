namespace Ucu.Poo.RoleplayGame;

public class Sword : IItems
{
    public Sword(int ataque)
    {
        this.AttackValue =ataque;
        this.DefenseValue = 0; // Las espadas no dan defensa.
    }
    public int AttackValue { get; private set; }

    public int DefenseValue {get; private set;}
}

