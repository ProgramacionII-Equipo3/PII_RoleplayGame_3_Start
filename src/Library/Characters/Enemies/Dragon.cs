namespace RoleplayGame
{
    public class Dragon: Enemy
    {
        public Dragon(string name): base(name) {}

        public override int VictoryPoints => 10;

        public override int AttackValue => base.AttackValue + 100;
        public override int DefenseValue => base.DefenseValue + 100;
    }
}