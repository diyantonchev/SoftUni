using Interfaces;

namespace Characters
{
    class Priest : Character , IHeal
    {
        public Priest() : base(200,125, 100)
        {

        }

        public override void Attack(Character target)
        {
            this.Mana -= 100;
            target.Health -= this.Damage;
            this.Health += this.Damage / 10;
        }

        public void Heal(Character target)
        {
            this.Mana -= 100;
            target.Health += 150;
        }
    }
}
