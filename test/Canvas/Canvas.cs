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
using System.Reactive.Linq;

namespace MidasMain.Canvas
{
    public partial class Canvas : UserControl
    {
		public static Canvas instance;

        Subject<MouseEventArgs> OnDown = new Subject<MouseEventArgs>();
        Subject<MouseEventArgs> OnDrag = new Subject<MouseEventArgs>();
        Subject<MouseEventArgs> OnUp = new Subject<MouseEventArgs>();

		List<UCRoom> m_listRoom = new List<UCRoom>();

		Point position = Point.Empty;

        public Canvas()
        {
            InitializeComponent();
            this.AutoScroll = true;
            position = Location;
            OnDrag
                .CombineLatest(OnDown.Select(a => PointUtil.Minus(Location, position)), (a, i) => PointUtil.Minus(Location, i))
                .SkipUntil(OnDown)
                .TakeUntil(OnUp)
                .Repeat()
                .Buffer(2)
                .Select(b => PointUtil.Minus(b[1], b[0]))
                .Subscribe(d => MoveChild(d));
            OnUp.Subscribe(d => position = Location);

			instance = this;
		}

        public void MoveChild(Point move)
        {
            foreach (Control c in Parent.Controls)
            {
                c.Location = PointUtil.Plus(c.Location, move);
            }
        }

        private void MouseDownReceiver(object sender, MouseEventArgs e)
        {
            OnDown.OnNext(e);
        }

        private void MouseDragReceiver(object sender, MouseEventArgs e)
        {
            OnDrag.OnNext(e);
        }

        private void MouseUpReceiver(object sender, MouseEventArgs e)
        {
            OnUp.OnNext(e);
        }

        public void SetupDocument(Document doc)
        {
            foreach (var room in doc.rooms)
            {
                var makeRoom = new UCRoom();

                makeRoom.Visible = true;
                m_listRoom.Add(makeRoom);
            }
        }

		private bool IsObjectInRoom(Point rLoc, Size rSize, Point oLoc, Size oSize)
		{
			Console.WriteLine("??");
			if (rLoc.X < oLoc.X && rLoc.Y < oLoc.Y && 
				rLoc.X + rSize.Width > oLoc.X + oSize.Width && 
				rLoc.Y + rSize.Height > oLoc.Y + oSize.Height)
				return true;

			return false;
		}

		public int SearchRommForObject(UCObject obj)
		{
			if (obj.inRoom != null)
				obj.inRoom.objects.Remove(obj);

			for (int i = 0; i < m_listRoom.Count; i++)
			{
				if (IsObjectInRoom(m_listRoom[i].Location, m_listRoom[i].Size, obj.Location, obj.Size))
				{
					Console.WriteLine("obj is in " + i);
					m_listRoom[i].objects.Add(obj);
					obj.inRoom = m_listRoom[i];
					return i;
				}
			}

			obj.inRoom = null;
			return -1;
		}
    }
}
