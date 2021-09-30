using System.Collections.Generic;
using System.Linq;


namespace RoleplayGame
{
    public abstract class MagicCharacter: Character
    {
        public MagicCharacter(string name): base(name) {}

        private List<MagicalItem> magicalItems = new List<MagicalItem>();

        public void AddMagicalItem(MagicalItem item)
        {
            this.magicalItems.Add(item);
        }

        public void RemoveMagicalItem(MagicalItem item)
        {
            this.magicalItems.Remove(item);
        }

        public override int AttackValue => base.AttackValue + this.magicalItems.Aggregate(0, (total, el) => total + el.AttackValue);

        public override int DefenseValue => base.DefenseValue + this.magicalItems.Aggregate(0, (total, el) => total + el.DefenseValue);
    }
}
