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
		}

        public void SetupRoom(Room room)
        {
            Size = room.Rect.Size;
            Location = room.Rect.Location;
        }

        private void UCRoom_Load(object sender, EventArgs e)
        {

        }
    }
}
