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
	public partial class UCRoom : UCScaleAble
	{
		public List<UCObject> objects;

		public UCRoom()
		{
			InitializeComponent();
			objects = new List<UCObject>();
		}

		public override void PointerDown(object sender, MouseEventArgs e)
		{
			base.PointerDown(sender, e);
			foreach (UCObject obj in objects)
				obj.PointerDown(sender, e);
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
			foreach (UCObject obj in objects)
				obj.PointerUp(sender, e);
		}
	}
}
