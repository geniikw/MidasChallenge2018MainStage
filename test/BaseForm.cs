using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidasMain
{
    public partial class BaseForm : MetroFramework.Forms.MetroForm
    {
        public Document current; 
        
        public BaseForm()
        {
            InitializeComponent();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            current = new Document();
            current.AddRoom(new Room(0, new Rectangle(new Point(100, 100), new Size(100, 100))));
            current.AddRoom(new Room(1, new Rectangle(new Point(200, 100), new Size(100, 100))));
            current.AddRoom(new Room(2, new Rectangle(new Point(100, 200), new Size(100, 100))));
            canvas1.SetupDocument(current);
        }
    }
}
