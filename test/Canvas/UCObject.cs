﻿using System;
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
		public UCObject()
		{
			InitializeComponent();
		}

        public void SetupData(Furniture input)
        {
            Location = input.coordinate;
            Size = new Size(input.width, input.height);
            Name = input.name;
            
        }

		public void PointerUpCalledByRoom(object sender, MouseEventArgs e)
		{
			base.PointerUp(sender, e);
		}

		public override void PointerUp(object sender, MouseEventArgs e)
		{
			base.PointerUp(sender, e);
			Canvas.instance.BindObjectToRoom();
		}
	}
}