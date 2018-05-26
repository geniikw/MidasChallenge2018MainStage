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
	public partial class UCScaleAble : DragItem
	{
		public bool isSelected = false;

		public UCScaleAble()
		{
			InitializeComponent();
			InitScalers();
			UpdateScalerPosition();
		}

		public void UpdateScalerPosition()
		{
			scalerLeftTop.Location = new Point(0, 0);
			scalerLeftBottom.Location = new Point(0, Size.Height - 12);
			scalerRightTop.Location = new Point(Size.Width - 12, 0);
			scalerRightBottom.Location = new Point(Size.Width - 12, Size.Height - 12);
		}

		public override void PointerDown(object sender, MouseEventArgs e)
		{
			base.PointerDown(sender, e);
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

		public void DoSelect(bool a)
		{
			isSelected = a;
			scalerLeftTop.Visible = a;
			scalerRightTop.Visible = a;
			scalerLeftBottom.Visible = a;
			scalerRightBottom.Visible = a;
		}
	}
}
