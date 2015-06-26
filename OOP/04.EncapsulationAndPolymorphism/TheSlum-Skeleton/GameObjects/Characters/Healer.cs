using System.Collections.Generic;
using TheSlum.Interfaces;
using System.Linq;

namespace TheSlum
{
    public class Healer : Character, IHeal
    {
        private int healingPoints;

        public Healer(string id, int x, int y, int healthPoints, int defensePoints, int healingPoints, Team team, int range)
            :base (id,x, y,healthPoints,defensePoints,team,range)
        {
            this.HealingPoints = healingPoints;
        }

        public int HealingPoints
        {
            get { return this.healingPoints; }

            set
            {
                this.healingPoints = value;
            }
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var targetCharacter = targetsList.LastOrDefault(target => target.Team == this.Team && target.IsAlive);

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
            return base.ToString() + string.Format(", Attack: {0}", this.HealingPoints);
        }
        
    }
}
