namespace RoleplayGame
{
    public abstract class Item
    {
        public virtual int AttackValue => 0;
        public virtual int DefenseValue => 0;
    }
}