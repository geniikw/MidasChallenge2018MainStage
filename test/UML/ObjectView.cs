using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reactive.Subjects;
using System.Reactive;
using System.Reactive.Linq;

namespace MidasMain.UML
{
    public partial class ObjectView : UserControl
    {
        public static Pen linePen = new Pen(Color.Black, 1);
        public ObjectView()
        {
            InitializeComponent();
        }

        Subject<MouseEventArgs> OnDown = new Subject<MouseEventArgs>();
        Subject<MouseEventArgs> OnDrag = new Subject<MouseEventArgs>();
        Subject<MouseEventArgs> OnUp = new Subject<MouseEventArgs>();

        Point m_Offset;

        private void UserControl1_Load(object sender, EventArgs e)
        {
            OnDrag
                .SkipUntil(OnDown)
                .TakeUntil(OnUp)
                .Repeat()
                .Subscribe(p => MoveObject(PointToScreen(p.Location)));
        }
        

        public void MoveObject(Point position)
        {
            var p = Parent.PointToClient(position);
            Location = new Point(p.X - m_Offset.X , p.Y - m_Offset.Y);
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PointerDown(object sender, MouseEventArgs e)
        {
            var smp = PointToScreen(e.Location);
            var cp = Parent.PointToScreen(Location);

            m_Offset = new Point(smp.X - cp.X, smp.Y- cp.Y);

            OnDown.OnNext(e);
        }

        private void PointerMove(object sender, MouseEventArgs e)
        {

            OnDrag.OnNext(e);
        }

        private void PointerUp(object sender, MouseEventArgs e)
        {

            OnUp.OnNext(e);
        }

        private void PaintObjectView(object sender, PaintEventArgs e)
        {
            if (!(sender is ObjectView))
                return;

            var left = e.ClipRectangle.Left;
            var right = e.ClipRectangle.Right;
            var top = e.ClipRectangle.Top;
            var bottom = e.ClipRectangle.Bottom;

            var p1 = new Point(left, (top + bottom) / 3);
            var p2 = new Point(right, (top + bottom) / 3);

            e.Graphics.DrawLine(linePen, p1, p2);
        }
    }
}
