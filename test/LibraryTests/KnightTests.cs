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
        sword = new Sword(); //15 de daño 
        shield = new Shield(); //18 de proteccion
        armor = new Armor(); //18 de proteccion
        knight1 = new Knight("Gsus");
        knight1.Sword = new Sword();
        knight1.Shield = new Shield(); //14 de proteccion
        knight1.Armor = new Armor();   //25 de proteccion
    }



    [Test]
    public void Validacion_Nombre()
    {
        Assert.That("Gsus", Is.EqualTo(knight1.Name));
    }

    [Test]
    public void Ataque_Devuelve_El_Valor_Correcto(){
        Assert.That(20, Is.EqualTo(knight1.AttackValue));
    }

    [Test]
    public void Defensa_Devuelve_El_Valor_Correcto(){
        Assert.That(39, Is.EqualTo(knight1.DefenseValue));
    }

    [Test]
    public void Pierde_Vida(){
        knight1.Cure();
        knight1.ReceiveAttack(60);
        Assert.That(knight1.Health, Is.EqualTo(79)); //estaba probando si se puede hacer de las formas
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