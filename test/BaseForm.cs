using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ReactiveAnimation;

namespace MidasMain
{
    public partial class BaseForm : MetroFramework.Forms.MetroForm
    {
        public Animation CloseAnimation;
        public Animation OpenAnimation;

        public readonly float menuSize = 170f;

        public Document current;
		int makeWhat = -1;

        public BaseForm()
        {
            InitializeComponent();

            CreateCloseAnimation();

        }

        private void MakeTestDataButton(object sender, EventArgs e)
        {
            current = new Document();
            current.AddRoom(new Room(0, new Rectangle(new Point(300, 100), new Size(100, 100))));
            current.AddRoom(new Room(1, new Rectangle(new Point(400, 100), new Size(100, 100))));
            current.AddRoom(new Room(2, new Rectangle(new Point(300, 200), new Size(100, 100))));

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
            canvas1.Clear();
        }

        private void LoadButton(object sender, EventArgs e)
        {
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
        }

		private void metroButtonObject_Click(object sender, EventArgs e)
		{
			makeWhat = 1;
		}
		
		private void metroButtonRoom_Click(object sender, EventArgs e)
		{
			makeWhat = 0;
		}

		private void canvas1_MouseDown(object sender, MouseEventArgs e)
		{
			canvas1.AllFocusOut();

			if (makeWhat == -1)
				return;
			else if (makeWhat == 0)
				canvas1.MakeRoom(new Room(0, new Rectangle(new Point(e.X - 75, e.Y - 75), new Size(150, 150))));
			else if (makeWhat == 1)
				canvas1.MakeObject(new Furniture(new Point(e.X - 25, e.Y - 25), 50, 50, "새가구"));

			makeWhat = -1;
		}
	}
}
