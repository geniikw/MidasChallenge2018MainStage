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
using ReactiveAnimation;

namespace MidasMain.Canvas
{
    public partial class DragItem : UserControl
    {
        public static Pen linePen = new Pen(Color.Black, 1);

        public DragItem()
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

        public virtual void PointerDown(object sender, MouseEventArgs e)
        {
            OnDown.OnNext(e);
        }

        public virtual void PointerMove(object sender, MouseEventArgs e)
        {
            OnDrag.OnNext(e);
        }

        public virtual void PointerUp(object sender, MouseEventArgs e)
        {
            OnUp.OnNext(e);
        }
    }
}
