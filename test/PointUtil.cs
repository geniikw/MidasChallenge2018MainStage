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
    }
}
