namespace RoleplayGame
{
    public class Golem: Enemy
    {
        public override int VictoryPoints { get; }

        public Golem(string name) : base(name)
        {
            this.AddItem(new Axe());
            this.AddItem(new Armor());
            this.VictoryPoints = 1;
        }
    }
}