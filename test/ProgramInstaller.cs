using MidasMain.Creadit;
using MidasMain.Paint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;

namespace MidasMain
{
    public class ProgramInstaller : Installer<ProgramInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<BindEventToInterface>().AsSingle();

            //Creadit
            Container.BindInterfacesTo<CreaditReader>().AsSingle();

            //paint
            Container.Bind<PaintModel>().AsSingle();
            Container.BindInterfacesTo<ToolSelector>().AsSingle();
            Container.BindInterfacesTo<PaintInitializer>().AsSingle();
            //여기서 선언된 순서와 BaseForm의 radioList안의 순서가 대응됨.
            Container.BindInterfacesTo<NoneTool>().AsSingle();
            Container.BindInterfacesTo<PenTool>().AsSingle();
            Container.BindInterfacesTo<RectTool>().AsSingle();
            Container.BindInterfacesTo<FillTool>().AsSingle();


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
