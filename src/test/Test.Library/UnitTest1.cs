using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AttackTest() // Test if the characters can be attacked
        {            
            SpellsBook book = new SpellsBook();
            book.AddSpell(new SpellOne());
            book.AddSpell(new SpellOne());
            
            Wizard wizard = new Wizard("Wizard");
            wizard.AddItem(book);

            Dwarf dwarf = new Dwarf("Dwarf");

            int dwarfExpected = 0;
            int wizardExpected = 100;
            dwarf.ReceiveAttack(wizard.AttackValue);
            wizard.ReceiveAttack(dwarf.AttackValue);
           
            Assert.AreEqual(dwarfExpected, dwarf.Health);
            Assert.AreEqual(wizardExpected, wizard.Health);
        }

        [Test]
        public void IsItemsEquiped() // Test for the item that can be equipped for the characters
        {
            Dwarf manolo = new Dwarf("Manolo");
            int damageExpected = 25;
            int defenseExpected = 18;

            Assert.AreEqual(damageExpected, manolo.AttackValue);
            Assert.AreEqual(defenseExpected, manolo.DefenseValue);

            SpellsBook libro = new SpellsBook();
            libro.AddSpell(new SpellOne());
            libro.AddSpell(new SpellOne());
            Wizard mario = new Wizard("Mario");
            mario.AddItem(libro);
            
            int attackExpected = 240;
            int defensevalueExpected = 240;

            Assert.AreEqual(attackExpected, mario.AttackValue);
            Assert.AreEqual(defensevalueExpected, mario.DefenseValue);
        }

        [Test]
        public void HealingTest() // Test for  character´s Cure method
        {
            Archer robin = new Archer("Robin");

            Knight batman = new Knight("Batman");

            batman.ReceiveAttack(robin.AttackValue);
            int healthExpected = 100;
            batman.Cure();
            Assert.AreEqual(healthExpected, batman.Health);
            
        }
    }
}