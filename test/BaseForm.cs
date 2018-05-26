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

namespace MidasMain
{
    public partial class BaseForm : MetroFramework.Forms.MetroForm
    {
        public Document current; 
        
        public BaseForm()
        {
            InitializeComponent();
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
            dia.Filter = "*.xml";
            dia.Title = "Save an document File";
            var path = dia.ShowDialog();
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

        }
    }
}
