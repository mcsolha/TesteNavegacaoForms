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
    public partial class FormPai : Form
    {
        /**
         * Exemplo para navegação dentro de form.
         * Link para consulta:
         * https://msdn.microsoft.com/pt-br/library/7aw8zc76(v=vs.110).aspx
         */
        List<Form> childs = new List<Form>
        Form child = new Form();
        public FormPai()
        {
            InitializeComponent();
            child.MdiParent = this;
        }

        private void forwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.Show();
            child.WindowState = FormWindowState.Maximized;
            child.ControlBox = false;
        }
    }
}
