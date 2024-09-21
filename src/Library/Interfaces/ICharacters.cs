namespace Ucu.Poo.RoleplayGame;

public interface ICharacters
{
    // Primeramente veo que metodos se repiten en cada clase.
    // Usando como referencia la clase Knight porque no tiene nada especial comienzo desde Name{get;set;} hasta Cure()
    // Teoricamente esto ya estaria terminado
    public string Name { get; set; }
    public int Health { get;}
    public int AttackValue { get;}
    public int DefenseValue { get; }
    public void ReceiveAttack(int value);
    public void Cure();
    public void SetHealth(int value);

}