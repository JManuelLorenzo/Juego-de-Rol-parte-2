namespace Ucu.Poo.RoleplayGame;

public class Staff : IItems
{
        public Staff(int ataque)
        {
            this.AttackValue = ataque;
            this.DefenseValue = 0; // Los staff no tienen defensa.
        }
        public int AttackValue { get; private set; }
        public int DefenseValue { get; private set; }
}
    