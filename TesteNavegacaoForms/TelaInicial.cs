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
    public partial class TelaInicial : Form
    {
        public static string tag = "Tela inicial";
        public TelaInicial(Form MDIParent)
        {
            InitializeComponent();
            this.Tag = tag;
            this.MdiParent = MDIParent;
            this.WindowState = FormWindowState.Maximized;
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = FormPai.Current.Childs.Find(x => ((string)x.Tag) == "Tela secundaria");
            if(form != null)
            {
                this.Hide();
                form.Show();
            }else
            {
                this.Hide();
                form = new TelaSecundária(this.MdiParent);
                FormPai.Current.Childs.Add(form);
                form.Show();
            }

        }
    }
}
