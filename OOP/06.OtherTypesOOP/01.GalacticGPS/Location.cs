namespace GalacticGPS
{
    using System;

    public struct Location
    {
        // Degrees
        private const double MaxLatitude = 90;
        private const double MinLatitude = -90;

        private const double MaxLongitude = 180;
        private const double MinLongitude = -180;

        private double latitude;
        private double longitude;
        private Planet planet;

        public Location(double latitude, double longitude, Planet planet)
            : this()
        {
            this.Longitude = longitude;
            this.Latitude = latitude;
            this.Planet = planet;
        }

        public double Latitude
        {
            get { return this.latitude; }

            set
            {
                if (value < MinLatitude || value > MaxLatitude)
                    throw new ArgumentOutOfRangeException("Invalid degrees");
                this.latitude = value;
            }
        }

        public double Longitude
        {
            get { return this.longitude; }

            set
            {
                if (value < MinLongitude || value > MaxLongitude)
                    throw new ArgumentOutOfRangeException("Invalid degrees");
                this.longitude = value;
            }
        }

        public Planet Planet
        {
            get { return this.planet; }

            set { this.planet = value; }
        }

        public override string ToString()
        {
           string location = string.Format("{0}, {1} - {2}",
               this.Latitude, this.Longitude, this.Planet);

           return location;
        }
    }
}
