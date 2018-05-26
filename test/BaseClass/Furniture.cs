using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidasMain
{
    public class Furniture
    {
        Point coordinate;
        float width;
        float height;

        public Furniture(Point coordinate, float width, float height)
        {
            this.coordinate = coordinate;
            this.width = width;
            this.height = height;
        }
    }
}
