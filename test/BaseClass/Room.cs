using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidasMain.BaseClass
{
    class Room
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

        private List<Line> ConvertRectToLines()
        {
            Point lt = new Point(rect.Left, rect.Top);
            Point lb = new Point(rect.Left, rect.Bottom);
            Point rt = new Point(rect.Right, rect.Top);
            Point rb = new Point(rect.Right, rect.Bottom);

            List<Line> returnList = new List<Line>();

            returnList.Add(new Line(lt, rt));
            returnList.Add(new Line(lt, lb));
            returnList.Add(new Line(rt, rb));
            returnList.Add(new Line(lb, rb));

            return returnList;
        }



        
        
    }
}
