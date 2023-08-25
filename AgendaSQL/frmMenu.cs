using System;
using System.Windows.Forms;

namespace AgendaSQL
{
    public partial class frmMenu : Form
    {

        //===========================================================================
        public frmMenu()
        {
            InitializeComponent();

            //apresenta versao
            label_versao.Text = vars.versao;
        }

        //===========================================================================
        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        //===========================================================================
        private void cmd_sair_Click(object sender, EventArgs e)
        {
            // sai da aplicacao

            if (MessageBox.Show("Deseja Sair da aplicação", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            Application.Exit();
        }

        //===========================================================================
        private void cmd_adicionar_Click(object sender, EventArgs e)
        {
            frmAdicionarEditar f = new frmAdicionarEditar();
            f.ShowDialog();
        }

        //===========================================================================
        private void cmd_visualizar_Click(object sender, EventArgs e)
        {
            frmResultados f = new frmResultados();

            f.ShowDialog();
        }

        private void cmd_pesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisar f = new frmPesquisar();
            f.ShowDialog();

            //...

            if (f.cancelado)
            {
                f.Dispose();
                return;
            }
            else
            {
                //executa pesquisa
                frmResultados ff = new frmResultados(f.texto_pesquisa);
                ff.ShowDialog();
            }
        }
    }
}