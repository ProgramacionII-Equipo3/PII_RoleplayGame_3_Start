using System.Collections.Generic;

namespace RoleplayGame
{
    public abstract class MagicHero: Hero, IMagicCharacter
    {
        List<MagicalItem> IMagicCharacter.magicalItems { get; } = new List<MagicalItem>();
        public override int AttackValue => base.AttackValue + (this as IMagicCharacter).AdditionalAttackValue;
        public override int DefenseValue => base.AttackValue + (this as IMagicCharacter).AdditionalDefenseValue;

        public MagicHero(string name): base(name) {}
    }
}