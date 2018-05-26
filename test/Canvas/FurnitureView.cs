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
    public interface IFurnitureView
    {
        Furniture Data { get; set; }
    }

    public partial class FurnitureView : DragItem , IFurnitureView
    {
        public FurnitureView()
        {
            InitializeComponent();
        }

        public Furniture Data { get
            {
                return new Furniture(Location, Size.Width, Size.Height, metroLabel1.Text);
            }
            set
            {
                Location = value.coordinate;
                Size = new Size(value.width, value.height);
                metroLabel1.Text = value.name;
            }
        }
    } 
}
