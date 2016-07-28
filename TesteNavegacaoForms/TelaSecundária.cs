using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteNavegacaoForms
{
    public partial class TelaSecundária : Form
    {
        string tag = "Tela secundaria";
        public TelaSecundária(Form MDIParent)
        {
            InitializeComponent();
            this.Tag = tag;
            this.MdiParent = MDIParent;
            this.WindowState = FormWindowState.Maximized;
            this.ControlBox = false;
        }
    }
}
