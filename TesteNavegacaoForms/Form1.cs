using System;
using System.Collections;
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
        public static FormPai Current;
        public EList<Form> Childs = new EList<Form>();

        public FormPai()
        {
            InitializeComponent();
            Current = this;
            Childs.Add(new TelaInicial(this));
            this.MdiChildActivate += FormPai_MdiChildActivate;
        }

        private void FormPai_MdiChildActivate(object sender, EventArgs e)
        {
            if (ActiveControl is TelaInicial)
                menuStrip1.Hide();
            else
                menuStrip1.Show();
        }

        private void FormPai_Load(object sender, EventArgs e)
        {
            Childs.Find(x => ((string)x.Tag) == "Tela inicial")?.Show();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Childs[Childs.IndexOf(Childs.Last()) - 1].Show();
            Childs.Remove(Childs.Last());
        }
    }

    public class EList<T> : List<T>
    {
        public event EventHandler OnAdd;
        public event EventHandler OnRemove;

        public new void Add(T item)
        {
            base.Add(item);
            OnAdd?.Invoke(this, EventArgs.Empty);
        }

        public new void Remove(T item)
        {
            base.Remove(item);
            OnRemove?.Invoke(this, EventArgs.Empty);
        }
    }
}
