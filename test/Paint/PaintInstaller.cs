using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;

namespace MidasMain.Paint
{
    public class PaintInstaller : Installer<PaintInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<SignalManager>().AsSingle();
            Container.DeclareSignal<EventSignal>().WithId("PaintDown");
            Container.DeclareSignal<EventSignal>().WithId("PaintUp");
            Container.DeclareSignal<EventSignal>().WithId("PaintMove");
          

        }
    }
}
