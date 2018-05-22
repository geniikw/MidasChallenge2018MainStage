using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;

namespace MidasMain
{
    public class BindEventToInterface
    {
        List<IFixedTickable> _tickList;
        List<IInitializable> _initList;
        /// <summary>
        /// 인자를 List<T>로 만들면 선언된 컨테이너 안에 있는 모든 IFixedTickable을 찾아서 
        /// List안에 넣고 인자로 들어옴.
        /// </summary>
        [Inject]
        public void Constructor(List<IFixedTickable> tickList, List<IInitializable> initList)
        {
            _tickList = tickList;
            _initList = initList;
        }
        
        public void FixedTick()
        {
            foreach (var i in _tickList)
                i.FixedTick();
        }

        public void Init()
        {
            foreach (var i in _initList)
                i.Start();
        }
    }
}
