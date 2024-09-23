namespace Ucu.Poo.RoleplayGame;

public class Armor : IItems
{
    public Armor(int defensa)
    {
        this.AttackValue = 0;
        this.DefenseValue = defensa;
    }

    public int AttackValue { get; private set; }

    public int DefenseValue { get; private set; }
}
