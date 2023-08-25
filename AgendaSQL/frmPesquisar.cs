using System;
using System.Windows.Forms;

namespace AgendaSQL
{
    public partial class frmPesquisar : Form
    {
        public string texto_pesquisa { get; set; }
        public bool cancelado { get; set; }

        public frmPesquisar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //...
            if (text_pesquisa.Text == "")
            {
                cancelado = true;
            }
            else
            {
                texto_pesquisa = text_pesquisa.Text;
            }

            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            cancelado = true;
            this.Close();
        }

        private void frmPesquisar_Load(object sender, EventArgs e)
        {

        }
    }
}
