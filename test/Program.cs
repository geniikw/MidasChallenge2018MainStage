using MidasMain.CanvasSpace;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidasMain
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            var bbb = new BaseForm();
            //kh.KeyDown += Kh_KeyDown;
            GlobalEvent.OnDocumentChangeBefore += UndoManager.Record;
            GlobalEvent.OnDocumentChangeBefore += (a,b) => bbb.ClearBlock();
            GlobalEvent.OnDocumentChangeAfter += (a, b) => Canvas.instance.SetZIndex();
            GlobalEvent.OnDocumentChangeAfter += (a, b) => bbb.GenBlock();
			GlobalEvent.OnDocumentChangeAfter += (a, b) => Canvas.instance.BindDoorToRoom();
			GlobalEvent.OnDocumentChangeAfter += BaseForm.instance.Validation;

            UndoManager.UndoCallback += () => bbb.ClearBlock();
            UndoManager.UndoCallback += () => Canvas.instance.SetZIndex();
            UndoManager.UndoCallback += () => bbb.GenBlock();
            Application.EnableVisualStyles();
            Application.Run(bbb);
        }
        private static void Kh_KeyDown(Keys key, bool Shift, bool Ctrl, bool Alt)
        {
            Console.WriteLine(key);

        }
    }
}
