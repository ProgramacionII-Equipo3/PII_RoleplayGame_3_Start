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
        public void ItemEquiped ()
        {
            Knight caballero = new Knight ("caballero");
            int damageExpected = 20;
            int defenseExpected = 39;
            Assert.AreEqual(damageExpected, caballero.AttackValue);
            Assert.AreEqual(defenseExpected, caballero.DefenseValue);

            Cyclops ciclope = new Cyclops ("ciclope");
            int damageExpected = 25;
            int defenseExpected = 14;
            Assert.AreEqual(damageExpected, ciclope.AttackValue);
            Assert.AreEqual(defenseExpected, ciclope.DefenseValue);
        }
    }
}