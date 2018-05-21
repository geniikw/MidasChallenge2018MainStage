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

    /// <summary>
    /// baseForm의 init 이벤트에서 호출된다. 유니티의 Start처럼 쓰기위한 인터페이스
    /// </summary>
    public interface IInitializable
    {
        void Start(object obj, EventArgs arg);
    }
}
