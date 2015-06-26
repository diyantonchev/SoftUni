using System;
using System.Collections.Generic;
using System.Text;

    class Paths3D
    {
        private readonly List<Point3D> points = new List<Point3D>();

        public Paths3D(List<Point3D> points)
        {
            this.Points.AddRange(points);
        }

        public List<Point3D> Points
        {
            get { return this.points; }
        }

        public override string ToString()
        {
            var path3D = new StringBuilder();
            for (int i = 0; i < points.Count; i++)
            {
                path3D.AppendLine(string.Format("{0} {1}", i + 1, this.Points[i]));
            }
            return path3D.ToString();
        }
    }
