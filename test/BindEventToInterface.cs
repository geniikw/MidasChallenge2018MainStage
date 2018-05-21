using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidasMain
{
    public class BindEventToInterface
    {
        readonly List<IFixedTickable> _tickList;
        readonly List<IInitializable> _initList;
        /// <summary>
        /// 인자를 List<T>로 만들면 선언된 컨테이너 안에 있는 모든 IFixedTickable을 찾아서 
        /// List안에 넣고 인자로 들어옴.
        /// </summary>
        public BindEventToInterface(List<IFixedTickable> tickList, List<IInitializable> initList)
        {
            _tickList = tickList;
            _initList = initList;
        }
        
        public void FixedTick()
        {
            foreach (var i in _tickList)
                i.FixedTick();
        }

        public void Init(object obj, EventArgs arg)
        {
            foreach (var i in _initList)
                i.Start(obj, arg);
        }
    }
}
