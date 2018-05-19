using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zenject;

namespace MidasMain
{
    public partial class BaseForm : MetroFramework.Forms.MetroForm
    {
        DiContainer _container;

        public BaseForm(DiContainer container)
        {
            _container = container;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
