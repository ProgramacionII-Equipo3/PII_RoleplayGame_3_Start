
namespace RoleplayGame
{
    public abstract class Enemy: Character
    {
        public Enemy(string name): base(name) {}

        public abstract int VictoryPoints { get; }

        public bool Attack(Hero target)
        {
            if(!this.IsAlive) return false;

            target.ReceiveAttack(this.AttackValue);
            return !target.IsAlive;
        }
    }
}