using System;
using System.Collections.Generic;
using System.Text;

namespace LinePlaneIntersect
{
    public class Point
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }

        public Point(float X, float Y, float Z)
        {
            x = X;
            y = Y;
            z = Z;
        }

        public static Point CrossProduct(Point v1, Point v2)
        {
            float x, y, z;
            x = v1.y * v2.z - v2.y * v1.z;
            //y = (v1.x * v2.z - v2.x * v1.z) * -1;
            y = v1.z * v2.x - v1.x * v2.z;
            z = v1.x * v2.y - v2.x * v1.y;

            return new Point(x, y, z);
        }

        public static Point operator +(Point a, Point b)
        {
            return new Point(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        public static Point operator -(Point a, Point b)
        {
            return new Point(a.x - b.x, a.y - b.y, a.z - b.z);
        }

        public static Point operator -(Point a)
        {
            return new Point(-a.x, -a.y, -a.z);
        }

        public static Point operator *(Point a, float d)
        {
            return new Point(a.x * d, a.y * d, a.z * d);
        }

        public static Point operator *(float d, Point a)
        {
            return new Point(a.x * d, a.y * d, a.z * d);
        }

        public static bool operator ==(Point op1, Point op2)
        {
            return op1.x == op2.x && op1.y == op2.y && op1.z == op2.z;
        }

        public static bool operator !=(Point op1, Point op2)
        {
            return op1.x != op2.x && op1.y != op2.y && op1.z != op2.z;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
