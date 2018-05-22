using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidasMain.Paint
{
    public class ToolSelector : IInitializable
    {
        readonly PaintModel _model;
        readonly PictureBox _box;

        bool m_isDown = false;

        public ToolSelector(PaintModel model, PictureBox box)
        {
            _model = model;
            _box = box;
        }

        void OnDown(object sender, MouseEventArgs arg)
        {
            _model.CurrentTool?.OnDown(sender, arg);
            m_isDown = true;
        }

        void OnMove(object sender, MouseEventArgs arg)
        {
            if (!m_isDown)
                return;
            _model.CurrentTool?.OnMove(sender, arg);
            _box.Invalidate();
        }

        void OnUp(object sender, MouseEventArgs arg)
        {
            if (!m_isDown)
                return;
            _model.CurrentTool?.OnUp(sender, arg);
            _box.Invalidate();
            m_isDown = false;
        }

        public void Start()
        {
            _model.toolIdx.Subscribe(i => _box.Cursor = _model.CurrentTool.Cursor());
            _box.MouseDown += OnDown;
            _box.MouseMove += OnMove;
            _box.MouseUp += OnUp;
        }
    }
}
