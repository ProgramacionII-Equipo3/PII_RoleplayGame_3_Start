
namespace RoleplayGame
{
    public abstract class Hero: Character
    {
        public Hero(string name): base(name) {}

        private int _victoryPoints = 0;
        public int VictoryPoints {
            get => _victoryPoints;
            private set
            {
                if(_victoryPoints < value)
                {
                    _victoryPoints = value;
                    if(_victoryPoints >= 5)
                    {
                        Cure();
                        _victoryPoints %= 5;
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
                VictoryPoints += target.VictoryPoints;
                return true;
            }
            return false;
        }
    }
}