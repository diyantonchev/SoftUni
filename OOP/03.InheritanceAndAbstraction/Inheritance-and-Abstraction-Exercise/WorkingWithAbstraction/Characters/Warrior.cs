using Interfaces;

namespace Characters
{
    class Warrior : Character
    {
        public Warrior()
            : base(0, 300, 120)
        {

        }

        public override void Attack(Character target)
        {
            target.Health -= this.Damage;
        }
    }
}
