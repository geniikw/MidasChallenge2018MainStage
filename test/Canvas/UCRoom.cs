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
	public partial class UCRoom : UCScaleAble
	{
		public List<UCObject> objects;
		public int tileIdx = -1;

		public UCRoom()
		{
			InitializeComponent();
			objects = new List<UCObject>();
		}

        public void SetupRoom(Room data)
        {
            Location = data.Rect.Location;
            Size = data.Rect.Size;
            BackColor = Color.FromArgb(data.ColorValue);
			this.tileIdx = data.tileIdx;
			if (tileIdx != -1)
			{
				switch(tileIdx)
				{
					case 0:
						BackgroundImage = Properties.Resources.rTile0;
						break;
					case 1:
						BackgroundImage = Properties.Resources.rTile1;
						break;
					case 2:
						BackgroundImage = Properties.Resources.rTile2;
						break;
					case 3:
						BackgroundImage = Properties.Resources.rTile3;
						break;
					default:
						break;
				}
			}
		}

		public override void PointerDown(object sender, MouseEventArgs e)
		{
			foreach (UCObject obj in objects)
				obj.PointerDown(sender, e);
			base.PointerDown(sender, e);

			Console.WriteLine("Room click!");
		}

		public override void PointerMove(object sender, MouseEventArgs e)
		{
			base.PointerMove(sender, e);
			foreach (UCObject obj in objects)
				obj.PointerMove(sender, e);
		}

		public override void PointerUp(object sender, MouseEventArgs e)
		{
			base.PointerUp(sender, e);
			for (int i = 0; i < objects.Count; i++)
				objects[i].PointerUpCalledByRoom(sender, e);

			Canvas.instance.BindObjectToRoom();
			Console.WriteLine("loc is " + this.Location);
		}

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
			tileIdx = -1;
			BackColor = Color.Red;
			BackgroundImage = null;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
			tileIdx = -1;
			BackColor = Color.Blue;
			BackgroundImage = null;
		}

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
			tileIdx = -1;
			BackColor = Color.Green;
			BackgroundImage = null;
		}

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
			tileIdx = -1;
			BackColor = Color.White;
			BackgroundImage = null;
		}

		private void tile0ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tileIdx = 0;
			BackgroundImage = Properties.Resources.rTile0;
		}

		private void tile1ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tileIdx = 1;
			BackgroundImage = Properties.Resources.rTile1;
		}

		private void tile2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tileIdx = 2;
			BackgroundImage = Properties.Resources.rTile2;
		}

		private void tile3ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tileIdx = 3;
			BackgroundImage = Properties.Resources.rTile3;
		}
	}
}
