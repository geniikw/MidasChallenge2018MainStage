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
	public partial class UCObject : UCScaleAble
	{
		public UCRoom inRoom;

		public UCObject()
		{
			InitializeComponent();
			inRoom = null;
		}

		public override void PointerUp(object sender, MouseEventArgs e)
		{
			base.PointerUp(sender, e);
			Console.WriteLine("check object in room");
			Canvas.instance.SearchRommForObject(this);
		}
	}
}
