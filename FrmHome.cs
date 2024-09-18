using System;
using System.Windows.Forms;
using PDV.cadastro;

namespace PDV
{
    public partial class FrmTelaHome : Form
    {
        public FrmTelaHome()
        {
            InitializeComponent();
        }

        private void frmTelaHome_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuFuncionarios_Click(object sender, EventArgs e)
        {
            cadastro.FrmFuncionario frm = new FrmFuncionario();
            frm.ShowDialog();
        }
    }
}
