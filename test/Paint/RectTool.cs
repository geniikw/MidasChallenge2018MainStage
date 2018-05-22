using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidasMain.Paint
{
    public class RectTool : ITool
    {
        public Cursor Cursor()
        {
            return Cursors.Cross;
        }

        public void OnDown(object sender, MouseEventArgs arg)
        {
            Console.WriteLine("Rect Down");
        }

        public void OnMove(object sender, MouseEventArgs arg)
        {
           
        }

        public void OnUp(object sender, MouseEventArgs arg)
        {

        }
    }
}
