
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
                    if(victoryPoints >= 5)
                    {
                        Cure();
                        victoryPoints %= 5;
                    }
                }
            }
        }

        // Returns whether the enemy was defeated
        public bool Attack(Enemy target)
        {
            if(!this.IsAlive) return false;

            target.ReceiveAttack(this.AttackValue);
            if(!target.IsAlive)
            {
                victoryPoints += target.VictoryPoints;
                return true;
            }
            return false;
        }
    }
}