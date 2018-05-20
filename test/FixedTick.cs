using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidasMain
{
    public class FixedTickList
    {
        readonly List<IFixedTickable> _tickList;
        
        public FixedTickList(List<IFixedTickable> tickList)
        {
            _tickList = tickList;
        }
        
        public void FixedTick()
        {
            foreach (var i in _tickList)
                i.FixedTick();
        }
    }
}
