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

		public UCRoom()
		{
			InitializeComponent();
			objects = new List<UCObject>();
		}

        public void SetupRoom(Room data)
        {
            Location = data.Rect.Location;
            Size = data.Rect.Size;
            BackColor = data.color;
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
            BackColor = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
    }
}
