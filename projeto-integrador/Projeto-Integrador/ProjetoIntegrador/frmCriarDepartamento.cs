using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ProjetoIntegrador
{
    public partial class frmCriarDepartamento : Form
    {
        string stringConexao = frmLogin.stringConexao;
        private void testarConexao()
        {
            SqlConnection conn = new SqlConnection(stringConexao);

            try
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.ToString());
                Application.Exit();
            }
        }

        public frmCriarDepartamento()
        {
            InitializeComponent();
        }
        private void frmCriarDepartamento_Load_1(object sender, EventArgs e)
        {
            testarConexao();
        }


        void Limpar()
        {
            txtCodigo.Text = "";
            mtbDataC.Text = "";
            txtNomeDepartamento.Text = "";
            cboStatus.SelectedIndex = -1;
            txtArea.Text = "";
            txtDescricao.Text = "";
            txtObs.Text = "";
            txtCodigo.Focus();
        }

        private bool validar()
        {


            if (txtNomeDepartamento.Text == "")
            {
                MessageBox.Show("Erro, Preencha o Campo Nome do Departamento");
                txtNomeDepartamento.Text = "";
                txtNomeDepartamento.Focus();
                return false;
            }
            if (cboStatus.Text == "")
            {
                MessageBox.Show("Erro, Preencha o campo Status do Departamento");
                cboStatus.SelectedIndex = -1;
                cboStatus.Focus();
                return false;
            }

            if (txtArea.Text == "")
            {
                MessageBox.Show("Erro, Preencha o campo Descrição do Departamento");
                txtArea.Text = "";
                txtArea.Focus();
                return false;
            }



            return true;
        }



        private void btoSair_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void btoPesquisar_Click(object sender, EventArgs e)
        {
            string sql = "select * from departamento where id_departamento=" + txtCodigo.Text;

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            SqlDataReader Reader;
            conexao.Open();
            try
            {
                Reader = cmd.ExecuteReader();
                if (Reader.Read())
                {   
                    mtbDataC.Text = Reader[1].ToString();
                    cboStatus.SelectedItem = Reader[2].ToString();
                    txtNomeDepartamento.Text = Reader[3].ToString();
                    txtArea.Text = Reader[4].ToString();
                    
                    txtDescricao.Text = Reader[5].ToString();
                    txtObs.Text = Reader[6].ToString();
                }
                else
                {
                    MessageBox.Show("Codigo de Departamento Invalido!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btoCadastrar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                string sql = "insert into departamento" +
    "(" +
    " nome_departamento," +
    " status_departamento," +
    " area_departamento," +
    " descricao_departamento," +
    " Obs_departamento" +
    ")" +
    " values" +
    "(" +  
    "'" + txtNomeDepartamento.Text + "'," +   
    "'" + cboStatus.SelectedItem + "'," +
    "'" + txtArea.Text + "'," +
    "'" + txtDescricao.Text + "'," +
    "'" + txtObs.Text + "'" +
    ")";
                SqlConnection conn = new SqlConnection(stringConexao);
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Departamento Cadastrado com sucesso");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btoAlterar_Click_1(object sender, EventArgs e)
        {
            if (validar())
            {

                string sql = "update Departamento set" +
               " status_departamento= '" + cboStatus.SelectedItem + "'," +
               " nome_departamento= '" + txtNomeDepartamento.Text + "'," +
               " area_departamento= '" + txtArea.Text + "'," +
               " descricao_departamento= '" + txtDescricao.Text + "'," +
               " Obs_departamento= '" + txtObs.Text + "'" +
               " where id_departamento= " + txtCodigo.Text;



                SqlConnection conexao = new SqlConnection(stringConexao);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.CommandType = CommandType.Text;

                try
                {
                    conexao.Open();

                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Dados alterados com sucesso.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void btoExcluir_Click_1(object sender, EventArgs e)
        {
            string sql = "delete from departamento where id_departamento= " + txtCodigo.Text;


            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;

            try
            {
                conexao.Open();
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show(" Area do Departamento excluido com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void pictureBoxFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


    }
}
