using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidasMain.BaseClass
{
    public class Room
    {
        int depth;
        Rectangle rect;
        List<Door> doors;
        public int Depth
        {
            get { return depth; }
            set { depth = value; }
        }
        public Rectangle Rect
        {
            get { return rect; }
            set { rect = value; }
        }
        public Room(int depth, Rectangle rect)
        {
            doors = new List<Door>();
            this.depth = depth;
            this.rect = rect;
        }

        
    }
}
