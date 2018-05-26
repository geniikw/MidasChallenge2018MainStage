using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidasMain
{
    public static class PointUtil
    {
        public static Point Plus(Point r, Point l)
        {
            return new Point(r.X + l.X, r.Y + l.Y);
        }
        public static Point Minus(Point r, Point l)
        {
            return new Point(r.X - l.X, r.Y - l.Y);
        }
        public static int Dot(Point r, Point l)
        {
            return (r.X * l.X + r.Y * l.Y);
        }
        public static int Magnitude(Point p)
        {
            return (int)Math.Sqrt( p.X * p.X + p.Y * p.Y);
        }

        public static Point Normalize(Point p)
        {
            var len = Magnitude(p);
            return new Point(p.X / len, p.Y / len);
        }
    }
}
