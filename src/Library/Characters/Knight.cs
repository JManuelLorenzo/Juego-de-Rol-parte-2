namespace Ucu.Poo.RoleplayGame;

    public class Knight : ICharacters
    {
        
        private int health = 100;
        public string Name { get; set; }

        public Sword Sword { get; set; }

        public Shield Shield { get; set; }

        public Armor Armor { get; set; }

        public Knight(string name)
        {
            this.Name = name;
        }

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
            if (DefenseValue < power)
            {
               SetHealth( health - (power - DefenseValue));
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
