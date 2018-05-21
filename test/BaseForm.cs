
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Markdig;
using Zenject;
using MetroFramework.Controls;
using MidasMain.Paint;

namespace MidasMain
{
    public partial class BaseForm : MetroFramework.Forms.MetroForm
    {
        BindEventToInterface _eventManager;
        EventSignal m_paintDown;
        EventSignal m_paintUp;
        EventSignal m_paintMove;

        public BaseForm(BindEventToInterface fixedList, DiContainer container)
        {
            _eventManager = fixedList;
            InitializeComponent();
            //paint
            DiContainer pC = new DiContainer(new DiContainer[]{ container });
            pC.Bind<PictureBox>().FromInstance(pictureBox1).AsSingle();
            pC.Bind<MetroButton>().WithId("Save").FromInstance(SaveButton).AsCached();
            pC.Bind<MetroButton>().WithId("Load").FromInstance(LoadButton).AsCached();
            pC.Bind<MetroRadioButton>().WithId("Rect").FromInstance(RectRadio).AsCached();
            pC.Bind<MetroRadioButton>().WithId("Pen").FromInstance(RectRadio).AsCached();
            pC.Bind<MetroRadioButton>().WithId("Fill").FromInstance(RectRadio).AsCached();
                     
            PaintInstaller.Install(pC);
            m_paintDown = pC.ResolveId<EventSignal>("PaintDown");
            m_paintUp = pC.ResolveId<EventSignal>("PaintUp");
            m_paintMove = pC.ResolveId<EventSignal>("PaintMove");
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            _eventManager.Init(sender, e);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _eventManager.FixedTick();
        }

        private void PaintDown(object sender, MouseEventArgs e)
        {
            m_paintDown.Fire(sender, e);
        }

        private void PaintMove(object sender, MouseEventArgs e)
        {
            m_paintMove.Fire(sender, e);
        }

        private void PaintUp(object sender, MouseEventArgs e)
        {
            m_paintUp.Fire(sender, e);
        }
    }
}
