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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
       
        }
        public static string stringConexao = "" +
           "Data Source= localhost ;" +
           "Initial Catalog=ProjetoIntegradorT_13;" +
           "User ID=sa;" +
           "Password=123456";

        public void testarconexao()
        {
            SqlConnection conn = new SqlConnection(stringConexao);

            try
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            testarconexao();
            ComboBox();
        }
        public static string IDUsuario = "";
        public static string NomeUsuario = "";
        public static string LoginUsuario = "";
        public static string idDepartamento = "";

        private void ComboBox()
        {
            string sql = "select id_departamento,nome_departamento from Departamento";
            SqlConnection con = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;

            DataTable tabela = new DataTable();
            con.Open();

            try
            {
                reader = cmd.ExecuteReader();
                tabela.Load(reader);

                cboDepartamento.DisplayMember = "nome_departamento";
                cboDepartamento.DataSource = tabela;


                cboIDdepartamento.DisplayMember = "id_departamento";
                cboIDdepartamento.DataSource = tabela;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro - " + ex.ToString());
                Application.Exit();
            }
            finally
            {
                con.Close();
            }

      
    }



        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtSenha.Text = "";
            cboDepartamento.Text = "";
            cboIDdepartamento.Text = "";
        }

        private void btoEntrar_Click(object sender, EventArgs e)
        {
            Boolean Valida = false;
            string Sql = "select * from Usuario where " +
            "login_Usuario = '" + txtLogin.Text + "' and " +
            "id_departamento_Usuario = '" + cboIDdepartamento.Text + "' and " +
            "senha_Usuario = '" + txtSenha.Text + "'"; SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(Sql, conexao);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            conexao.Open();
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Valida = true;

                    MessageBox.Show("Login feito");
                    MDIDepart frm = new MDIDepart();
                    this.Hide();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos");
                    txtLogin.Text = "";
                    txtSenha.Text = "";
                    txtLogin.Focus();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
