using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace css_souradnice
{
    public class Coord : IEquatable<Coord>, IComparable<Coord>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coord(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double Size
        {
            get { return Math.Sqrt(X * X + Y * Y); }
        }

        public double Magnitude
        {
            get { return X * X + Y * Y; }
        }

        public override bool Equals(object obj)
        {
            if (obj is Coord other)
            {
                return this.X == other.X && this.Y == other.Y;
            }
            return false;
        }

        public bool Equals(Coord other)
        {
            if (other == null) return false;
            return this.X == other.X && this.Y == other.Y;
        }

        public static bool operator ==(Coord c1, Coord c2)
        {
            if (ReferenceEquals(c1, null) && ReferenceEquals(c2, null)) return true;
            if (ReferenceEquals(c1, null) || ReferenceEquals(c2, null)) return false;
            return c1.Equals(c2);
        }

        public static bool operator !=(Coord c1, Coord c2)
        {
            return !(c1 == c2);
        }

        public static bool operator <(Coord c1, Coord c2)
        {
            return c1.Magnitude < c2.Magnitude;
        }

        public static bool operator >(Coord c1, Coord c2)
        {
            return c1.Magnitude > c2.Magnitude;
        }

        public int CompareTo(Coord other)
        {
            if (other == null) return 1;
            return this.Magnitude.CompareTo(other.Magnitude);
        }

        public static Coord operator +(Coord c1, Coord c2)
        {
            return new Coord(c1.X + c2.X, c1.Y + c2.Y);
        }

        public static Coord operator *(Coord c, int scalar)
        {
            return new Coord(c.X * scalar, c.Y * scalar);
        }

        public static Coord operator *(int scalar, Coord c)
        {
            return new Coord(c.X * scalar, c.Y * scalar);
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }
    }
}
