namespace Characters
{
    class Mage : Character 
    {        
        public Mage() :base(300, 100, 75)
        {

        }

        public override void Attack(Character target)
        {
            this.Mana -= 100;
            target.Health -= 2 * this.Damage;
        }
    }
}
