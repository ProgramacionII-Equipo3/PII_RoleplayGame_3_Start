namespace RoleplayGame
{
    public class Skeleton : Enemy
    {
        public override int VictoryPoints => 1;

        public Skeleton(string name) : base(name)
        {
            this.AddItem(new Sword());
            this.AddItem(new Helmet());
        }

    }
}