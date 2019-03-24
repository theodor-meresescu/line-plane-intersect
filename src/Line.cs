using System;
using System.Collections.Generic;
using System.Text;

namespace LinePlaneIntersect
{
    public class Line
    {
        Point _direction;
        Point _base;

        public Line(Point basePoint, Point direction)
        {
            _direction = direction;
            _base = basePoint;
        }

        public Point getParametricLine()
        {
            return new Point(
                _direction.x - _base.x,
                _direction.y - _base.y,
                _direction.z - _base.z
                );
        }

        public Point getBasePoint()
        {
            return _base;
        }
    }
}
