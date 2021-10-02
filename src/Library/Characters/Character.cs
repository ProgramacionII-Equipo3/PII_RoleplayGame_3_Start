using System.Collections.Generic;
using System.Linq;

namespace RoleplayGame
{
    public abstract class Character
    {
        public readonly string Name;

        public Character(string name)
        {
            this.Name = name;
        }

        private int health = 100;
        public int Health {
                    get => health;
            private set => health = value < 0 ? 0 : value;
        }

        public bool IsAlive => health > 0;

        public virtual int AttackValue { get => this.items.Aggregate(0, (total, el) => total + el.AttackValue); }

        public virtual int DefenseValue { get => this.items.Aggregate(0, (total, el) => total + el.DefenseValue); }

        private List<NonMagicalItem> items = new List<NonMagicalItem>();

        public void AddItem(NonMagicalItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(NonMagicalItem item)
        {
            this.items.Remove(item);
        }

        public void Cure()
        {
            this.Health = 100;
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }
    }
}