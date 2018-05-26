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
	public partial class UCWall : UserControl
	{
		public Point loc;
		public bool isVertical;

		public UCWall()
		{
			InitializeComponent();
		}

		private void makeDoor(int idx)
		{
			Point newLoc = PointUtil.Plus(this.Location, loc);
			if (isVertical && newLoc.Y + 50 > this.Bottom)
				return;

			if (!isVertical && newLoc.X + 50 > this.Right)
				return;

			Door temp = new Door();
			temp.pA = newLoc;
			temp.idx = idx;

			Canvas.instance.MakeDoor(temp);
			
		}

		private void makeDoorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			makeDoor(3);
		}

		private void UCWall_MouseDown(object sender, MouseEventArgs e)
		{
			Console.WriteLine("click!" + e.Location);
			loc = e.Location;
			if(isVertical)
			{
				makeDoorLeftToolStripMenuItem.Visible = true;
				makeDoorRightToolStripMenuItem.Visible = true;
				makeDoorToolStripMenuItem.Visible = false;
				makeDoorUpToolStripMenuItem.Visible = false;
			}
			else
			{
				makeDoorToolStripMenuItem.Visible = true;
				makeDoorUpToolStripMenuItem.Visible = true;
				makeDoorLeftToolStripMenuItem.Visible = false;
				makeDoorRightToolStripMenuItem.Visible = false;
			}
		}

		private void makeDoorUpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			makeDoor(1);
		}

		private void makeDoorLeftToolStripMenuItem_Click(object sender, EventArgs e)
		{
			makeDoor(2);
		}

		private void makeDoorRightToolStripMenuItem_Click(object sender, EventArgs e)
		{
			makeDoor(0);
		}
	}
}
