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
	public partial class UCScaleAble : DragItem
	{
		public bool isSelected = false;

		public UCScaleAble()
		{
			InitializeComponent();
			InitScalers();
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
            GlobalEvent.OnDocumentChangeBefore?.Invoke(Canvas.instance.GetCurrent(), "SizeChange name");

            base.PointerDown(sender, e);
			Canvas.instance.AllFocusOut();
			FocusIn();
		}

		public override void PointerMove(object sender, MouseEventArgs e)
		{
			base.PointerMove(sender, e);
		}

		public override void PointerUp(object sender, MouseEventArgs e)
		{
            GlobalEvent.OnDocumentChangeAfter?.Invoke("SizeChange name");

            base.PointerUp(sender, e);
		}

		public void InitScalers()
		{
			scalerLeftTop.thisRoom = this;
			scalerLeftTop.where = Where.lefttop;
			scalerLeftTop.Visible = false;

			scalerRightTop.thisRoom = this;
			scalerRightTop.where = Where.righttop;
			scalerRightTop.Visible = false;

			scalerLeftBottom.thisRoom = this;
			scalerLeftBottom.where = Where.leftbottom;
			scalerLeftBottom.Visible = false;

			scalerRightBottom.thisRoom = this;
			scalerRightBottom.where = Where.rightbottom;
			scalerRightBottom.Visible = false;
		}
        
		public void FocusIn()
		{
			isSelected = true;
			scalerLeftTop.Visible = true;
			scalerRightTop.Visible = true;
			scalerLeftBottom.Visible = true;
			scalerRightBottom.Visible = true;
		}

		public void FocusOut()
		{
			isSelected = false;
			scalerLeftTop.Visible = false;
			scalerRightTop.Visible = false;
			scalerLeftBottom.Visible = false;
			scalerRightBottom.Visible = false;
		}

		private void UCScaleAble_Load(object sender, EventArgs e)
		{
			UpdateScalerPosition();
		}
	}
}
