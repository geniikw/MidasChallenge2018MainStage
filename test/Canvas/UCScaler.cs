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
	public enum Where { lefttop, leftbottom, righttop, rightbottom }

	public partial class UCScaler : DragItem
	{
		public UCRoom thisRoom;
		private Point mouse0, location0;
		private Size size0;
		private bool isClick = false;
		public Where where;

		public UCScaler()
		{
			InitializeComponent();
		}

		public override void PointerDown(object sender, MouseEventArgs e)
		{
			base.PointerDown(sender, e);
			Console.WriteLine("sender click");

			mouse0 = PointToScreen(e.Location);
			location0 = PointToScreen(thisRoom.Location);
			size0 = thisRoom.Size;
			isClick = true;
		}

		public override void PointerMove(object sender, MouseEventArgs e)
		{
			if (isClick)
			{
				//base.PointerMove(sender, e);
				Point dPoint = PointUtil.Minus(PointToScreen(e.Location), mouse0);
				thisRoom.Size = new Size(PointUtil.Plus(new Point(size0), dPoint));
				//Console.WriteLine("delta : " + dPoint.X + ", " + dPoint.Y);
				//Console.WriteLine("room : " + thisRoom.Location.X + ", " + thisRoom.Location.Y);
				switch (where)
				{
					case Where.leftbottom:
						
						break;
					case Where.lefttop:
						base.PointerMove(sender, e);
						thisRoom.Size = new Size(PointUtil.Minus(new Point(size0), dPoint));
						break;
					case Where.rightbottom:
						break;
					case Where.righttop:
						break;
					default:
						break;
				}
			}
		}

		public override void PointerUp(object sender, MouseEventArgs e)
		{
			base.PointerUp(sender, e);

			isClick = false;
		}
	}
}
