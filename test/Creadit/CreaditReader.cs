using Markdig;
using MetroFramework.Drawing.Html;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidasMain.Creadit
{
    public class CreaditReader : IInitializable
    {
        readonly HtmlPanel _panel;
        readonly string CreaditPath = "Creadit/Creadit.md";
        public CreaditReader(HtmlPanel panel)
        {
            _panel = panel;
        }

        public void Start()
        {
            using(var sr = new StreamReader(CreaditPath))
            {
                _panel.Text = Markdown.ToHtml(sr.ReadToEnd());
            }

        }
    }
}
