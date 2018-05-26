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

namespace MidasMain.CanvasSpace
{
    public partial class Canvas : UserControl
    {
		public static Canvas instance;

        Subject<MouseEventArgs> OnDown = new Subject<MouseEventArgs>();
        Subject<MouseEventArgs> OnDrag = new Subject<MouseEventArgs>();
        Subject<MouseEventArgs> OnUp = new Subject<MouseEventArgs>();

		List<UCRoom> m_listRoom = new List<UCRoom>();
        List<UCObject> m_listObject = new List<UCObject>();
        List<UCDoor> m_listDoor = new List<UCDoor>();

		Point position = Point.Empty;
		public int makeWhat = -1;	// -1 : none, 0 : room, 1 : door

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
        
		private bool IsObjectInRoom(Point rLoc, Size rSize, Point oLoc, Size oSize)
		{
			if (rLoc.X <= oLoc.X && rLoc.Y <= oLoc.Y && 
				rLoc.X + rSize.Width >= oLoc.X + oSize.Width && 
				rLoc.Y + rSize.Height >= oLoc.Y + oSize.Height)
				return true;

			return false;
		}

		public void BindObjectToRoom()
		{
			for (int i = 0; i < m_listRoom.Count; i++)
				m_listRoom[i].objects.Clear();

			for (int oIdx = m_listObject.Count-1; oIdx >= 0; oIdx--)
				for (int rIdx = m_listRoom.Count-1; rIdx >=0; rIdx--)
					if (IsObjectInRoom(m_listRoom[rIdx].Location, m_listRoom[rIdx].Size, m_listObject[oIdx].Location, m_listObject[oIdx].Size))
					{
						m_listRoom[rIdx].objects.Add(m_listObject[oIdx]);
						break;
					}
		}

        public void Clear()
        {
            List<Control> delList = new List<Control>();
            foreach (Control child in Controls)
            {
                if (child is UCRoom || child is UCObject)
                    delList.Add(child);
            }

            m_listObject.Clear();
            m_listRoom.Clear();

            foreach (var todel in delList)
            {
                Controls.Remove(todel);
                todel.Dispose();
            }
        }

        public void SetupDocument(Document doc)
        {
            Clear();
            var n = 0;
            foreach (var room in doc.rooms)
            {
                var makeRoom = new UCRoom();
                this.Controls.Add(makeRoom);
                makeRoom.SetupRoom(room);
                makeRoom.Visible = true;
				makeRoom.UpdateScalerPosition();
				m_listRoom.Add(makeRoom);
                Console.WriteLine(room.Rect);
            }
            foreach (var f in doc.objects)
            {
                var makeobj = new UCObject();
                this.Controls.Add(makeobj);
                m_listObject.Add(makeobj);
                makeobj.SetupData(f);
				makeobj.UpdateScalerPosition();
            }
            foreach(var d in doc.doors)
            {
				Console.WriteLine("hello!" + d.pA + ", " + d.kind);
                var makeDoor = Canvas.instance.MakeDoor(d);
                makeDoor.Setup(d);
			}

        }

        public Document GetCurrent()
        {
            var doc = new Document();
            var n = 1;
            foreach (var r in m_listRoom)
            {
                doc.AddRoom(new Room(n++, new Rectangle(r.Location, r.Size), r.BackColor));
            }

            foreach (var o in m_listObject)
            {
                doc.objects.Add(new Furniture(o.Location, o.Size.Width, o.Size.Height, o.Name));
            }
            foreach(var d in m_listDoor)
            {
                doc.doors.Add(new Door(d.pA, d.kind, d.isDoor));
            }

            return doc;
        }

        public void MakeRoom(Room nRoom)
		{
			var makeRoom = new UCRoom();
			this.Controls.Add(makeRoom);
			makeRoom.SetupRoom(nRoom);
			makeRoom.Visible = true;
			m_listRoom.Add(makeRoom);
			makeRoom.UpdateScalerPosition();
			SetZIndex();
		}

		public void MakeObject(Furniture obj)
		{
			var makeObj = new UCObject();
			this.Controls.Add(makeObj);
			m_listObject.Add(makeObj);
			makeObj.SetupData(obj);
			makeObj.UpdateScalerPosition();
			SetZIndex();
		}

		public UCDoor MakeDoor(Door door)
		{
			UCDoor uDoor = new UCDoor();

			Parent.Controls.Add(uDoor);
			Parent.Controls.SetChildIndex(uDoor, 0);

			uDoor.pA = door.pA;
			uDoor.Location = uDoor.pA;
			uDoor.kind = door.kind;
			uDoor.pB = uDoor.pA;
			uDoor.isDoor = door.isDoor;
			if (door.kind %2 == 0)
				uDoor.pB = PointUtil.Plus(door.pB, new Point(0, 50));
			else
				uDoor.pB = PointUtil.Plus(door.pB, new Point(50, 0));

			if (door.isDoor)
				switch (door.kind)
				{
					case 0: // right
						uDoor.BackgroundImage = Properties.Resources.rDoor0;
						break;
					case 1: // up
						uDoor.BackgroundImage = Properties.Resources.rDoor1;
						uDoor.Location = PointUtil.Minus(uDoor.Location, new Point(0, 50));
						break;
					case 2: // left
						uDoor.BackgroundImage = Properties.Resources.rDoor2;
						uDoor.Location = PointUtil.Minus(uDoor.Location, new Point(50, 0));
						break;
					case 3:
						uDoor.BackgroundImage = Properties.Resources.rDoor3;
						break;
				}
			else
			{
				if (uDoor.kind % 2 == 0)
				{
					uDoor.BackgroundImage = Properties.Resources.rWindow1;
					uDoor.Location = PointUtil.Minus(uDoor.Location, new Point(10, 0));
					uDoor.Size = new Size(new Point(20, 50));
				}
				else
				{
					uDoor.BackgroundImage = Properties.Resources.rWindow0;
					uDoor.Location = PointUtil.Minus(uDoor.Location, new Point(0, 10));
					uDoor.Size = new Size(new Point(50, 20));
				}
			}
			m_listDoor.Add(uDoor);
			return uDoor;
		}

		public void SetZIndex()
		{
			for(int i=0; i<m_listObject.Count; i++)
				this.Controls.SetChildIndex(m_listObject[m_listObject.Count-i-1], i);

			for (int i = 0; i < m_listRoom.Count; i++)
				this.Controls.SetChildIndex(m_listRoom[m_listRoom.Count - i - 1], i+ m_listObject.Count);

            for (int i = 0; i < m_listDoor.Count; i++)
            {
                
            }
        }

		public void AllFocusOut()
		{
			for (int i = 0; i < m_listObject.Count; i++)
				m_listObject[i].FocusOut();

			for (int i = 0; i < m_listRoom.Count; i++)
				m_listRoom[i].FocusOut();
		}
        
        private void DragTest(object sender, DragEventArgs e)
        {
            if (!(sender is Control))
                return;

            Console.WriteLine(((Control)sender).Name);
        }

		public bool IsInRoom(Point loc, Size size)
		{
			Rectangle objRect = new Rectangle(loc, size);
			for (int i= m_listRoom.Count-1; i>=0; i--)
			{
				Rectangle roomRect = new Rectangle(m_listRoom[i].Location, m_listRoom[i].Size);
				if (IsObjectInRoom(m_listRoom[i].Location, m_listRoom[i].Size, loc, size))
					return true;

				if (objRect.IntersectsWith(roomRect))
					return false;
			}
			return false;
		}

	}
}
