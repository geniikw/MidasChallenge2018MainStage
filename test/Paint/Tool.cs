using System;
using System.Windows.Forms;

namespace MidasMain.Paint
{
    public interface ITool
    {
        void OnDown(object sender, MouseEventArgs arg);
        void OnUp(object sender, MouseEventArgs arg);
        void OnMove(object sender, MouseEventArgs arg);
        Cursor Cursor();
    }

    public class NoneTool : ITool
    {
        public Cursor Cursor()
        {
            return Cursors.Arrow;
        }

        public void OnDown(object sender, MouseEventArgs arg)
        {
            Console.WriteLine("None Down");
        }

        public void OnMove(object sender, MouseEventArgs arg)
        {

        }

        public void OnUp(object sender, MouseEventArgs arg)
        {
        }
    }
}