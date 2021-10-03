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

        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            this.items.Remove(item);
        }

        public void Cure()
        {
            this.Health = 100;
        }

        public void ReceiveAttack(int power)
        {
            int damage = power - this.DefenseValue;
            if (damage < 2)
            {
                damage = 2;
            }
            this.Health -= damage;
        }
    }
}