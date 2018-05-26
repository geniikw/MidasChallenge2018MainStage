using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidasMain.Canvas
{
    public partial class Canvas
    {
        List<UCRoom> m_listRoom = new List<UCRoom>();

        public void SetupDocument(Document doc)
        {
            foreach (var room in doc.rooms)
            {
                var makeRoom = new UCRoom();

                makeRoom.Visible = true;
                m_listRoom.Add(makeRoom);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Name = "Canvas";
            this.Size = new System.Drawing.Size(626, 419);
            this.ResumeLayout(false);

        }
    }
}
