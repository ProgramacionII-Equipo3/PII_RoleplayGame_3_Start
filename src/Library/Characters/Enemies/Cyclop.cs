namespace RoleplayGame
{
    public class Cyclop: Enemy
    {
        public override int VictoryPoints {get; }
        
        public Cyclop(string name) : base(name)
        {
            this.AddItem(new Shield());
            this.AddItem(new Axe());
            this.VictoryPoints=1;
        }

    }

}