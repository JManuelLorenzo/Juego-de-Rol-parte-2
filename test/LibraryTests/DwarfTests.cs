namespace TestLibrary;

using NUnit.Framework;
using System.Collections.Generic;
using Ucu.Poo.RoleplayGame;


public class DwarfTests
{

    private Dwarf dwarf1;
    private Axe axe;
    private Shield shield;
    private Helmet helmet;

    [SetUp]
    public void Setup()
    {
        axe = new Axe(25); //25 de daño 
        helmet = new Helmet(18); //18 de proteccion
        shield = new Shield(14); //14 de proteccion

        dwarf1 = new Dwarf("Pelle");
        dwarf1.Axe = axe;
        dwarf1.Helmet = helmet;
        dwarf1.Shield = shield;
    }



    [Test]
    public void Validacion_Nombre()
    {
        Assert.That(dwarf1.Name, Is.EqualTo("Pelle"));
    }

    [Test]
    public void Ataque_Devuelve_El_Valor_Correcto(){
        Assert.That(25, Is.EqualTo(dwarf1.AttackValue));
    }

    [Test]
    public void Defensa_Devuelve_El_Valor_Correcto(){
        Assert.That(32, Is.EqualTo(dwarf1.DefenseValue));
    }

    [Test]
    public void Pierde_Vida(){
        dwarf1.ReceiveAttack(60);
        Assert.That(dwarf1.Health, Is.EqualTo(72));
    }

    [Test]
    public void Recibe_Ataque_Con_Defensa(){
        dwarf1.ReceiveAttack(10);
        Assert.That(dwarf1.Health, Is.EqualTo(100));
    }

    [Test]
    public void No_Puede_Tener_Vida_Negativa(){
        dwarf1.ReceiveAttack(9999999);
        Assert.That(dwarf1.Health, Is.EqualTo(0));
    }

    [Test]
    public void Curarse_Rellena_Toda_La_Vida(){
        dwarf1.ReceiveAttack(50);
        dwarf1.Cure();
        Assert.That(100, Is.EqualTo(dwarf1.Health));
    }
}