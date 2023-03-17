using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador
{
    public partial class frmGridUsuario : Form
    {
        string stringConexao = frmLogin.stringConexao;
        public int _codigo;

        public frmGridUsuario()
        {
            InitializeComponent();
        }

        private void TestarConexao()
        {
            SqlConnection conn = new SqlConnection(stringConexao);

            try
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void frmGridUsuario_Load(object sender, EventArgs e)
        {
            TestarConexao();
            CarregarDataGrid();
        }
        private void CarregarDataGrid()
        {
            string sql = "select id_Usuario as 'ID'," +
"Status_Usuario as 'status'," +
"nome_Usuario as 'Nome'," +
"CPF_Usuario as 'CPF'," +
"Login_Usuario as 'Login'," +

"id_departamento_Usuario as 'Departamento'," +
"cep_Usuario as 'CEP'," +
"logradouro_Usuario as 'Rua'," +
"Numero_Usuario as 'Nº'," +
"bairro_Usuario as 'Bairro'," +
"cidade_Usuario as 'Cidade'," +
"uf_Usuario as 'UF'," +
"Complemento_Usuario as 'Complemento'," +
"telefone1_Usuario as 'Tel1'," +
"telefone2_Usuario as 'Tel2'," +
"email_Usuario as 'E-mail'," +
"Obs_Usuario as 'Obs'" +
    "from Usuario where nome_Usuario like '%" + txtPesquisaUser.Text + "%'";


            SqlConnection conn = new SqlConnection(stringConexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataSet dataSet = new DataSet();

            conn.Open();

            try
            {
                adapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridView1.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCells);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _codigo = int.Parse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            this.Close();
        }

        private void pictureBoxFehcar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


    }
}
