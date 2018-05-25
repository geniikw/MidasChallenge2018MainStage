﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Markdig;

namespace MidasMain.Creadit
{
    public partial class CreaditPanel : UserControl
    {
        readonly string CreaditPath = "Creadit/Creadit.md";

        public CreaditPanel()
        {
            InitializeComponent();

            if (!File.Exists(CreaditPath))
                return;
            using (var sr = new StreamReader(CreaditPath))
            {
                htmlPanel1.Text = Markdown.ToHtml(sr.ReadToEnd());
            }
        }
    }
}
