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
	}
}
