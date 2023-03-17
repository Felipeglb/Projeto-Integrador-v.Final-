using System.Data;
using System.Data.SqlClient;


namespace ProjetoIntegrador
{
  
    public partial class frmParceiro : Form
    {

        string stringconexao = "data source=localhost; initial catalog=ProjetoIntegradorT_13; user ID=sa; password=123456";
        public frmParceiro()
        {
            InitializeComponent();
            testarconexao();
            cboStatus.SelectedIndex = 0;
        }
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

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            testarconexao();
            cboStatus.SelectedIndex = 0;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void btoSair_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtBairro.Text = "";
            mtbCep.Text = "";
            txtCidade.Text = "";
            mtbCnpj.Text = "";
            txtEmail.Text = "";
            txtID.Text = "";
            txtLogin.Text = "";
            txtLogradouro.Text = "";
            txtNome.Text = ""; 
            txtObservacao.Text = "";
            txtSenha.Text = "";
            mtbTelefone1.Text = "";
            mtbTelefone2.Text = "";
            txtTipoServico.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            mtbHorario.Text = "";

            cboStatus.SelectedIndex = 0;
            cboUF.SelectedIndex = -1;
            cboEspecialidade.SelectedIndex = -1;

        }
        private bool validar()
        {
            

            if (txtNome.Text == "")
            {
                MessageBox.Show("erro, preencha o campo Nome", "Ifood de PC");
                txtNome.Text = "";
                txtNome.Focus();
                return false;

            }
            if (mtbCnpj.MaskFull == false)
            {
                MessageBox.Show("erro, preencha o campo CNPJ", "Ifood de PC");
                mtbCnpj.Text = "";
                mtbCnpj.Focus();
                return false;

            }
            if (txtLogin.Text == "")
            {
                MessageBox.Show("erro, preencha o campo Login", "Ifood de PC");
                txtLogin.Text = "";
                txtLogin.Focus();
                return false;

            }
            if (txtSenha.Text == "")
            {
                MessageBox.Show("erro, preencha o campo Senha", "Ifood de PC");
                txtSenha.Text = "";
                txtSenha.Focus();
                return false;

            }
            if (cboEspecialidade.Text == "")
            {
                MessageBox.Show("erro, preencha o campo Especialidade", "Ifood de PC");
                cboEspecialidade.SelectedIndex = -1;
                cboEspecialidade.Focus();
                return false;

            }
            if (txtTipoServico.Text == "")
            {
                MessageBox.Show("erro, preencha o campo Tipo de Serviço","Ifood de PC");
                txtTipoServico.Text = "";
                txtTipoServico.Focus();
                return false;

            }
            if (mtbCep.MaskFull == false)
            {
                MessageBox.Show("erro, preencha o campo CEP", "Ifood de PC");
                mtbCep.Text = "";
                mtbCep.Focus();
                return false;

            }
            if (txtLogradouro.Text == "")
            {
                MessageBox.Show("erro, preencha o campo Logradouro", "Ifood de PC");
                txtLogradouro.Text = "";
                txtLogradouro.Focus();
                return false;

            }
            if (txtBairro.Text == "")
            {
                MessageBox.Show("erro, preencha o campo Bairro", "Ifood de PC");
                txtBairro.Text = "";
                txtBairro.Focus();
                return false;
                
            }
            if (txtCidade.Text == "")
            {
                MessageBox.Show("erro, preencha o campo Cidade", "Ifood de PC");
                txtCidade.Text = "";
                txtCidade.Focus();
                return false;

            }
            if (cboUF.Text == "")
            {
                MessageBox.Show("erro, preencha o campo UF", "Ifood de PC");
                cboUF.SelectedIndex = -1;
                cboUF.Focus();
                return false;

            }

            if (mtbTelefone1.MaskFull == false)
            {
                MessageBox.Show("erro, preencha o campo Telefone", "Ifood de PC");
                mtbTelefone1.Text = "";
                mtbTelefone1.Focus();
                return false;

            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("erro, preencha o campo Email", "Ifood de PC");
                txtEmail.Text = "";
                txtEmail.Focus();
                return false;

            }
            if (txtNumero.Text =="")
            {
                MessageBox.Show("erro, preencha o campo Numero", "Ifood de PC");
                txtNumero.Text = "";
                txtNumero.Focus();
                return false;

            }
          
            if (mtbHorario.MaskFull == false)
            {
                MessageBox.Show("erro, preencha o campo Horario de Funcionamento", "Ifood de PC");
                mtbHorario.Text = "";
                mtbHorario.Focus();
                return false;

            }

            return true;


        }

        private void btoCadastrar_Click(object sender, EventArgs e)
        {
            if (validar())
            {


                //cadastro Parceiro
                string sql = "insert into Parceiro" +
                    "(" +

                        "status_parceiro," +
                        "nome_Parceiro," +
                        "CNPJ_Parceiro," +
                        "Login_Parceiro," +
                        "Senha_Parceiro," +
                        "Especialidade_Parceiro," +
                        "TipoServico_Parceiro," +
                        "cep_Parceiro," +
                        "logradouro_Parceiro," +
                        "Numero_parceiro," +
                        "bairro_Parceiro," +
                        "cidade_Parceiro," +
                        "uf_Parceiro," +
                        "Complemento_parceiro," +
                        "HorarioFuncionamento_Parceiro," +
                        "telefone1_Parceiro," +
                        "telefone2_Parceiro," +
                        "email_Parceiro," +
                        "Descricao_Parceiro" +




                        ")" +

                    "values" +

                         "(" +
                            "'" + cboStatus.Text + "'," +
                            "'" + txtNome.Text + "'," +
                            "'" + mtbCnpj.Text + "'," +
                            "'" + txtLogin.Text + "'," +
                            "'" + txtSenha.Text + "'," +
                            "'" + cboEspecialidade.Text + "'," +
                            "'" + txtTipoServico.Text + "'," +
                            "'" + mtbCep.Text + "'," +
                            "'" + txtLogradouro.Text + "'," +
                            "'" + txtNumero.Text + "'," +
                            "'" + txtBairro.Text + "'," +
                            "'" + txtCidade.Text + "'," +
                            "'" + cboUF.Text + "'," +
                            "'" + txtComplemento.Text + "'," +
                            "'" + mtbHorario.Text + "'," +
                            "'" + mtbTelefone1.Text + "'," +
                            "'" + mtbTelefone2.Text + "'," +
                            "'" + txtEmail.Text + "'," +
                            "'" + txtObservacao.Text + "'" +

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

        private void txtCnpj_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


    }
}