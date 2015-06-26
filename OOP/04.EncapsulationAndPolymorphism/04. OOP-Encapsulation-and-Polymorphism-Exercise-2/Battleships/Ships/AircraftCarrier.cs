namespace Battleships.Ships
{
    using System;

    public class AircraftCarrier : BattleShip
    {
        private int fighterCapacity;

        public AircraftCarrier(string name, double lengthInMeters, double volume, int fighterCapacity)
            : base(name, lengthInMeters, volume)
        {
            this.FighterCapacity = fighterCapacity;
        }

        public int FighterCapacity
        {
            get
            {
                return this.fighterCapacity;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The fighter capacity of an aircraft carrier cannot be negative.");
                }

                this.fighterCapacity = value;
            }
        }

        public override string Attack(Ship target)
        {
            this.DestroyShip(target);

            return "We bombed them fromthe sky!";
        }
    }
}
