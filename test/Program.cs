using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zenject;

namespace MidasMain
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int commitingLine = 1;
            Console.WriteLine(commitingLine);
            DiContainer container = new DiContainer();

            BaseInstaller.Install(container);

            container.Bind<FixedTickList>().AsSingle();
            container.Bind<BaseForm>().AsSingle();
            
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<BaseForm>());
        }
    }
}
