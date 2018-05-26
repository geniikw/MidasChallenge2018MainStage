using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidasMain
{
    public class Line
    {
        public Point pA;
        public Point pB;

        public Room from = null;
        public Room to = null;
        public Line(Point a, Point b, Room from, Room to)
        {
            pA = a;
            pB = b;
            this.from = from;
            this.to = to;
        }

        public Line()
        {
            pA = new Point();
            pB = new Point();
        }

        public bool IsPointAIncludedIn(Room room)
        {
            return room.Rect.Contains(pA);
        }
        public bool IsPointBIncludedIn(Room room)
        {
            return room.Rect.Contains(pB);
        }
        public Line(Point a, Point b)
        {
            pA = a;
            pB = b;
            
        }

        public void SetRooms(Room from, Room to)
        {
            this.from = from;
            this.to = to;
        }

        public Rectangle ToRect()
        {
            int left = pA.X > pB.X ? pB.X : pA.X;
            int top = pA.Y > pB.Y ? pB.Y : pA.Y;
            int width = Math.Abs(pA.X - pB.X);
            width = width == 0 ? 1 : width;
            int height = Math.Abs(pA.Y - pB.Y);
            height = height == 0 ? 1 : height;
            return new Rectangle(left, top, width, height);

        }
    }
}
