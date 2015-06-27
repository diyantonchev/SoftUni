namespace ExerciseInClass.Country
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Country : IComparable<Country>, ICloneable
    {
        private double area;

        private string name;

        private long population;

        public Country(string name, long population, double area)
        {
            this.Name = name;
            this.Population = population;
            this.Area = area;
        }

        public Country(string name, long population, double area, params string[] cities)
            : this(name, population, area)
        {
            this.Cities = new HashSet<string>(cities);
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value", "Country name cannot be null, empty or white space.");
                }

                this.name = value;
            }
        }

        public long Population
        {
            get
            {
                return this.population;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Population cannot be negative.");
                }

                this.population = value;
            }
        }

        public double Area
        {
            get
            {
                return this.area;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The area cannot be negative");
                }

                this.area = value;
            }
        }

        public HashSet<string> Cities { get; private set; }

        public object Clone()
        {
            return new Country(this.Name, this.Population, this.Area, this.Cities.ToArray());
        }

        public int CompareTo(Country otherCountry)
        {
            if (Math.Abs(this.Area - otherCountry.Area) < 0.0001)
            {
                if (this.Population == otherCountry.Population)
                {
                    return string.Compare(this.Name, otherCountry.Name, StringComparison.InvariantCulture);
                }
                if (this.Area - otherCountry.Area > 0)
                {
                    return 1;
                }
                return -1;
            }
            if (this.Area - otherCountry.Area > 0)
            {
                return -1;
            }
            return 1;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Country country = obj as Country;

            if (country == null)
            {
                return false;
            }

            return (Equals(this.Name, country.Name));
        }

        public static bool operator ==(Country country1, Country country2)
        {
            return Equals(country1, country2);
        }

        public static bool operator !=(Country country1, Country country2)
        {
            return !Equals(country1, country2);
        }
    }
}