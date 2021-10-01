namespace RoleplayGame
{
    public class Cyclops: Enemy
    {
        public override int VictoryPoints => 3;
        
        public Cyclops(string name) : base(name)
        {
            this.AddItem(new Shield());
            this.AddItem(new Axe());
        }

    }

}