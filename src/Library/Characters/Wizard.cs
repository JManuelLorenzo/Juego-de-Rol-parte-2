namespace Ucu.Poo.RoleplayGame;

public class Wizard : ICharacters
{
    private int health = 100;
    public int Mana { get; set; }

    public string Name { get; set; }
    
    private SpellsBook Libro { get; set; }

    private Staff Baston { get; set; }

    public Wizard(string name, int mana, SpellsBook libro, Staff staff) //Constructor
    {
        this.Name = name;
        this.Mana = mana;
        this.Libro = libro;
        this.Baston = staff;
    }

    public int Health // Vida
    {
        get { return health; }
    }

    public int AttackValue // Ataque
    {
        get
        {
            return Libro.AttackValue + Baston.AttackValue + Mana;
        }
    }

    public int DefenseValue // Defensa
    {
        get
        {
            return Libro.DefenseValue + Baston.DefenseValue + Mana;
        }
    }

    public void ReceiveAttack(int power)
    {
        if (this.DefenseValue < power)
        {
            SetHealth(this.health - (power - this.DefenseValue));
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

    
    public void Study(int cantidad)
    {
        for (int i = 0; i<cantidad; i++){
            this.Mana++;
        }

        if (cantidad > 100 ){
            Console.WriteLine("Tremendo nerd 🤓");
        }
    }

    public string GetInfo() // Metodo que permite obtener toda la informacion del personaje, en este caso se trata del Wizzard(mago).
    {
        string info = $"Nombre: {this.Name}. \nVida: {this.Health}. \nSpells Book: {this.Libro}. \nTotal Ataque: {AttackValue}. \n Total Defensa: {DefenseValue}.";
        
        return info;

    }
}

