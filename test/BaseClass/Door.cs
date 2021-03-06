﻿using MidasMain.CanvasSpace;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidasMain
{
    public class Door
    {
        public Point pA;
        public Point pB;
		public int kind;
		public bool isDoor;

        public enum DoorType
        {
            Door,
            Window,
        };

        DoorType type;
        public DoorType Type
        {
            get { return type; }
            set { type = value; }
        }
        public Door()
        {
            pA = new Point();
            pB = new Point();
        }

        public Door(Point a, int idx, bool _isDoor)
        {
            pA = a;
			kind = idx;
			if (kind % 2 == 0)
				pB = PointUtil.Plus(pA, new Point(0, 50));
			else
				pB = PointUtil.Plus(pA, new Point(50, 0));
			isDoor = _isDoor;
		}

        public Door(DoorType type, float posRatio)
        {
            this.type = type;
        }
    }
}
