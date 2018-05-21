using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;

namespace MidasMain
{
    public class BaseInstaller : Installer<BaseInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<BindEventToInterface>().AsSingle();
            Container.Bind<BaseForm>().AsSingle();
            //Container.BindInterfacesTo<TickExample>().AsSingle();
        }
    }    

    //public class TickExample : IFixedTickable
    //{
    //    public void FixedTick()
    //    {
    //        Console.WriteLine("100ms 마다 호출");
    //    }
    //}
}
