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

namespace MidasMain.CanvasSpace
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
                .Subscribe(p => Location = Clamp( Parent.PointToClient( PointToScreen( p))));
            
            OnUp.Subscribe(arg => Invalidate());
        }

        Point Clamp(Point input)
        {
            if (input.X < 0)
                input.X = 0;
            if (input.Y < 0)
                input.Y = 0;

            var maxW = BaseForm.instance.Width - 200;
            var maxH = BaseForm.instance.Height - 280;
            
            if (input.X > maxW)
                input.X = maxW;
            if (input.Y > maxH)
                input.Y = maxH;
            return input;
        }

        public Point GetOffset(Point mousePoint)
        {
            var smp = PointToScreen(mousePoint);
            var cp = Parent.PointToScreen(Location);
            return PointUtil.Minus(smp, cp);
        }

        public virtual void PointerDown(object sender, MouseEventArgs e)
        {
            GlobalEvent.OnDocumentChangeBefore.Invoke(Canvas.instance.GetCurrent(),"Move");
            OnDown.OnNext(e);
        }

        public virtual void PointerMove(object sender, MouseEventArgs e)
        {
            OnDrag.OnNext(e);
        }

        public virtual void PointerUp(object sender, MouseEventArgs e)
        {
            GlobalEvent.OnDocumentChangeAfter?.Invoke("Location change");
            OnUp.OnNext(e);
        }
    }
}
