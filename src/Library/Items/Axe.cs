namespace Ucu.Poo.RoleplayGame;

public class Axe: IItems
{
    public Axe(int ataque)
    {
        this.AttackValue = ataque;
        this.DefenseValue = 0;
    }

    public int AttackValue { get; private set; }

    public int DefenseValue { get; private set; }
}

