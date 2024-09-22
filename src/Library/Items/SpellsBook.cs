namespace Ucu.Poo.RoleplayGame;

public class SpellsBook: IItems
{
    public List<Spell> Spells { get; set; } = new List<Spell>();

    public SpellsBook(Spell hechizo)
    {
        Spells.Add(hechizo);
    }

    
    public int AttackValue
    {
        get
        {
            int value = 0;
            foreach (Spell spell in Spells)
            {
                value += spell.AttackValue;
            }
            return value;
        }
    }

    public int DefenseValue
    {
        get
        {
            int value = 0;
            foreach (Spell spell in Spells)
            {
                value += spell.DefenseValue;
            }
            return value;
        }
    }
}
