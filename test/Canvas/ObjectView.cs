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

        Graphics g;
        Subject<MouseEventArgs> OnDown = new Subject<MouseEventArgs>();
        Subject<MouseEventArgs> OnDrag = new Subject<MouseEventArgs>();
        Subject<MouseEventArgs> OnUp = new Subject<MouseEventArgs>();

        Point m_Offset;

        private void UserControl1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            OnDrag
                .SkipUntil(OnDown)
                .TakeUntil(OnUp)
                .Repeat()
                .Subscribe(p => MoveObject(PointToScreen(p.Location)));

            OnDown.Subscribe(arg => {
                var smp = PointToScreen(arg.Location);
                var cp = Parent.PointToScreen(Location);
                m_Offset = new Point(smp.X - cp.X, smp.Y - cp.Y);
            });

            OnUp.Subscribe(arg => Invalidate());
        }
        

        public void MoveObject(Point position)
        {
            var p = Parent.PointToClient(position);
            Location = new Point(p.X - m_Offset.X , p.Y - m_Offset.Y);
        }
        
        private void PointerDown(object sender, MouseEventArgs e)
        {
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
            var left = e.ClipRectangle.Left;
            var right = e.ClipRectangle.Right;
            var top = e.ClipRectangle.Top;

            var p1 = new Point(left, top +20);
            var p2 = new Point(right, top +20);

            g.DrawLine(linePen, p1, p2);
        }
    }
}
