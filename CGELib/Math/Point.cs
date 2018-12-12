
using System;

namespace CGELib
{
    /// <summary> A Vector containing two ints. </summary>
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public const float Rad2Deg = 180f / (float)Math.PI;
        public const float Deg2Rad = (float)Math.PI / 180f;

        /// <summary> new Point(0, 0); </summary>
        public static Point Zero { get; private set; } = new Point(0, 0);

        public Point(): this(0, 0)
        {
        }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public Vector ToVector() => new Vector((float)X, (float)Y);
        public override string ToString() => String.Format("({0}, {1})", X, Y);

        public static Point operator +(Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }

        public static Point operator -(Point a, Point b)
        {
            return new Point(a.X - b.X, a.Y - b.Y);
        }

        public static Point operator /(Point a, float b)
        {
            return new Point((int)(a.X / b), (int)(a.Y / b));
        }

        public static Point operator *(Point a, float b)
        {
            return new Point((int)(a.X * b), (int)(a.Y * b));
        }

        /// <summary> Calculates distance between two points. </summary>
        /// <param name="a">Point A</param>
        /// <param name="b">Point B</param>
        /// <returns>Distance between A and B</returns>
        public static float Distance(Point a, Point b)
        {
            Point dV = b - a;
            float d = (float)Math.Sqrt(Math.Pow(dV.X, 2) + Math.Pow(dV.Y, 2));
            return d;
        }

        public Point RotateDeg(double deg, Point pivot = null)
        {
            return Rotate(deg* Deg2Rad, pivot);
        }

        public Point Rotate(double rad, Point pivot=null)
        {
            Vector n = Vector.Zero;

            int x = X - pivot?.X??0;
            int y = Y - pivot?.Y??0;

            n.X = (float)(x * Math.Cos(rad / 57.3f) - y * Math.Sin(rad / 57.3f));
            n.Y = (float)(x * Math.Sin(rad / 57.3f) + y * Math.Cos(rad / 57.3f));

            X = (int)n.X + pivot?.X??0;
            Y = (int)n.Y + pivot?.Y??0;

            return this;
        }

        public Point Clamp(Point min, Point max)
        {
            X = (X > max.X) ? max.X : X;
            X = (X < min.X) ? min.X : X;

            Y = (Y > max.Y) ? max.Y : Y;
            Y = (Y < min.Y) ? min.Y : Y;

            return this;
        }
    }
}
