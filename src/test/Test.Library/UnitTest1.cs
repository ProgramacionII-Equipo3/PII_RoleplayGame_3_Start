using NUnit.Framework;

namespace Test.Library
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        
        [Test]
        public void EncounterTest()
        {
            // Heroe
            Archer arquero1 = new Archer ("Arquero");
            arquero1.Bow = new Bow();
            arquero1.Helmet = new Helmet();
            
            // Enemy
            Cyclops ciclope1 = new Cyclops ("Cyclope");
            ciclope1.Shield = new Shield ();
            ciclope1.Axe = new Axe ();
            
            // Enemy
            Golem golem1 = new Golem ("El golem");
            golem1.Axe = new Axe ();
            golem1.Armor = new Armor ();

            // Heroe
            Knight caballero1 = new Knight ("El caballero ");
            caballero1.Sword = new Sword ();
            caballero1.Armor = new Armor ();
            caballero1.Shield = new Shield();

            



        }
    }
}