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
            int wizardExpected = 98;
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

        [Test]
        public void EncounterTest()  // Test for encounter between enemies 
        {
            Archer archer = new Archer("Archer");
            Dwarf dwarf = new Dwarf("Dwarf");
            Knight knight = new Knight("Knight");
            Wizard wizard = new Wizard("Wizard");
            Hero[] heroes = new Hero[] { archer, dwarf, knight, wizard };
            
            Cyclops cyclops = new Cyclops("Cyclops");
            Dragon dragon = new Dragon("Dragon");
            Golem golem = new Golem("Golem");
            Skeleton skeleton = new Skeleton("Skeleton");
            Enemy[] enemies = new Enemy[] { cyclops, dragon, golem, skeleton };

            Encounter encounter = new Encounter(heroes, enemies);
            encounter.DoEncounter();

            int archerExpected = 0;
            int dwarfExpected = 0;
            int knightExpected = 0;
            int wizardExpected = 0;
            Assert.AreEqual(archerExpected, archer.Health);
            Assert.AreEqual(dwarfExpected, dwarf.Health);
            Assert.AreEqual(knightExpected, knight.Health);
            Assert.AreEqual(wizardExpected, wizard.Health);

            int cyclopsExpected = 0;
            int dragonExpected = 24;
            int golemExpected = 100;
            int skeletonExpected = 100;
            Assert.AreEqual(cyclopsExpected, cyclops.Health);
            Assert.AreEqual(dragonExpected, dragon.Health);
            Assert.AreEqual(golemExpected, golem.Health);
            Assert.AreEqual(skeletonExpected, skeleton.Health);
        }

        [Test] 
        public void CureTest()  // Test if the hero win the VP points for kill an enemy, and when the hero get 5 VP, it has to be cured 
        {
            Cyclops cyclops = new Cyclops("Cyclops");
            Cyclops cyclops2 = new Cyclops("Cyclops");
            Archer archer = new Archer("Archer");
            cyclops2.Attack(archer);
            while(cyclops.Health > 0)
            {
                archer.Attack(cyclops);
            }
            while(cyclops2.Health > 0)
            {
                archer.Attack(cyclops2);
            }
            
            int archerExpectedVP = 1;
            int archerHealthExpected = 100;

            Assert.AreEqual(archerExpectedVP, archer.VictoryPoints);
            Assert.AreEqual(archerHealthExpected, archer.Health);
        }    
    }
}