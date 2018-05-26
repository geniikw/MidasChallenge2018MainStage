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
        public Door(DoorType type, float posRatio)
        {
            this.type = type;
        }
    }
}
