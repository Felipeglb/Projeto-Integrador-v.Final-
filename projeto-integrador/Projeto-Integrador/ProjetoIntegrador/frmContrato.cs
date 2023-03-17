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
    public partial class frmContrato : Form
    {
        string stringconexao = "data source=localhost; initial catalog=ProjetoIntegradorT_13; user ID=sa; password=123456";


        private void testarconexao()
        {

            SqlConnection conn = new SqlConnection(stringconexao);

            try
            {
                conn.Open();
                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("erro: " + ex.ToString());
                Application.Exit();
            }


        }

        public frmContrato()
        {
            InitializeComponent();
            testarconexao();
        }

        private void frmContrato_Load(object sender, EventArgs e)
        {

        }


      

        private void dtpEmissao_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btoPesquisar_Click(object sender, EventArgs e)
        {
            if (validar3())
            {





                //string sql = "select * from Contrato where id_parceiro_contrato = " + txtIdParceiro.Text;


                /*string sql = "select pa.nome_Parceiro, pl.nome_planos from Parceiro as pa " +
                                 "inner join  planos as pl on pa.id_Parceiro = pl.id_planos" +
                                 "where id_parceiro_contrato = " + txtIdParceiro.Text;
                */

                string sql = "select co.id_parceiro_contrato, pa.CNPJ_Parceiro,pa.nome_Parceiro from Contrato as co inner join parceiro as pa on id_parceiro_contrato = id_Parceiro where co.id_parceiro_contrato =" + txtIdParceiro.Text;

                SqlConnection conexao = new SqlConnection(stringconexao);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader;
                conexao.Open();

                try
                {
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {

                        txtIdParceiro.Text = reader[0].ToString();
                        txtCnpj.Text = reader[1].ToString();
                        txtNomeParceiro.Text = reader[2].ToString();




                    }


                    else
                    {
                        MessageBox.Show("Categoria inexistente");
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

        private bool validarbotoes1()
        {
            if (txtIdPlano.Text == "")
            {
                MessageBox.Show("erro, preencha o campo Id plano para poder pesquisar ", "Ifood de PC");
                txtIdPlano.Text = "";
                txtIdPlano.Focus();
                return false;

            }
            return true;


        }


        private void btoPesquisar2_Click(object sender, EventArgs e)
        {

            if (validarbotoes1())
            {






                string vCusto = txtValorPlano.Text;
                //R$ 1.000,00
                vCusto = vCusto.Replace("R$ ", ""); //1.000,00
                vCusto = vCusto.Replace(".", ""); //1000,00
                vCusto = vCusto.Replace(',', '.');//1000.00             
                                                  //R$ 1.000,00




                //string sql = "select * from Contrato where id_parceiro_contrato = " + txtIdParceiro.Text;


                /*string sql = "select pa.nome_Parceiro, pl.nome_planos from Parceiro as pa " +
                                 "inner join  planos as pl on pa.id_Parceiro = pl.id_planos" +
                                 "where id_parceiro_contrato = " + txtIdParceiro.Text;
                */

                string sql = "select  co.id_planos_contrato, pl.nome_planos, pl.preço_planos, pl.Tipo_planos from planos as pl inner join contrato as co on id_planos_contrato = id_planos where co.id_planos_contrato = " + txtIdPlano.Text;

                SqlConnection conexao = new SqlConnection(stringconexao);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader;
                conexao.Open();

                try
                {
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {


                        txtNomePlano.Text = reader[1].ToString();
                        txtValorPlano.Text = reader[2].ToString();
                        txtValorPlano.Text = string.Format("R$ {0:0,0.00}", Convert.ToDecimal(txtValorPlano.Text));
                        txtTipoPlano.Text = reader[3].ToString();





                    }


                    else
                    {
                        MessageBox.Show("Categoria inexistente");
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

        private void btoCadastrar_Click(object sender, EventArgs e)
        {
            if (validar())
            {


                string date1 = (dtpEmissao.Value.ToString());
                string date2 = (dtpTermino.Value.ToString());




                string vCusto = txtValorPlano.Text;
                //R$ 1.000,00
                vCusto = vCusto.Replace("R$ ", ""); //1.000,00
                vCusto = vCusto.Replace(".", ""); //1000,00
                vCusto = vCusto.Replace(',', '.');//1000.00

                string sql = "insert into contrato" +
                     "(" +
                     "id_planos_contrato," +
                     "id_parceiro_contrato," +
                    "DatadeEmissão_contrato," +
                    "DataTérmino_contrato" +
                    ")" +
                    "values" +
                    "(" +
                    "'" + txtIdPlano.Text + "'," +
                    "'" + txtIdParceiro.Text + "'," +
                    "'" + date1 + "'," +
                    "'" + date2 + "'" +
                    ")";

                SqlConnection conn = new SqlConnection(stringconexao);
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Cadastro realizado com sucesso");

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

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtCnpj.Text = "";
            txtIDcontrato.Text = "";
            txtIdParceiro.Text = "";
            txtIdPlano.Text = "";
            txtNomeParceiro.Text = "";
            txtNomePlano.Text = "";
            txtTipoPlano.Text = "";
            txtValorPlano.Text = "";
            dtpEmissao.Value = DateTime.Now;
            dtpTermino.Value = DateTime.Now;

        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void btoPesquisa6_Click(object sender, EventArgs e)
        {

            if (validar4())
            {





                string vCusto = txtValorPlano.Text;
                //R$ 1.000,00
                vCusto = vCusto.Replace("R$ ", ""); //1.000,00
                vCusto = vCusto.Replace(".", ""); //1000,00
                vCusto = vCusto.Replace(',', '.');//1000.00             
                                                  //R$ 1.000,00

                string date1 = (dtpEmissao.Value.ToString());
                string date2 = (dtpTermino.Value.ToString());




                //string sql = "select * from Contrato where id_parceiro_contrato = " + txtIdParceiro.Text;


                /*string sql = "select pa.nome_Parceiro, pl.nome_planos from Parceiro as pa " +
                                 "inner join  planos as pl on pa.id_Parceiro = pl.id_planos" +
                                 "where id_parceiro_contrato = " + txtIdParceiro.Text;
                */

                string sql = "select contrato.id_parceiro_contrato,parceiro.CNPJ_Parceiro, parceiro.nome_parceiro,planos.nome_planos, planos.preço_planos, planos.tipo_planos, planos.id_planos, contrato.DatadeEmissão_contrato, contrato.DataTérmino_contrato from contrato inner join parceiro on parceiro.id_Parceiro = contrato.id_parceiro_contrato inner join planos on planos.id_planos = contrato.id_planos_contrato where id_contrato =" + txtIDcontrato.Text;
                SqlConnection conexao = new SqlConnection(stringconexao);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader;
                conexao.Open();

                try
                {
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {


                        txtCnpj.Text = reader[1].ToString();
                        txtNomeParceiro.Text = reader[2].ToString();
                        txtIdParceiro.Text = reader[0].ToString();
                        txtValorPlano.Text = reader[4].ToString();
                        txtValorPlano.Text = string.Format("R$ {0:0,0.00}", Convert.ToDecimal(txtValorPlano.Text));
                        txtNomePlano.Text = reader[3].ToString();
                        txtTipoPlano.Text = reader[5].ToString();
                        txtIdPlano.Text = reader[6].ToString();






                    }


                    else
                    {
                        MessageBox.Show("Categoria inexistente");
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

        private bool validar()
        {

            if (txtCnpj.Text == "")
            {
                MessageBox.Show("erro, preencha o campo CNPJ", "Ifood de PC");
                txtCnpj.Text = "";
                txtCnpj.Focus();
                return false;

            }
            if (txtIdParceiro.Text == "")
            {
                MessageBox.Show("erro, preencha o Id Parceiro", "Ifood de PC");
                txtIdParceiro.Text = "";
                txtIDcontrato.Focus();
                return false;

            }
            if (txtIdPlano.Text == "")
            {
                MessageBox.Show("erro, preencha o campo ID Plano", "Ifood de PC");
                txtIdPlano.Text = "";
                txtIdPlano.Focus();
                return false;

            }
            if (txtNomeParceiro.Text == "")
            {
                MessageBox.Show("erro, preencha o campo Nome Parceiro", "Ifood de PC");
                txtNomeParceiro.Text = "";
                txtNomeParceiro.Focus();
                return false;

            }
            if (txtNomePlano.Text == "")
            {
                MessageBox.Show("erro, preencha o campo Nome Plano", "Ifood de PC");
                txtNomePlano.Text = "";
                txtNomePlano.Focus();
                return false;

            }
            if (txtTipoPlano.Text == "")
            {
                MessageBox.Show("erro, preencha o campo Tipo Plano", "Ifood de PC");
                txtTipoPlano.Text = "";
                txtTipoPlano.Focus();
                return false;

            }
            if (txtValorPlano.Text == "")
            {
                MessageBox.Show("erro, preencha o campo Nome", "Ifood de PC");
                txtValorPlano.Text = "";
                txtValorPlano.Focus();
                return false;

            }
            return true;


        }

        private void txtValorPlano_Enter(object sender, EventArgs e)
        {
            if (txtValorPlano.Text != "")
            {
                txtValorPlano.Text = txtValorPlano.Text.Substring(3, txtValorPlano.Text.Length - 3);
            }
        }
        decimal i;
        private void txtValorPlano_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtValorPlano.Text, out i))
            {
                txtValorPlano.Text = string.Format("R$ {0:0,0.00}", Convert.ToDecimal(txtValorPlano.Text));

            }
        }


        private bool validar3()
        {


            if (txtIdParceiro.Text == "")
            {
                MessageBox.Show("erro, preencha o Id Parceiro para poder Pesquisar", "Ifood de PC");
                txtIdParceiro.Text = "";
                txtIdParceiro.Focus();
                return false;




            }
            return true;

        }

        private  bool validar4()
        {

            if (txtIDcontrato.Text == "")
            {
                MessageBox.Show("erro, preencha o Id Parceiro", "Ifood de PC");
                txtIDcontrato.Text = "";
                txtIDcontrato.Focus();
                return false;




            }
            return true;


        }

        private void pictureBoxFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void txtIdPlano_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


 

