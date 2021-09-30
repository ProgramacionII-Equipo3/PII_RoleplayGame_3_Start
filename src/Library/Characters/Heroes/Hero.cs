
namespace RoleplayGame
{
    public abstract class Hero: Character
    {
        public Hero(string name): base(name) {}

        private int victoryPoints = 0;

        public int VictoryPoints {
            get => victoryPoints;
            private set
            {
                if(victoryPoints < value)
                {
                    victoryPoints = value;
                }
            }
        }

        // Returns whether the enemy was defeated
        public bool Attack(Enemy target)
        {
            target.ReceiveAttack(this.AttackValue);
            if(target.Health == 0)
            {
                victoryPoints += target.VictoryPoints;
                return true;
            }
            return false;
        }
    }
}