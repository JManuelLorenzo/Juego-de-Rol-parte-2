using NUnit.Framework;
using System.Collections.Generic;
using Ucu.Poo.RoleplayGame; 

namespace TestLibrary;

public class  Knighttest
{

    private Knight knight1;
    private Sword sword;
    private Shield shield;
    private Armor armor;
    [SetUp]
    public void Setup()
    {
        sword = new Sword(15); //15 de daño 
        shield = new Shield(18); //18 de proteccion
        armor = new Armor(18); //18 de proteccion
        knight1 = new Knight("Gsus");
        knight1.Sword = sword;
        knight1.Shield = shield;
        knight1.Armor = armor;
    }



    [Test]
    public void Validacion_Nombre()
    {
        Assert.That("Gsus", Is.EqualTo(knight1.Name));
    }

    [Test]
    public void Ataque_Devuelve_El_Valor_Correcto(){
        Assert.That(15, Is.EqualTo(knight1.AttackValue));
    }

    [Test]
    public void Defensa_Devuelve_El_Valor_Correcto(){
        Assert.That(36, Is.EqualTo(knight1.DefenseValue));
    }

    [Test]
    public void Pierde_Vida(){
        knight1.Cure();
        knight1.ReceiveAttack(60);
        Assert.That(knight1.Health, Is.EqualTo(76));
    }

    [Test]
    public void Recibe_Ataque_Con_Defensa(){
        knight1.ReceiveAttack(10);
        Assert.That(knight1.Health, Is.EqualTo(100));
    }

    [Test]
    public void No_Puede_Tener_Vida_Negativa(){
        knight1.ReceiveAttack(9999999);
        Assert.That(knight1.Health, Is.EqualTo(0));
    }

    [Test]
    public void Curarse_Rellena_Toda_La_Vida(){
        knight1.ReceiveAttack(50);
        knight1.Cure();
        Assert.That(100, Is.EqualTo(knight1.Health));
    }
}