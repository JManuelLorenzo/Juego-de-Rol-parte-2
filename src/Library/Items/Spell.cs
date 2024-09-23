namespace Ucu.Poo.RoleplayGame;

public class Spell : IItems
{


    public Spell(int ataque, int defensa)
    {
        AttackValue = ataque;
        DefenseValue = defensa;
    }

    public int AttackValue { get; private set; }

    public int DefenseValue { get; private set; }
}
