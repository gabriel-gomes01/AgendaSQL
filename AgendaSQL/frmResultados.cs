using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgendaSQL
{
    public partial class frmResultados : Form
    {
        int id_contato;
        string item_pesquisa;
        //===========================================================================
        public frmResultados(string item_pesquisa = "")
        {
            InitializeComponent();
            this.item_pesquisa = item_pesquisa;
        }

        //===========================================================================
        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            //Fecha o Form
            this.Close();
        }

        //===========================================================================
        private void frmResultados_Load(object sender, EventArgs e)
        {
            ConstruirGrid();
        }

        //===========================================================================
        private void ConstruirGrid()
        {
            //Constroi a Grid

            //liga ao DB
            string connetionString = "Server= DESKTOP-T3TUCSM; Database= agendasql; Integrated Security=True";
            SqlConnection connection = new SqlConnection(connetionString);
            connection.Open();

            string query = "SELECT * FROM contatos";
            if (item_pesquisa != "")
            {
                query = "SELECT * FROM contatos WHERE nome LIKE @item OR telefone LIKE @item";
            }


            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.AddWithValue("@item", "%" + item_pesquisa + "%");
            sqlCommand.CommandText = query;
            sqlCommand.Connection = connection;


            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            grid_resultados.DataSource = dataTable;

            adapter.Dispose();
            connection.Dispose();

            //Mostra quantidade de pessoas no BD
            lbl_resultados.Text = "Resultados = " + grid_resultados.RowCount;

            //Esconde colunas
            grid_resultados.Columns["id_contato"].Visible = false;
            grid_resultados.Columns["atualizacao"].Visible = false;

            //dimensores das colunas
            grid_resultados.Columns["nome"].Width = CalculaLargura(60);
            grid_resultados.Columns["telefone"].Width = CalculaLargura(40);

            //visibilidade dos botões
            cmd_apagar.Enabled = false;
            cmd_editar.Enabled = false;
        }

        //===========================================================================
        private void grid_resultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_contato = Convert.ToInt16(grid_resultados.Rows[e.RowIndex].Cells["id_contato"].Value);
            cmd_apagar.Enabled = true;
            cmd_editar.Enabled = true;
        }

        //===========================================================================
        private void cmd_apagar_Click(object sender, EventArgs e)
        {
            string connetionString = "Server= DESKTOP-T3TUCSM; Database= agendasql; Integrated Security=True";
            SqlConnection connection = new SqlConnection(connetionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM contatos WHERE id_contato = " + id_contato, connection);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            connection.Dispose();

            //Alualiza tabela
            ConstruirGrid();
        }

        //===========================================================================
        private void cmd_editar_Click(object sender, EventArgs e)
        {
            //Edita
            frmAdicionarEditar f = new frmAdicionarEditar(id_contato);
            f.ShowDialog();

            //atualiza contatos
            ConstruirGrid();
        }

        //===========================================================================
        private void cmd_ver_tudo_Click(object sender, EventArgs e)
        {
            //Apresenta todos os registros

            item_pesquisa = "";
            ConstruirGrid();
        }

        private int CalculaLargura(int porcentegem)
        {
            int largura_grid = grid_resultados.Width - 20;
            int resultado = (largura_grid * porcentegem) / 100;
            return resultado;
        }
    }
}
