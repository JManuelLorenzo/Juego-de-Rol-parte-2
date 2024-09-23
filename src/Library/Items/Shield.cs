namespace Ucu.Poo.RoleplayGame;

public class Shield : IItems
{
    
    public Shield( int defensa)
    {
        this.AttackValue = 0; // los shields no dan ataque.
        this.DefenseValue = defensa;
    }
    public int AttackValue { get; private set; }
    public int DefenseValue { get; private set; }
    
}
