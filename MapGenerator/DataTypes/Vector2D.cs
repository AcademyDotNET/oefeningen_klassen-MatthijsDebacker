using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapGenerator.DataTypes
{
    class Vector2D : Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector2D(double x = 1.0, double y = 1.0)
        {
            X = x;
            Y = y;
        }


        public override void Normalize()
        {
            double length = GetLength();
            X /= length;
            Y /= length;
        }

        public override double GetLength()
        {
            return Math.Sqrt(Math.Pow(X, 2.0) + Math.Pow(Y, 2.0));
        }

        public override void Flip()
        {
            X = -X;
            Y = -Y;
        }

        // OPERATORS
        // =========

        public static Vector2D operator +(Vector2D vector, double value)
        {
            return new Vector2D(vector.X + value, vector.Y + value);
        }
        
        public static Vector2D operator -(Vector2D vector, double value)
        {
            return new Vector2D(vector.X - value, vector.Y - value);
        }

        public static Vector2D operator +(Vector2D vector1, Vector2D vector2)
        {
            return new Vector2D(vector1.X + vector2.X, vector1.Y + vector2.Y);
        }

        public static Vector2D operator -(Vector2D vector1, Vector2D vector2)
        {
            return new Vector2D(vector1.X - vector2.X, vector1.Y - vector2.Y);
        }

        public static Vector2D operator *(Vector2D vector, double value)
        {
            return new Vector2D(vector.X * value, vector.Y * value);
        }

        // STATIC METHODS
        // ==============

        public static double Dot(Vector2D vector1, Vector2D vector2)
        {
            return (vector1.X * vector2.X) + (vector1.Y * vector2.Y);
        }

        public static double Cross(Vector2D vector1, Vector2D vector2)
        {
            return (vector1.X * vector2.Y) - (vector1.Y * vector2.X);
        }
    }
}
