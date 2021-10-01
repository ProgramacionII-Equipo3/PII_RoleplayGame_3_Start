namespace RoleplayGame
{
    public class Skeleton : Enemy
    {
        public override int VictoryPoints { get; }

        public Skeleton(string name) : base(name)
        {
            this.VictoryPoints = 2;
            this.AddItem(new Sword());
            this.AddItem(new Helmet());
        }

    }
}