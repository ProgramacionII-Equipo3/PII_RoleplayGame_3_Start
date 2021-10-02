using System.Collections.Generic;
using System.Linq;


namespace RoleplayGame
{
    public interface IMagicCharacter
    {
        protected List<MagicalItem> magicalItems { get; }

        public void AddItem(MagicalItem item)
        {
            this.magicalItems.Add(item);
        }

        public void RemoveItem(MagicalItem item)
        {
            this.magicalItems.Remove(item);
        }

        public int AdditionalAttackValue => this.magicalItems.Aggregate(0, (total, el) => total + el.AttackValue);

        public int AdditionalDefenseValue => this.magicalItems.Aggregate(0, (total, el) => total + el.DefenseValue);
    }
}
