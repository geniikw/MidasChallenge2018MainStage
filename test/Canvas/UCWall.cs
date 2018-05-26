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

		private void makeDoor(int idx, bool isDoor)
		{
            GlobalEvent.OnDocumentChangeBefore(Canvas.instance.GetCurrent(), "add door");
            if (isVertical)
				loc.X = 2;
			else
				loc.Y = 2;

			Point newLoc = PointUtil.Plus(this.Location, loc);
			if (isVertical && newLoc.Y + 50 > this.Bottom)
				return;

			if (!isVertical && newLoc.X + 50 > this.Right)
				return;

			Door temp = new Door();
			temp.pA = newLoc;
			temp.kind = idx;
			temp.isDoor = isDoor;

			Canvas.instance.MakeDoor(temp);
            GlobalEvent.OnDocumentChangeAfter(Canvas.instance.GetCurrent(), "add door");


        }

        private void makeDoorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			makeDoor(3, true);
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

				makeWindowLeftToolStripMenuItem.Visible = true;
				makeWindowRightToolStripMenuItem.Visible = true;
				makeWindowDownToolStripMenuItem.Visible = false;
				makeWindowUpToolStripMenuItem.Visible = false;
			}
			else
			{
				makeDoorToolStripMenuItem.Visible = true;
				makeDoorUpToolStripMenuItem.Visible = true;
				makeDoorLeftToolStripMenuItem.Visible = false;
				makeDoorRightToolStripMenuItem.Visible = false;

				makeWindowDownToolStripMenuItem.Visible = true;
				makeWindowUpToolStripMenuItem.Visible = true;
				makeWindowLeftToolStripMenuItem.Visible = false;
				makeWindowRightToolStripMenuItem.Visible = false;
			}
		}

		private void makeDoorUpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			makeDoor(1, true);
		}

		private void makeDoorLeftToolStripMenuItem_Click(object sender, EventArgs e)
		{
			makeDoor(2, true);
		}

		private void makeDoorRightToolStripMenuItem_Click(object sender, EventArgs e)
		{
			makeDoor(0, true);
		}

		private void makeWindowRightToolStripMenuItem_Click(object sender, EventArgs e)
		{
			makeDoor(0, false);
		}

		private void makeWindowLeftToolStripMenuItem_Click(object sender, EventArgs e)
		{
			makeDoor(2, false);
		}

		private void makeWindowUpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			makeDoor(1, false);
		}

		private void makeWindowDownToolStripMenuItem_Click(object sender, EventArgs e)
		{
			makeDoor(3, false);
		}
	}
}
