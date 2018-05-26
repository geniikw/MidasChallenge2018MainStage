using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using MidasMain.CanvasSpace;
using ReactiveAnimation;

namespace MidasMain
{
    public partial class BaseForm : MetroFramework.Forms.MetroForm
    {
        public static BaseForm instance;
        
        public Animation CloseAnimation;
        public Animation OpenAnimation;

        public readonly float menuSize = 170f;

        public Document current;
		int makeWhat = -1;

        public BaseForm()
        {
            instance = this;
            InitializeComponent();

            CreateCloseAnimation();
        }

        private void MakeTestDataButton(object sender, EventArgs e)
        {
            current = new Document();
            current.AddRoom(new Room(0, new Rectangle(new Point(300, 100), new Size(100, 100)), -1));
            current.AddRoom(new Room(1, new Rectangle(new Point(400, 100), new Size(100, 100)), -1));
            current.AddRoom(new Room(2, new Rectangle(new Point(300, 200), new Size(100, 100)), -1));

            current.objects.Add(new Furniture(new Point(400, 200), 50, 50, "냉장고"));
            current.objects.Add(new Furniture(new Point(400, 250), 50, 50, "TV"));
            current.objects.Add(new Furniture(new Point(350, 200), 50, 50, "냉장고"));
            
            canvas1.SetupDocument(current);
        }

        private void SaveButton(object sender, EventArgs e)
        {
            var dia = new SaveFileDialog();
            dia.Filter = "XMLfile|*.xml";
            dia.Title = "Save an document File";
            dia.ShowDialog();
            if(dia.FileName != "")
            {
                using ( var fs = (FileStream)dia.OpenFile())
                {
                    var doc = canvas1.GetCurrent();
                    var sr = new XmlSerializer(typeof(Document));

                    sr.Serialize(fs, doc);
                }
            }
        }

        private void NewButton(object sender, EventArgs e)
        {
            GlobalEvent.OnDocumentChangeBefore?.Invoke(Canvas.instance.GetCurrent(), "LoadButton");

            canvas1.Clear();

            GlobalEvent.OnDocumentChangeAfter?.Invoke("LoadButton");
        }

        private void LoadButton(object sender, EventArgs e)
        {
            GlobalEvent.OnDocumentChangeBefore?.Invoke(Canvas.instance.GetCurrent(), "LoadButton");

            var dia = new OpenFileDialog();
            dia.Filter = "XMLfile|*.xml";
            dia.Title = "Load";
            dia.ShowDialog();
            if (dia.FileName != "")
            {
                using (var fs = (FileStream)dia.OpenFile())
                {
                    var doc = canvas1.GetCurrent();
                    var sr = new XmlSerializer(typeof(Document));

                    var output = sr.Deserialize(fs);
                    canvas1.SetupDocument((Document)output);
                }
            }

            GlobalEvent.OnDocumentChangeAfter?.Invoke("LoadButton");
        }

        private void SelectRoomButton(object sender, EventArgs e)
		{
			makeWhat = 1;
		}
		
		private void SelectObjectButton(object sender, EventArgs e)
		{
			makeWhat = 0;
		}

		private void canvas1_MouseDown(object sender, MouseEventArgs e)
		{
			canvas1.AllFocusOut();

			if (makeWhat == -1)
				return;

            GlobalEvent.OnDocumentChangeBefore?.Invoke(Canvas.instance.GetCurrent(), "AddItem");

            if (makeWhat == 0)
				canvas1.MakeRoom(new Room(0, new Rectangle(new Point(e.X - 75, e.Y - 75), new Size(150, 150))));
			else if (makeWhat == 1)
				canvas1.MakeObject(new Furniture(new Point(e.X - 25, e.Y - 25), 50, 50, "새가구"));
            GlobalEvent.OnDocumentChangeAfter?.Invoke("ADD item");
            makeWhat = -1;
		}

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (CloseAnimation == null)
                return;
            metroButton2.Visible = true;
            CloseAnimation.Start();
            CreateOpenAnimation();
            CloseAnimation = null;
            metroButton1.Visible = false;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (OpenAnimation == null)
                return;
            metroButton1.Visible = true;
            OpenAnimation.Start();
            CreateCloseAnimation();
            OpenAnimation = null;
            metroButton2.Visible = false;
        }

        public void CreateOpenAnimation()
        {
            OpenAnimation = new Animation()
            {
                DurationInFrames = Animation.FromTimeSpanToDurationInFrames(0.2),
                EasingFunction = ef => Easing.EaseInOut(ef, EasingType.Quadratic)
            };
            OpenAnimation.AnimateOnControlThread(
                metroPanel1,
                ObservableHelper.FixedValue(0f),
                ObservableHelper.FixedValue(menuSize),
                f => metroPanel1.Size = new Size((int)f.CurrentValue, metroPanel1.Size.Height));
        }

        public void CreateCloseAnimation()
        {
            CloseAnimation = new Animation()
            {
                DurationInFrames = Animation.FromTimeSpanToDurationInFrames(0.2),
                EasingFunction = ef => Easing.EaseInOut(ef, EasingType.Quadratic)
            };
            CloseAnimation.AnimateOnControlThread(
                metroPanel1,
                ObservableHelper.FixedValue(menuSize),
                ObservableHelper.FixedValue(0f),
                f => metroPanel1.Size = new Size((int)f.CurrentValue, metroPanel1.Size.Height));
        }

        public void GenerateBlock(object sender, EventArgs e)
        {
            GenBlock();
        }
        public void ValidateConstruction()
        {
            Document a = canvas1.GetCurrent();
            Console.WriteLine(a.ValidateConstruction());
        }
        public void CaputreScreen()
        {
            using (Bitmap bmp = new Bitmap(this.Width, this.Height))
            {
                InvertZOrderOfControls(canvas1);
                Rectangle rect = new Rectangle(canvas1.Location, canvas1.Size);
                canvas1.DrawToBitmap(bmp, rect);
                bmp.Save(@"C:/Users/jonghun/Desktop/output.png", ImageFormat.Png); // make sure path exists!
                InvertZOrderOfControls(canvas1);
            }
        }
        private static void InvertZOrderOfControls(Control ctrlParent)

        {

            if (ctrlParent.Controls.Count == 0)

            {

                return;

            }

            List<Control> childControls = new List<Control>();

            List<Control> sortedChildControls = new List<Control>();

            foreach (Control ctrlChild in ctrlParent.Controls)

            {

                childControls.Add(ctrlChild);

            }

            while (childControls.Count > 0)

            {

                Control ctrlMin = FindControlWithMinZOrder(ctrlParent, childControls);

                sortedChildControls.Add(ctrlMin);

                childControls.Remove(ctrlMin);

            }

            for (int i = 0; i < sortedChildControls.Count / 2; i++)

            {

                Control ctrlChild1 = sortedChildControls[i];

                Control ctrlChild2 = sortedChildControls[sortedChildControls.Count - 1 - i];

                int zOrder1 = ctrlParent.Controls.GetChildIndex(ctrlChild1);

                int zOrder2 = ctrlParent.Controls.GetChildIndex(ctrlChild2);

                ctrlParent.Controls.SetChildIndex(ctrlChild1, zOrder2);

                ctrlParent.Controls.SetChildIndex(ctrlChild2, zOrder1);

            }

            foreach (Control ctrlChild in ctrlParent.Controls)

            {

                InvertZOrderOfControls(ctrlChild);

            }

        }





        private static Control FindControlWithMinZOrder(Control ctrlParent, List<Control> children)

        {

            if (children.Count == 0)

            {

                return null;

            }

            Control ctrlMin = children[0];

            foreach (Control ctrl in children)

            {

                if (ctrlParent.Controls.GetChildIndex(ctrl) < ctrlParent.Controls.GetChildIndex(ctrlMin))

                {

                    ctrlMin = ctrl;

                }

            }

            return ctrlMin;

        }
        private void CaputreScreen(object sender, EventArgs e)
        {
            var dia = new SaveFileDialog();
            dia.Filter = "PNGImage|*.png";
            dia.Title = "Export Image";
            dia.ShowDialog();
            if (dia.FileName != "")
            {
                using (var fs = (FileStream)dia.OpenFile())
                {
                    using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                    {
                        Rectangle rect = new Rectangle(canvas1.Location, canvas1.Size);
                        canvas1.DrawToBitmap(bmp, rect);
                        
                        bmp.Save(fs, ImageFormat.Png); // make sure path exists!
                    }

                }
            }

           
        }
        public void ClearBlock()
        {
            Stack<Control> toDel = new Stack<Control>();
            foreach(Control c in canvas1.Controls)
            {
                if (c is UCWall)
                    toDel.Push(c);
            }
            foreach(var d in toDel)
            {
                canvas1.Controls.Remove(d);
                d.Dispose();
            }
        }

        public void GenBlock()
        {
            ClearBlock();
            Document a = canvas1.GetCurrent();
            a.GetLinesOfRoom();
            foreach (Line line in a.lines)
            {
                UCWall temp = new UCWall();
                canvas1.Controls.Add(temp);
                Size tSize = new Size(PointUtil.Minus(line.pB, line.pA));
                if (tSize.Width == 0)
                {
                    temp.isVertical = true;
                    temp.Location = PointUtil.Plus(line.pA, new Point(-2, 2));
                    tSize.Width = 5;
                    tSize.Height -= 2;
                }
                else
                {
                    temp.isVertical = false;
                    temp.Location = PointUtil.Plus(line.pA, new Point(2, -2));
                    tSize.Height = 5;
                    tSize.Width -= 2;
                }
                temp.Size = tSize;
                canvas1.Controls.SetChildIndex(temp, 0);

                //Console.WriteLine("draw loc :" + temp.Location + "size : " + temp.Size);
            }
        }

        private void canvas1_Load(object sender, EventArgs e)
        {

        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void KeyDownHandler(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Z && e.Control)
            {
                UndoManager.Undo();
            }

        }

       
    }
}
