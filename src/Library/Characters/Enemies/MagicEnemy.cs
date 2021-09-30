using System.Collections.Generic;

namespace RoleplayGame
{
    public abstract class MagicEnemy: Enemy, IMagicCharacter
    {
        List<MagicalItem> IMagicCharacter.magicalItems { get; } = new List<MagicalItem>();
        public override int AttackValue => base.AttackValue + (this as IMagicCharacter).AdditionalAttackValue;
        public override int DefenseValue => base.AttackValue + (this as IMagicCharacter).AdditionalDefenseValue;

        public MagicEnemy(string name): base(name) {}
    }
}