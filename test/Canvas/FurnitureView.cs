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
        string ObjectName { get; set; }
        Point Coordinate { get; set; }
        int Width { get; set; }
        int Height { get; set; }
    }

    public partial class FurnitureView : DragItem , IFurnitureView
    {
        public FurnitureView()
        {
            InitializeComponent();
        }

        public Point Coordinate { get
            {
                return Location;
            }
            set {
                Location = value;
            }
        }

        public string ObjectName
        {
            get
            {
                return metroLabel1.Name;
            }
            set
            {
                metroLabel1.Name = value;
            }
        }

        int IFurnitureView.Width
        {
            get
            {
                return Size.Width;
            }
            set
            {
                Size = new Size(value, Size.Height);

            }
        }
        int IFurnitureView.Height { get {
                return Size.Height;
            } set {
                Size = new Size(Size.Width, value);

            }
        } 
    }
}
