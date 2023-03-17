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
using System.Data.SqlClient;

namespace ProjetoIntegrador
{
   
    public partial class frmPlanos : Form
    {
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
                MessageBox.Show("Erro: " + ex.ToString());
                Application.Exit();
            }
        }
        public frmPlanos()
        {
            InitializeComponent();
        }
        string stringConexao = frmLogin.stringConexao;

        private void Form1_Load(object sender, EventArgs e)
        {
            TestarConexao();
        }

        private bool Validar()
        {


            if (mtbDatacadastro.Text == "")
            {
                MessageBox.Show("Erro, o campo Data de Cadastro deve ser preenchido", "Ifood de PC");
                mtbDatacadastro.Text = "";
                mtbDatacadastro.Focus();
                return false;
            }

            if (txtNome.Text == "")
            {
                MessageBox.Show("Erro, o campo Nome deve ser preenchido", "Ifood de PC");
                txtNome.Text = "";
                txtNome.Focus();
                return false;
            }

            if (txtPreco.Text == "")
            {
                MessageBox.Show("Erro, o campo Preço deve ser preenchido", "Ifood de PC");
                txtPreco.Text = "";
                txtPreco.Focus();
                return false;
            }

            if (txtBeneficios.Text == "")
            {
                MessageBox.Show("Erro, o campo Benefícios deve ser preenchido", "Ifood de PC");
                txtBeneficios.Text = "";
                txtBeneficios.Focus();
                return false;
            }

            if (txtDescricao.Text == "")
            {
                MessageBox.Show("Erro, o campo Descrição deve ser preenchido", "Ifood de PC");
                txtDescricao.Text = "";
                txtDescricao.Focus();
                return false;
            }

            if (cboTipo.Text == "")
            {
                MessageBox.Show("Erro, o campo Tipo deve ser preenchido", "Ifood de PC");
                cboTipo.Text = "";
                cboTipo.Focus();
                return false;
            }

            if (cboDataduracao.Text == "")
            {
                MessageBox.Show("Erro, o campo Data de Duração deve ser preenchido", "Ifood de PC");
                cboDataduracao.Text = "";
                cboDataduracao.Focus();
                return false;
            }

            return true;
        }




        private void btoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtBeneficios.Text = "";
            txtDescricao.Text = "";
            txtID.Text = "";
            txtNome.Text = "";
            txtPreco.Text = "";
            cboTipo.Text = "";
            mtbDatacadastro.Text = "";
            cboDataduracao.Text = "";
        }

        private void btoCadastrar_Click(object sender, EventArgs e)
        {
            string vCusto = txtPreco.Text;
            //R$ 1.000,00
            vCusto = vCusto.Replace("R$ ", ""); //1.000,00
            vCusto = vCusto.Replace(".", ""); //1000,00
            vCusto = vCusto.Replace(',', '.');//1000.00
            if (Validar())

            {
                string sql = "insert into Planos " +
                        "(" +
                        "DataCadastro_Planos," +
                        "nome_Planos," +
                        "Tipo_Planos," +
                        "preço_Planos," +
                        "beneficios_Planos," +
                        "descricao_Planos," +
                        "DataDuracao_Planos" +
                        ")" +
                        "Values" +
                        "(" +
                        "getdate()," +
                        "'" + txtNome.Text + "'," +
                        "'" + cboTipo.Text + "'," +
                        "'" + vCusto + "'," +
                        "'" + txtBeneficios.Text + "'," +
                        "'" + txtDescricao.Text + "'," +
                        "'" + cboDataduracao.Text + "'" +

                        ")" + "Select SCOPE_Identity()";
                SqlConnection conn = new SqlConnection(stringConexao);
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader;
                conn.Open();

                try
                {
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtID.Text = reader[0].ToString();

                        MessageBox.Show("Cadastro realizado com sucesso", "Código Gerado:" + reader[0].ToString());
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


       // private void txtPreco_Enter(object sender, EventArgs e)
        //{
            //txtPreco.Text = txtPreco.Text.Replace("R$ ", "");
        //}



        private void btoAlterar_Click(object sender, EventArgs e)
        {
            string vCusto = txtPreco.Text;
            //R$ 1.000,00
            vCusto = vCusto.Replace("R$ ", ""); //1.000,00
            vCusto = vCusto.Replace(".", ""); //1000,00
            vCusto = vCusto.Replace(',', '.');//1000.00



            if (Validar())
            {
                string sql = "update Planos set " +
                       "nome_Planos = " + "'" + txtNome.Text + "'," +
                       "Tipo_Planos= " + "'" + cboTipo.Text + "'," +
                       "preço_Planos= " + "'" + vCusto + "'," +
                       "beneficios_Planos= " + "'" + txtBeneficios.Text + "'," +
                       "descricao_Planos= " + "'" + txtDescricao.Text + "'," +
                       "DataDuracao_Planos= " + "'" + cboDataduracao.Text + "'" +
                       "Where id_Planos = " + txtID.Text;

              

                SqlConnection conn = new SqlConnection(stringConexao);
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {


                        MessageBox.Show("Alteração realizado com sucesso", "Ifood de PC");
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

        private void btoPesquisar_Click(object sender, EventArgs e)
        {

          //  if (txtID.Text.Trim() == "")
           // {
              //  frmProdutoPesquisa dor = new frmProdutoPesquisa();
              //  dor.ShowDialog();
              //  txtCodigo.Text = dor._codigo;
           // }
            string sql = "select * from Planos where id_Planos =" + txtID.Text;

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            conexao.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtNome.Text = reader[2].ToString();

                    txtPreco.Text = reader[4].ToString();
                    string test = txtPreco.Text;
                    txtPreco.Text = String.Format("{0:C}", float.Parse(txtPreco.Text));

                    //txtValorV.Text = reader[3].ToString();
                    //txtValorV.Text = String.Format("{0:C}", float.Parse(txtValorV.Text));

                    mtbDatacadastro.Text = reader[1].ToString();
                    cboTipo.Text = reader[3].ToString();
                    cboDataduracao.Text = reader[7].ToString();
                    txtDescricao.Text = reader[6].ToString();
                    txtBeneficios.Text = reader[5].ToString();
                }
                else
                {
                    MessageBox.Show("Código de Produto inexistente");
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

        private void txtPreco_Leave_1(object sender, EventArgs e)
        {
            float vCusto;
            if (!float.TryParse(txtPreco.Text, out vCusto) && txtPreco.Text.Trim() != "")
            {
                MessageBox.Show("Erro. Valor de custo deve ser numérico e sem formato.");
                txtPreco.Text = "";
                txtPreco.Focus();
                return;
            }
            else if (txtPreco.Text.Trim() == "")
            {
                txtPreco.Text = "";
                return;
            }

            txtPreco.Text = String.Format("{0:C}", vCusto);
        }

        private void txtPreco_Enter_1(object sender, EventArgs e)
        {
            txtPreco.Text = txtPreco.Text.Replace("R$ ", "");
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
    
