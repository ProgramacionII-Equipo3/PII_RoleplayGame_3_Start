using System.Collections.Generic;
using System.Linq;

namespace RoleplayGame
{
    public class SpellsBook: MagicalItem
    {
        private List<Spell> spells = new List<Spell>();
        
        public override int AttackValue => this.spells.Aggregate(0, (total, el) => total + el.AttackValue);

        public override int DefenseValue => this.spells.Aggregate(0, (total, el) => total + el.DefenseValue);

        public void AddSpell(Spell spell)
        {
            this.spells.Add(spell);
        }

        public void RemoveSpell(Spell spell)
        {
            this.spells.Remove(spell);
        }
    }
}