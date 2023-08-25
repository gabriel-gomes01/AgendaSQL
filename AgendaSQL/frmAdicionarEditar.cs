using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgendaSQL
{
    public partial class frmAdicionarEditar : Form
    {
        int id_contato;
        bool editar;

        //===========================================================================
        public frmAdicionarEditar(int id_contato = -1)
        {
            InitializeComponent();
            this.id_contato = id_contato;


            // adicionar ou editar
            editar = id_contato == -1 ? false : true;
        }

        //===========================================================================
        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            //Fecha o Form
            this.Close();
        }

        //===========================================================================
        private void frmAdicionarEditar_Load(object sender, EventArgs e)
        {
            if (editar)
            {
                ApresentaContato();
            }
        }

        //===========================================================================
        private void ApresentaContato()
        {
            //Apresenta contato para ser editado
            SqlConnection connection = new SqlConnection("Server= DESKTOP-T3TUCSM; Database= agendasql; Integrated Security=True");
            connection.Open();

            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM contatos WHERE id_contato = " + id_contato, connection);
            adapter.Fill(dataTable);
            connection.Dispose();

            text_nome.Text = dataTable.Rows[0]["nome"].ToString();
            text_telefone.Text = dataTable.Rows[0]["telefone"].ToString();
        }

        //===========================================================================
        private void cmd_gravar_Click(object sender, EventArgs e)
        {

            string connetionString = "Server= DESKTOP-T3TUCSM; Database= agendasql; Integrated Security=True";
            SqlConnection connection = new SqlConnection(connetionString);
            connection.Open();


            #region VERIFICAÇÕES
            //verifica se os campos estão vazio
            if (text_nome.Text == "" || text_telefone.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            #endregion


            #region NOVO CONTATO
            if (!editar)
            {
                //Busca o id_contato disponivel
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT MAX(id_contato) AS maxid FROM contatos", connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);


                //verifica so o valor é nulo
                if (DBNull.Value.Equals(dataTable.Rows[0][0]))
                {
                    id_contato = 0;
                }
                else
                {
                    id_contato = Convert.ToInt16(dataTable.Rows[0][0]) + 1;
                }

                //grava novo contato no banco
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;

                //parametros
                sqlCommand.Parameters.AddWithValue("@id_contato", id_contato);
                sqlCommand.Parameters.AddWithValue("@nome", text_nome.Text);
                sqlCommand.Parameters.AddWithValue("@telefone", text_telefone.Text);
                sqlCommand.Parameters.AddWithValue("@atualizacao", DateTime.Now);


                //verifica se existe contato com o mesmo nome e telefone
                adapter = new SqlDataAdapter();
                dataTable = new DataTable();
                sqlCommand.CommandText = "SELECT * FROM contatos WHERE nome = @nome AND telefone = @telefone";
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count != 0)
                {
                    if (MessageBox.Show("Contato já existe no Banco de Dados. \n Gravar mesmo assim ?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                }

                //Query
                sqlCommand.CommandText = "INSERT INTO contatos VALUES ( @id_contato, @nome, @telefone, @atualizacao)";

                //Executa a query
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                connection.Dispose();

                MessageBox.Show("Adicionado");

                //Limpa textos
                text_nome.Text = "";
                text_telefone.Text = "";
                text_nome.Focus();
            }
            #endregion


            #region EDITAR CONTATO
            else
            {
                //edita contato no banco
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;

                //parametros
                sqlCommand.Parameters.AddWithValue("@id_contato", id_contato);
                sqlCommand.Parameters.AddWithValue("@nome", text_nome.Text);
                sqlCommand.Parameters.AddWithValue("@telefone", text_telefone.Text);
                sqlCommand.Parameters.AddWithValue("@atualizacao", DateTime.Now);

                //verifica se existe registro com o mesmo nome
                DataTable dataTable = new DataTable();
                sqlCommand.CommandText = "SELECT * FROM contatos WHERE nome = @nome AND id_contato <> @id_contato";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count != 0)
                {
                    //foi encontrado registro com o mesmo nome
                    if (MessageBox.Show("Contato já existe no Banco de Dados. \n Gravar mesmo assim ?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                }

                //edita registro
                sqlCommand.CommandText = "UPDATE contatos SET nome = @nome, telefone = @telefone, atualizacao = @atualizacao WHERE id_contato = @id_contato";
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Registro Alterado");

                //fecha o quadro
                this.Close();

            }
            #endregion
        }
    }
}
