using System;
using Interfaces;

namespace Characters
{
    abstract class Character : IAttack
    {
        private int mana;
        private int health;
        private int damage;

        protected Character(int mana, int health, int damage)
        {
            this.Health = health;
            this.Damage = damage;
            this.Mana = mana;
        }

        public int Mana { get; set; }

        public int Health { get; set; }

        public int Damage { get; set; }

        public abstract void Attack(Character target);
    }
}
