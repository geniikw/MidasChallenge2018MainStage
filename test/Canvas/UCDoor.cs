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

		public UCDoor()
		{

			SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			this.BackColor = Color.Transparent;
			InitializeComponent(); 
		}

        public void Setup(Door d)
        {
            pA = d.pA;
            pB = d.pB;
            //Location = new Point((pA.X+pB.X)/2, pA.Y + pB.
        }
	}
}
