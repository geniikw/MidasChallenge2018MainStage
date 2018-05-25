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

        private void UserControl1_Load(object sender, EventArgs e)
        {
            OnDrag.CombineLatest(OnDown.Select(p=>GetOffset(p.Location)), (a,o)=>PointUtil.Minus(a.Location, o))
                .SkipUntil(OnDown)
                .TakeUntil(OnUp)
                .Repeat()
                .Subscribe(p => Location = Parent.PointToClient( PointToScreen( p)));
            
            OnUp.Subscribe(arg => Invalidate());
        }
        
        public Point GetOffset(Point mousePoint)
        {
            var smp = PointToScreen(mousePoint);
            var cp = Parent.PointToScreen(Location);
            return PointUtil.Minus(smp, cp);
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

            e.Graphics.DrawLine(linePen, p1, p2);
        }
    }
}
