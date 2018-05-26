using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidasMain
{
    public static class RectUtil
    {
        public enum RECT_TYPE
        {
            POINT,
            LINE,
            RECT,
        };
        public static RECT_TYPE GetRectType(Rectangle rect)
        {

            if (rect.Width == 0 && rect.Height == 0)
            {
                return RECT_TYPE.POINT;
            }
            else if (rect.Width == 0 || rect.Height == 0)
            {
                return RECT_TYPE.LINE;
            }
            return RECT_TYPE.RECT;
        }
        public static bool ConvertToLine(Rectangle rect, out Line l)
        {
            if (GetRectType(rect) == RECT_TYPE.LINE)
            {

                l = new Line(new Point(rect.Left, rect.Top), new Point(rect.Right, rect.Bottom));
                return true;
            }
            l = null;
            return false;
        }
        public static bool ConvertToPoint(Rectangle rect, out Point p)
        {
            if (GetRectType(rect) == RECT_TYPE.POINT)
            {
                p = new Point(rect.Left, rect.Top);
                return true;
            }
            p = Point.Empty;
            return false;
        }

        public static Rectangle PointToRect(Point p)
        {
            return new Rectangle(p.X, p.Y, 0, 0);
        }

    }
}
