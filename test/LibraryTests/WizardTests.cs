/*
using NUnit.Framework;
using System.Collections.Generic;
using Ucu.Poo.RoleplayGame; 

namespace TestLibrary;

public class WizardTests
    {
        //Inicializamos
        private Wizard ElHechicero;
        private SpellsBook spellBook;
        private Spell hechizo1;
        private Staff baston;
    

    [SetUp]
    public void Setup(){
        spellBook = new SpellsBook();
        hechizo1 = new Spell();
        baston = new Staff();
        ElHechicero = new Wizard("radagast", 100);

    }

    [Test]
    public void AgregarItem(){
        ElHechicero.AddItem(baston);
        Assert.That(ElHechicero.TotalDamage(), Is.EqualTo(30));
    }

    [Test]
    public void BorrarItem(){
        ElHechicero.AddItem(baston);
        ElHechicero.RemoveItem(baston);
        Assert.That(ElHechicero.TotalDamage(), Is.EqualTo(0));
    }

    [Test]
    public void TotalDamage(){//Nombre en ingles para no usar ñ
        ElHechicero.AddItem(baston);
        Assert.That(ElHechicero.TotalDamage(), Is.EqualTo(30)); //Daño del bastón mas el bonus de magia
    }

    [Test]
    public void DefensaTotal(){
        ElHechicero.AddItem(baston);
        Assert.That(ElHechicero.TotalDefense(), Is.EqualTo(10));
    }

    [Test]
    public void UsarHechizo(){
        spellBook.AddSpell(hechizo1);
        Dwarf enano_target = new Dwarf("Random.exe", 1000); //Pruebo con Dwarf sin motivo, deberia funcionar para todos

        ElHechicero.UseSpell(hechizo1, enano_target);
        Assert.That(enano_target.GetLife(), Is.EqualTo(0));
    }   

    [Test]
    public void ReceiveDamage(){
        ElHechicero.ReceiveDamage(30);
        Assert.That(ElHechicero.GetLife(), Is.EqualTo(70));
    }

    [Test]
    public void Curarse(){
        ElHechicero.ReceiveDamage(50);
        ElHechicero.Heal();
        Assert.That(ElHechicero.GetLife(), Is.EqualTo(100));
    }

    [Test]
    public void ObtenerInfo(){
        ElHechicero.AddItem(baston);
        spellBook.AddSpell(hechizo1);
        Assert.That(ElHechicero.GetInfo(), Is.EqualTo("Nombre: Pato Lucas, life: 100\nItems:\n- Bastón mágico (Ataque: 20, Defensa: 10)\nTotal Ataque: 30\nTotal Defensa: 10\nMagia: 5\nHechizos:\n- Rempalagos (Ataque: 1000)\n"));
    }

    [Test]
    public void IncrementarMagia(){ //Mediante el estudio incrementar la magia de ElHechizero con sus increibles poderes
        //Antes de estudiar:
        Console.WriteLine(ElHechicero.TotalDamage());
        
    }

}
*/