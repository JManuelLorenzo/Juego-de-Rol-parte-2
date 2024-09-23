using NUnit.Framework;
using System.Collections.Generic;
using Ucu.Poo.RoleplayGame; 

namespace TestLibrary;

public class WizardTests
    {
        //Inicializamos
        private Wizard ElHechicero;
        private SpellsBook Libro;
        private Staff Baston;
        private Spell hechizo;

        [SetUp]
        public void Setup()
        {
            // Configuración inicial
            hechizo = new Spell(30,20); // 30 de ataque 20 de defensa

            Libro = new SpellsBook(hechizo); // agrega hechizo

            Baston = new Staff(15,10); // 15 de ataque, 10 de defensa

            ElHechicero = new Wizard("Gandalf", 50, Libro, Baston); //string name, int mana, SpellsBook libro, Staff staff
        }

    [Test] //Health
    public void Vida_Retorna_Valor_Correcto(){
        Assert.That(ElHechicero.Health, Is.EqualTo(100));
    }


    [Test] //Set Health
    public void Setear_Vida(){
        ElHechicero.SetHealth(-100);
        Assert.That(ElHechicero.Health, Is.EqualTo(0));

    }

    [Test]
        public void AttackValue()
        {
            // Act
            int attackValue = ElHechicero.AttackValue;

            // Assert
            Assert.That(attackValue, Is.EqualTo(95)); // 30 (SpellsBook) + 15 (Staff) + 50 (Mana)
        }


    [Test]
    public void DefensaTotal(){
        int defenseValue = ElHechicero.DefenseValue;
        Assert.That(defenseValue, Is.EqualTo(80));
    }   //Libro.DefenseValue + Baston.DefenseValue + Mana;

    [Test]
    public void ReceiveAttack(){
        ElHechicero.ReceiveAttack(100);

        Assert.That(ElHechicero.Health, Is.EqualTo(80));
        
    }   

    [Test]
    public void Curarse(){
        ElHechicero.ReceiveAttack(50);
        ElHechicero.Cure();
        Assert.That(ElHechicero.Health, Is.EqualTo(100));
    }

    [Test]
    public void ObtenerInfo(){
        Assert.That(ElHechicero.GetInfo(), Is.EqualTo( $"Nombre: Gandalf. \nVida: 100. \nSpells Book: {Libro}. \nTotal Ataque: {ElHechicero.AttackValue}. \n Total Defensa: {ElHechicero.DefenseValue}.")); 
    }

    [Test]
    public void Estudiar_Aumenta_Mana(){
        ElHechicero.Study(5);
        int mana = ElHechicero.Mana;
        Assert.That(mana, Is.EqualTo(55));
    }


}