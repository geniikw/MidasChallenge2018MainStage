using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidasMain.BaseClass
{
    class Door
    {
        //range 0~1
        float posRatio;

        public float PositionRatio
        {
            get { return posRatio; }
            set { posRatio = value; }
        }
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
        public Door(DoorType type, float posRatio)
        {
            this.type = type;
            this.posRatio = posRatio;
        }
    }
}
