using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidasMain.Paint
{
    public class PaintInitializer : IInitializable
    {
        readonly PaintModel _model;
        readonly PictureBox _box;

        public PaintInitializer(PaintModel model, PictureBox box)
        {
            _model = model;
            _box = box;
        }

        public void Start()
        {
            _box.Image = new Bitmap(_box.Size.Width, _box.Size.Height);
            _model.graphics = Graphics.FromImage(_box.Image);
        }
    }
}
