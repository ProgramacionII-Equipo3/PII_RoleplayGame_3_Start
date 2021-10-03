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
            Knight caballero1 = new Knight ("El caballero ");
            Archer arquero1 = new Archer ("Arquero");
            Hero[] heroes = new Hero[] { archer, knight };
            Cyclops ciclope1 = new Cyclops ("Cyclope");
            Golem golem1 = new Golem ("El golem");
            Enemy[] enemies = new Enemy[] { cyclops, golem };
            Encounter encounter = new Encounter(heroes, enemies);
            encounter.DoEncounter();


            



        }
    }
}