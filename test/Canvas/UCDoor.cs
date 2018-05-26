using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidasMain.CanvasSpace
{
	public partial class UCDoor : UserControl
	{
		public Point pA, pB;
		public int kind;
		public bool isDoor;
		public Point startPoint, startLoc;

		public UCDoor()
		{

			SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			this.BackColor = Color.Transparent;
			InitializeComponent(); 
		}

        public void Setup(Door d)
        {
            pA = d.pA;
			kind = d.kind;
			isDoor = d.isDoor;
			if (kind % 2 == 0)
				pB = PointUtil.Plus(pA, new Point(0, 50));
			else
				pB = PointUtil.Plus(pA, new Point(50, 0));
		}

		public void DragStart()
		{
			startPoint = pA;
			startLoc = Location;
		}

		public void Dragging(Point dP)
		{
			pA = PointUtil.Plus(startPoint, dP);
			Location = PointUtil.Plus(startLoc, dP);
		}
	}
}
