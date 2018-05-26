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
    }
}
