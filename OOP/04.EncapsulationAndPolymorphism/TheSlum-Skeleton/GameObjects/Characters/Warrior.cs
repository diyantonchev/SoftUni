using System.Collections.Generic;
using TheSlum.Interfaces;
using System.Linq;

namespace TheSlum
{
  public class Warrior : Character, IAttack
    {
        private int attackPoints;

        public Warrior(string id, int x, int y, int healthPoints,int attackPoints, int defensePoints, Team team, int range)
            :base (id,x,y,healthPoints,defensePoints,team,range)
        {
            this.AttackPoints = attackPoints;
        }

        public int AttackPoints
        {
            get { return this.attackPoints; }

            set
            {
                this.attackPoints = value;
            }
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var targetCharacter = targetsList.FirstOrDefault(target => target.Team != this.Team && target.IsAlive);

            return targetCharacter;
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.RemoveItemEffects(item);
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Attack: {0}", this.AttackPoints);
        }

        protected override void ApplyItemEffects(Item item)
        {
            base.ApplyItemEffects(item);
            this.attackPoints += item.AttackEffect;
        }

        protected override void RemoveItemEffects(Item item)
        {
            base.ApplyItemEffects(item);
            this.attackPoints -= item.AttackEffect;
        }
    }
}
