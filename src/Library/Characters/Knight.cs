namespace Ucu.Poo.RoleplayGame;

    public class Knight : ICharacters
    {
        

        public Knight(string name)
        {
            this.Name = name;
        }
        private int health = 100;
        public string Name { get; set; }

        public Sword Sword { get; set; }

        public Shield Shield { get; set; }

        public Armor Armor { get; set; }

        public int Health
        {
            get { return health; }
        }

        public int AttackValue
        {
            get
            {
                return Sword.AttackValue;
            }
        }

        public int DefenseValue
        {
            get
            {
                return Armor.DefenseValue + Shield.DefenseValue;
            }
        }

        
        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
               SetHealth( this.health - (power - this.DefenseValue));
            }
        }

        public void Cure()
        {
            SetHealth(100);
        }
        

        public void SetHealth(int value)
        {
           this.health = value < 0 ? 0 : value; // Controla el límite inferior
        }
    }
