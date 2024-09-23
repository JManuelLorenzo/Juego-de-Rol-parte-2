namespace Ucu.Poo.RoleplayGame;

public class Bow: IItems
{
    public Bow(int ataque)
    {
        this.AttackValue = ataque;
        this.DefenseValue = 0;
    }
    public int AttackValue { get; private set; }
    public int DefenseValue { get; private set; }
    
}
