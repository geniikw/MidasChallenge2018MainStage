using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;
using System.Reactive.Subjects;
using Zenject;

namespace MidasMain.Paint
{
    public class PaintModel
    {
        public int curIdx = 0;
        public Subject<int> toolIdx = new Subject<int>();
        public List<ITool> _tools;

        public Graphics graphics = null;

        [Inject]
        public void Constructor(List<ITool> tools)
        {
            _tools = tools;
            toolIdx.Subscribe(i => curIdx = i);
        }

        public ITool CurrentTool
        {
            get { return _tools[curIdx]; }
        }
    }
}
