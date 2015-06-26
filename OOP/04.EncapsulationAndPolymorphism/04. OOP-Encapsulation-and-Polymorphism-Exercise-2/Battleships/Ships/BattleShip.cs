using System;
using Interfaces;

namespace Battleships.Ships 
{
   public abstract class BattleShip : Ship, IAttack
    {
        protected BattleShip(string name, double lengthInMeters, double volume) : base(name, lengthInMeters, volume)
        {

        }

        public abstract string Attack(Ship target);
      

        protected void DestroyShip(Ship targetShip)
        {
            targetShip.IsDestroyed = true;
        }
    }
}
