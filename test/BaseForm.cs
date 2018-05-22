
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
using MetroFramework.Drawing.Html;

namespace MidasMain
{
    public partial class BaseForm : MetroFramework.Forms.MetroForm
    {
        BindEventToInterface _eventManager;
        PaintModel _paint;
        DiContainer _Container = new DiContainer();
        List<MetroRadioButton> m_radioList = new List<MetroRadioButton>();
        [Inject]
        public void Contructor(PaintModel paint, BindEventToInterface em)
        {
            _paint = paint;
            _eventManager = em;
        }

        public BaseForm()
        {
            InitializeComponent();
            ControlInstaller(_Container);

            ProgramInstaller.Install(_Container);
            
            _Container.Inject(this);
        }

        public void ControlInstaller(DiContainer container) {
            //Creadit
            container.BindInstance(htmlPanel1);
            //Paint
            m_radioList.AddRange(new MetroRadioButton[] {NoneRadio ,PenRadio,FillRadio,RectRadio });

            container.BindInstance(pictureBox1);
            container.BindInstance(SaveButton).WithId("Save");
            container.BindInstance(LoadButton).WithId("Load");
        }


        private void BaseForm_Load(object sender, EventArgs e)
        {
            _eventManager.Init();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _eventManager.FixedTick();
        }

        private void Checked_Changed(object sender, EventArgs e)
        {
            _paint.toolIdx.OnNext(m_radioList.FindIndex(r => r.Checked));
        }
    }
}
