using System;
using System.Collections.Generic;
using System.Text;

namespace LinePlaneIntersect
{
    class Plane
    {
        float _alpha { get; set; }
        float _beta { get; set; }
        float _gamma { get; set; }
        float _delta { get; set; }

        public Plane(Point A, Point B, Point C)
        {
            _alpha = (B.y - A.y) * (C.z - A.z) - (C.y - A.y) * (B.z - A.z);
            _beta = (B.z - A.z) * (C.x - A.x) - (C.z - A.z) * (B.x - A.x);
            _gamma = (B.x - A.x) * (C.y - A.y) - (C.x - A.x) * (B.y - A.y);
            _delta = (-1 * (_alpha * A.x) + (_beta * A.y) + (_gamma * A.z));
        }

        public Point CalculateIntersection(Line line)
        {
            Point p1 = line.getParametricLine();
            Point p2 = line.getBasePoint();

            float Nv = _alpha * p1.x + _beta * p1.y + _gamma * p1.z;
            float Nr = _alpha * p2.x + _beta * p2.y + _gamma * p2.z;

            if (Nv != 0) //line has intersection with plane
            {
                float t = (_delta - Nr) / Nv; //if t > 0 then line is pointing towards plane
                float intersectX = p2.x + p1.x * t;
                float intersectY = p2.y + p1.y * t;
                float intersectZ = p2.z + p1.z * t;

                return new Point(intersectX, intersectY, intersectZ);
            }

            else // line is parallel to plane
            {
                if(Nr == _delta)
                {
                    //line is on plane
                    throw new Exception("Line is on plane");
                }
                throw new Exception("Line is parallel to plane");
            }
        }
    }
}
