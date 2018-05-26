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
	public partial class UCObject : UCScaleAble
	{
		Point tempLoc;
        public int color;
        public int tileIdx = -1;

		public UCObject()
		{
			InitializeComponent();
		}

        public void SetupData(Furniture input)
        {
            Location = input.coordinate;
            Size = new Size(input.width, input.height);
            Name = input.name;
            color = input.Color;
            tileIdx = input.tileIdx;
            SetupRender();
        }

        public void SetupRender()
        {
            if (tileIdx < 0)
            {
                BackColor = Color.FromArgb(color);
                BackgroundImage = null;
            }
            else
            {
                BackColor = Color.White;

                switch (tileIdx)
                {
                    case 0:
                        BackgroundImage = Properties.Resources.rToilet;
                        break;
                    case 1:
                        BackgroundImage = Properties.Resources.rSofa;
                        break;
                    default:
                        break;
                }
            }
        }

		public override void PointerDown(object sender, MouseEventArgs e)
		{
			tempLoc = Location;
			base.PointerDown(sender, e);
		}

		public void PointerUpCalledByRoom(object sender, MouseEventArgs e)
		{
			base.PointerUp(sender, e);
		}

		public override void PointerUp(object sender, MouseEventArgs e)
		{
			if (Canvas.instance.IsInRoom(this.Location, this.Size))
			{
				base.PointerUp(sender, e);
				Canvas.instance.BindObjectToRoom();
			}
			else
			{
				base.PointerUp(sender, e);
				this.Location = tempLoc;
			}
		}

        private void tolietToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tileIdx = 0;
            SetupRender();
        }

        private void sofaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tileIdx = 1;
            SetupRender();
        }
       

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tileIdx = -1;
            color = Color.White.ToArgb();
            SetupRender();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tileIdx = -1;
            color = Color.Red.ToArgb();
            SetupRender();
        }
    }
}
