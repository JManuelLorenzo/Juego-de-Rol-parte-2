namespace Ucu.Poo.RoleplayGame;

public class Staff : IItems
{
        public Staff(int ataque, int defensa)
        {
            this.AttackValue = ataque;
            this.DefenseValue = defensa;
        }
        public int AttackValue { get; private set; }
        public int DefenseValue { get; private set; }
}
    