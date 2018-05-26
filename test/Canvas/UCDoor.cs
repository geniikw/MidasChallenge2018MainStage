using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidasMain.Canvas
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
	}
}
