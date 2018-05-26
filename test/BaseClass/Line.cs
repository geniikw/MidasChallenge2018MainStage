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
        public Point x;
        public Point y;

        public Room from = null;
        public Room to = null;
        public Line(Point x, Point y, Room from, Room to)
        {
            this.x = x;
            this.y = y;
            this.from = from;
            this.to = to;
        }

        public Line(Point x, Point y)
        {
            this.x = x;
            this.y = y;
            
        }

        public void SetRooms(Room from, Room to)
        {
            this.from = from;
            this.to = to;
        }
    }
}
