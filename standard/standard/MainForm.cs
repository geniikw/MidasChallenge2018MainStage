using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace standard
{
	using MetroFramework.Controls;

	public partial class MainForm : MetroFramework.Forms.MetroForm
	{
		public MainForm()
		{
			InitializeComponent();
			InitTableLayout();
		}

		public void InitTableLayout()
		{
			PictureBox content = new PictureBox
			{
				Image = Image.FromFile(@"../../Resources/dekinai.png"),
				Dock = DockStyle.Fill,
				SizeMode = PictureBoxSizeMode.StretchImage
			};

			firstPageMainLayout.Controls.Add(content, 1, 0); //initial position
			firstPageMainLayout.SetRowSpan(content, 3);
		}
	}
}
