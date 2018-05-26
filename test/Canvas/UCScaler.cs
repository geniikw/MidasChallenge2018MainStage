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
	public enum Where { lefttop, leftbottom, righttop, rightbottom }

	public partial class UCScaler : DragItem
	{
		public UCScaleAble thisRoom;
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
			thisRoom.PointerDown(sender, e);
			Console.WriteLine("sender click");

			mouse0 = PointToScreen(e.Location);
			location0 = thisRoom.Location;
			size0 = thisRoom.Size;
			isClick = true;
		}

		public override void PointerMove(object sender, MouseEventArgs e)
		{
			if (isClick)
			{
				Point dPoint = PointUtil.Minus(PointToScreen(e.Location), mouse0);
				//Console.WriteLine("delta : " + dPoint.X + ", " + dPoint.Y);
				//Console.WriteLine("room : " + thisRoom.Location.X + ", " + thisRoom.Location.Y);
				switch (where)
				{
					case Where.leftbottom:
						thisRoom.Location = new Point(location0.X + dPoint.X, location0.Y);
						thisRoom.Size = new Size(size0.Width - dPoint.X, size0.Height + dPoint.Y);
						break;
					case Where.lefttop:
						thisRoom.Location = PointUtil.Plus(location0, dPoint);
						thisRoom.Size = new Size(PointUtil.Minus(new Point(size0), dPoint));
						break;
					case Where.rightbottom:
						thisRoom.Size = new Size(PointUtil.Plus(new Point(size0), dPoint));
						break;
					case Where.righttop:
						thisRoom.Location = new Point(location0.X, location0.Y + dPoint.Y);
						thisRoom.Size = new Size(size0.Width + dPoint.X, size0.Height - dPoint.Y);
						break;
					default:
						break;
				}
				thisRoom.UpdateScalerPosition();
			}
		}

		public override void PointerUp(object sender, MouseEventArgs e)
		{
			base.PointerUp(sender, e);
			thisRoom.PointerUp(sender, e);
			isClick = false;
			Canvas.instance.BindObjectToRoom();
		}
	}
}
