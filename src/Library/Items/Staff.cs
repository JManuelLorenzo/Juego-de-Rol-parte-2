namespace Ucu.Poo.RoleplayGame;

public class Staff : IItems
{

    private int _attackValue;
    private int _defenseValue;

    public Staff (int ataque, int defensa){
        _attackValue = ataque;
        _defenseValue = defensa;
    }

    public int AttackValue 
    {
        get
        {
            return _attackValue;
        } 
    }

    public int DefenseValue
    {
        get
        {
            return _defenseValue;
        }
    }
}
