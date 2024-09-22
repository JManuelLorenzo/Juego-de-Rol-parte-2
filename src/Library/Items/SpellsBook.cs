namespace Ucu.Poo.RoleplayGame;


public class SpellsBook : IItems
{
    public Spell[] Spells { get; set; }

    public SpellsBook()
    {
        Spells = new Spell[0]; // Inicializa con un array vacío
    }

    public int AttackValue
    {
        get
        {
            int value = 0;
            foreach (Spell spell in this.Spells)
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
            foreach (Spell spell in this.Spells)
            {
                value += spell.DefenseValue;
            }
            return value;
        }
    }
}
