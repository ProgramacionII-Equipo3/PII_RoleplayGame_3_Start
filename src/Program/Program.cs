using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            book.AddSpell(new SpellOne());
            book.AddSpell(new SpellOne());

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.AddItem(book);

            Dwarf gimli = new Dwarf("Gimli");

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

            gimli.ReceiveAttack(gandalf.AttackValue);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Someone cured Gimli. Gimli now has ❤️ {gimli.Health}");

            Skeleton skeleton = new Skeleton("Juan");
            skeleton.Attack(gimli);
            Console.WriteLine($"Gimli has {gimli.Health}");

            gimli.Attack(skeleton);
            Console.WriteLine($"Skeleton has {skeleton.Health}");

            // Doing an encounter between characters
            Archer archer = new Archer("Archer");
            Dwarf dwarf = new Dwarf("Dwarf");
            Knight knight = new Knight("Knight");
            Wizard wizard = new Wizard("Wizard");
            Hero[] heroes = new Hero[] { archer, dwarf, knight, wizard };

            Cyclops manolo = new Cyclops("Manolo");
            Dragon juan = new Dragon("Juan");
            Golem pablo = new Golem("Pablo");
            Skeleton tito = new Skeleton("Tito");
            Enemy[] enemies = new Enemy[] { manolo, juan, pablo, tito };

            Encounter encuentro1 = new Encounter(heroes, enemies);
            Console.WriteLine("Empieza el encuentro..."); 
            encuentro1.DoEncounter();

            
        }
    }
}
