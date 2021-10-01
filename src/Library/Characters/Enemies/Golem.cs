namespace RoleplayGame
{
    public class Golem: Enemy
    {
        public override int VictoryPoints => 2;

        public Golem(string name) : base(name)
        {
            this.AddItem(new Axe());
            this.AddItem(new Armor());
        }
    }
}