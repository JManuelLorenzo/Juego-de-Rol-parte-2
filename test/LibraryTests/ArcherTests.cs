using NUnit.Framework;
using System.Collections.Generic;
using Ucu.Poo.RoleplayGame; 

namespace TestLibrary;

public class ArcherTests
{

    private Archer arquero1;
    private Bow bow;
    private Helmet helmet;

    [SetUp]
    public void Setup()
    {
        bow = new Bow(15); //15 de daño 
        helmet = new Helmet(18); //18 de proteccion

        arquero1 = new Archer("Juan");
        arquero1.Bow = bow;
        arquero1.Helmet = helmet;
    }



    [Test]
    public void Validacion_Nombre()
    {
        Assert.That("Juan", Is.EqualTo(arquero1.Name));
    }

    [Test]
    public void Ataque_Devuelve_El_Valor_Correcto(){
        Assert.That(15, Is.EqualTo(arquero1.AttackValue));
    }

    [Test]
    public void Defensa_Devuelve_El_Valor_Correcto(){
        Assert.That(18, Is.EqualTo(arquero1.DefenseValue));
    }

    [Test]
    public void Pierde_Vida(){
        arquero1.Cure();
        arquero1.ReceiveAttack(60); 
        Assert.That(arquero1.Health, Is.EqualTo(58)); //estaba probando si se puede hacer de las formas
    } //Al tener 18 de defensa, solo le hace 42 de daño

    [Test]
    public void Recibe_Ataque_Con_Defensa(){
        arquero1.ReceiveAttack(10);
        Assert.That(arquero1.Health, Is.EqualTo(100));
    }

    [Test]
    public void No_Puede_Tener_Vida_Negativa(){
        arquero1.ReceiveAttack(9999999);
        Assert.That(arquero1.Health, Is.EqualTo(0));
    }

    [Test]
    public void Curarse_Rellena_Toda_La_Vida(){
        arquero1.ReceiveAttack(50);
        arquero1.Cure();
        Assert.That(100, Is.EqualTo(arquero1.Health));
    }
}
