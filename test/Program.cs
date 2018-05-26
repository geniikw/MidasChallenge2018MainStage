﻿using MidasMain.CanvasSpace;
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
            GlobalEvent.OnDocumentChange += UndoManager.Record;
            //GlobalEvent.OnDocumentChange += (a, b) => bbb.GenBlock();
            Application.EnableVisualStyles();
            Application.Run(bbb);
        }
        private static void Kh_KeyDown(Keys key, bool Shift, bool Ctrl, bool Alt)
        {
            Console.WriteLine(key);

        }
    }
}
