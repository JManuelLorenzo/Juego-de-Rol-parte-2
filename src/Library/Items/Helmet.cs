namespace Ucu.Poo.RoleplayGame;

public class Helmet: IItems
{
    public Helmet( int defense)
    {
        this.AttackValue = 0; // los helmets no dan ataque.
        this.DefenseValue = defense;
    }
    public int AttackValue { get; private set; }
    public int DefenseValue { get; private set; }
}
