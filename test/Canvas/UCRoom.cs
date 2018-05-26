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
	public partial class UCRoom : DragItem
	{
		public UCRoom()
		{
			InitializeComponent();
			InitScalers();
		}

		public override void PointerDown(object sender, MouseEventArgs e)
		{
			base.PointerDown(sender, e);
			Console.WriteLine("room click");
		}

		public override void PointerMove(object sender, MouseEventArgs e)
		{
			base.PointerMove(sender, e);
		}

		public override void PointerUp(object sender, MouseEventArgs e)
		{
			base.PointerUp(sender, e);
		}

		public void InitScalers()
		{
			scalerLeftTop.thisRoom = this;
			scalerLeftTop.where = Where.lefttop;

			scalerRightTop.thisRoom = this;
			scalerRightTop.where = Where.righttop;

			scalerLeftBottom.thisRoom = this;
			scalerLeftBottom.where = Where.leftbottom;

			scalerRightBottom.thisRoom = this;
			scalerRightBottom.where = Where.rightbottom;
		}
	}
}
