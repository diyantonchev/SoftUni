using System;

  public class Point3D
    {
        private static readonly Point3D startingPoint = new Point3D(0, 0, 0) ;

        private double coordinateX;
        private double coordinateY;
        private double coordinateZ;

        public Point3D(double coordinateX, double coordinateY, double coordinateZ)
        {
            this.CoordinateX = coordinateX;
            this.CoordinateY = coordinateY;
            this.CoordinateZ = coordinateZ;
        }

        public double CoordinateZ
        {
            get { return this.coordinateZ ;}
            set { this.coordinateZ = value;} 
        }

        public double CoordinateY
        {
            get { return this.coordinateY; }
            set { this.coordinateY = value;} 
        }

        public double CoordinateX 
        {
            get { return this.coordinateX; }
            set { this.coordinateX = value;} 
        }

       static public Point3D StartingPoint 
        {
            get { return startingPoint; }
        }

        public override string ToString()
        {
            string point3D = string.Format("Point({0}, {1}, {2})", this.CoordinateX, this.CoordinateY, this.CoordinateZ);
            return point3D;
        }
    }
