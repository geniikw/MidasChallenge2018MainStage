using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidasMain
{
    /// <summary>
    /// deltaTime : timer의 interval value;
    /// </summary>
    public interface IFixedTickable
    {
        void FixedTick();
    }
}
