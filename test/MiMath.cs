using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace MidasMain
{
    public static class MiMath
    {
        public static int PointOnWhichSideOfLineSegment(Point linePoint1, Point linePoint2, Point point)
        {

            Point lineVec = PointUtil.Minus(linePoint2, linePoint1);
            Point pointVec = PointUtil.Minus( point , linePoint1);

            float dot = PointUtil.Dot(pointVec, lineVec);

            //point is on side of linePoint2, compared to linePoint1
            if (dot > 0)
            {

                //point is on the line segment
                if (PointUtil.Magnitude( pointVec) <= PointUtil.Magnitude(  lineVec))
                {
                    return 0;
                }

                //point is not on the line segment and it is on the side of linePoint2
                else
                {

                    return 2;
                }
            }

            //Point is not on side of linePoint2, compared to linePoint1.
            //Point is not on the line segment and it is on the side of linePoint1.
            else
            {

                return 1;
            }
        }
        public static Point ProjectPointOnLine(Point linePoint, Point lineVec, Point point)
        {
            //get vector from point on line to point in space
            Point linePointToPoint = PointUtil.Minus( point , linePoint);

            int t = PointUtil.Dot(linePointToPoint, lineVec);

            return PointUtil.Plus(linePoint, new Point(lineVec.X * t, lineVec.Y * t));
        }
        public static Point ProjectPointOnLineSegment(Point linePoint1, Point linePoint2, Point point)
        {
            Point vector = PointUtil.Minus(linePoint2, linePoint1);

            Point projectedPoint = ProjectPointOnLine(linePoint1, PointUtil.Normalize( vector ), point);

            int side = PointOnWhichSideOfLineSegment(linePoint1, linePoint2, projectedPoint);

            //The projected point is on the line segment
            if (side == 0)
            {

                return projectedPoint;
            }

            if (side == 1)
            {

                return linePoint1;
            }

            if (side == 2)
            {

                return linePoint2;
            }

            //output is invalid
            return Point.Empty;
        }
    }
}