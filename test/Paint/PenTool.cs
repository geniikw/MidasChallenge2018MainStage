using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zenject;

namespace MidasMain.Paint
{
    public class PenTool : ITool
    {
        [Inject]
        PaintModel _model;

        Pen m_pen = new Pen(Color.Black, 1);

        Point prv;
        public Cursor Cursor()
        {
            return Cursors.Cross;
        }

        public void OnDown(object sender, MouseEventArgs arg)
        {
            prv = arg.Location;
        }

        public void OnMove(object sender, MouseEventArgs arg)
        {
            _model.graphics.DrawLine(m_pen, prv, arg.Location);
            prv = arg.Location;
        }

        public void OnUp(object sender, MouseEventArgs arg)
        {
            _model.graphics.DrawLine(m_pen, prv, arg.Location);
        }
    }
}
