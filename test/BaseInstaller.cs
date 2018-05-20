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
        readonly DiContainer container;

        public BaseInstaller(DiContainer container)
        {
            this.container = container;
        }           

        public override void InstallBindings()
        {
            
        }
    }
}
