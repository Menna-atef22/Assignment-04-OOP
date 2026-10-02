using System;

namespace Assignment_04_OOP
{
    public class Point3D : IComparable<Point3D> ,ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        // Task 1: constructors with chaining (everything funnels into the full one)
        public Point3D() : this(0, 0, 0) { }
        public Point3D(int x) : this(x, 0, 0) { }
        public Point3D(int x, int y) : this(x, y, 0) { }
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Task 2: ToString -> "Point Coordinates: (10, 10, 10)"
        public override string ToString() {
            return $"Point Coordinates: ({X}, {Y}, {Z})"; 
        }

        // Task 5
        public int CompareTo(Point3D other)
        {
            if (other == null) return 1;
            if (X != other.X)
                return X.CompareTo(other.X);

            return Y.CompareTo(other.Y);
        }

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }
    }
}
