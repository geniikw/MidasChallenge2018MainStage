﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidasMain
{
    public class Furniture
    {
        public string name;
        public Point coordinate;
        public int width;
        public int height;

        public int Color;
        public int tileIdx = -1;

        public Furniture(Point coordinate, int width, int height, string name, int Color, int tileIdx)
        {
            this.name = name;
            this.coordinate = coordinate;
            this.width = width;
            this.height = height;
            this.Color = Color;
            this.tileIdx = tileIdx;
        }

        public Furniture()
        {
            this.name = "";
            this.coordinate = Point.Empty;
            this.width = 0;
            this.height = 0;
        }
    }



    
}
