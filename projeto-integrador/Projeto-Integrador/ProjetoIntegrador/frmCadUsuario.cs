using System.Data;
using System.Data.SqlClient;
namespace ProjetoIntegrador
{
    public partial class frmCadUsuario : Form
    {
        //string stringConexao = frmLogin.stringConexao;

        string stringConexao = frmLogin.stringConexao;

        public frmCadUsuario()
        {
            InitializeComponent();
        }
        private void testarconexao()
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

        private void CadUsuario_Load(object sender, EventArgs e)
        {
            testarconexao();
            ComboBox();
        }



        private void ComboBox()
        {
            string sql = "select id_departamento, nome_departamento from Departamento";
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

                cboDepart.DisplayMember = "nome_departamento";
                cboDepart.DataSource = tabela;


                cboIDdepart.DisplayMember = "id_departamento";
                cboIDdepart.DataSource = tabela;

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




            private bool Validar()
        {
            if (cboStatus.Text == "")
            {
                MessageBox.Show("Erro, o campo Status deve ser preenchido");
                cboStatus.SelectedIndex = -1;
                cboStatus.Focus();
                return false;
            }

            if (txtNome.Text == "")
            {
                MessageBox.Show("Erro, o campo Nome deve ser preenchido");
                txtNome.Text = "";
                txtNome.Focus();
                return false;
            }

            if (mtbCPF.MaskFull == false)
            {
                MessageBox.Show("Erro, o CPF deve ser informado");
                mtbCPF.Text = "";
                mtbCPF.Focus();
                return false;
            }

            if (txtLogin.Text == "")
            {
                MessageBox.Show("Erro, um Login deve ser criado");
                txtLogin.Text = "";
                txtLogin.Focus();
                return false;
            }

            if (txtSenha.Text == "")
            {
                MessageBox.Show("Erro, um Login deve ser criado");
                txtSenha.Text = "";
                txtSenha.Focus();
                return false;
            }

            if (mtbCEP.MaskFull == false)
            {
                MessageBox.Show("Erro, informe o CEP ");
                mtbCEP.Text = "";
                mtbCEP.Focus();
                return false;
            }

            if (txtLogradouro.Text == "")
            {
                MessageBox.Show("Erro, um Login deve ser criado");
                txtLogradouro.Text = "";
                txtLogradouro.Focus();
                return false;
            }





            return true;
        }







        private void btoSair_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void btoCadastro_Click_1(object sender, EventArgs e)
        {
            if (Validar())
            {
                string sql = "insert into Usuario  " +
        "(" +

     "Status_Usuario," +
     "nome_Usuario," +
     "CPF_Usuario," +
     "Login_Usuario," +
     "Senha_Usuario," +
     "id_departamento_Usuario," +
     "cep_Usuario," +
     "logradouro_Usuario," +
     "Numero_Usuario," +
     "bairro_Usuario," +
     "cidade_Usuario," +
     "uf_Usuario," +
     "Complemento_Usuario," +
     "telefone1_Usuario," +
     "telefone2_Usuario," +
     "email_Usuario," +
     "Obs_Usuario" +

    ")" +
        "Values" +
        "(" +
        "'" + cboStatus.SelectedItem + "'," +
        "'" + txtNome.Text + "'," +
        "'" + mtbCPF.Text + "'," +
        "'" + txtLogin.Text + "'," +
        "'" + txtSenha.Text + "'," +
        "'" + cboIDdepart.Text + "'," +
        "'" + mtbCEP.Text + "'," +
        "'" + txtLogradouro.Text + "'," +
        "'" + mtbNumero.Text + "'," +
        "'" + txtBairro.Text + "'," +
        "'" + txtCity.Text + "'," +
        "'" + cboUF.Text + "'," +
        "'" + txtComple.Text + "'," +
        "'" + mtbTel1.Text + "'," +
        "'" + mtbTel2.Text + "'," +
        "'" + txtEmail.Text + "'," +
        "'" + txtObs.Text + "'" +

        ")" + "Select SCOPE_Identity()";
                SqlConnection conn = new SqlConnection(stringConexao);
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader leitura;
                conn.Open();

                try
                {
                    leitura = cmd.ExecuteReader();
                    if (leitura.Read())
                    {
                        MessageBox.Show("Cadastro realizado com sucesso", "Código Gerado:" + leitura[0].ToString());
                        
                        mtbDataC.Text = leitura[1].ToString();
                        cboStatus.Text = leitura[2].ToString();
                        txtNome.Text = leitura[3].ToString();
                        mtbCPF.Text = leitura[4].ToString();
                        txtLogin.Text = leitura[5].ToString();
                        txtSenha.Text = leitura[6].ToString();
                        cboIDdepart.SelectedItem = leitura[7].ToString();
                        mtbCEP.Text = leitura[8].ToString();
                        txtLogradouro.Text = leitura[9].ToString();
                        mtbNumero.Text = leitura[10].ToString();
                        txtBairro.Text = leitura[11].ToString();
                        txtCity.Text = leitura[12].ToString();
                        cboUF.SelectedItem = leitura[13].ToString();
                        txtComple.Text = leitura[14].ToString();
                        mtbTel1.Text = leitura[15].ToString();
                        mtbTel2.Text = leitura[16].ToString();
                        txtEmail.Text = leitura[17].ToString();
                        txtObs.Text = leitura[18].ToString();

                        btoPesquisa.PerformClick();
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

        private void btoAlterar_Click(object sender, EventArgs e)
        {
            string sql = "update Usuario set " +

"Status_Usuario= '" + cboStatus.Text + "'," +
"nome_Usuario= '" + txtNome.Text + "'," +
"CPF_Usuario= '" + mtbCPF.Text + "'," +
"Login_Usuario= '" + txtLogin.Text + "'," +
"Senha_Usuario= '" + txtSenha.Text + "'," +
"id_departamento_Usuario= '" + cboIDdepart.Text + "'," +
"cep_Usuario= '" + mtbCEP.Text + "'," +
"logradouro_Usuario= '" + txtLogradouro.Text + "'," +
"Numero_Usuario= '" + mtbNumero.Text + "'," +
"bairro_Usuario= '" + txtBairro.Text + "'," +
"cidade_Usuario= '" + txtCity.Text + "'," +
"uf_Usuario= '" + cboUF.Text + "'," +
"Complemento_Usuario= '" + txtComple.Text + "'," +
"telefone1_Usuario= '" + mtbTel1.Text + "'," +
"telefone2_Usuario= '" + mtbTel2.Text + "'," +
"email_Usuario= '" + txtEmail.Text + "'," +
"Obs_Usuario= '" + txtObs.Text + "'" +

"Where id_Usuario = " + txtCodigo.Text;

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;


            try
            {
                conexao.Open();
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Dados Alterados com sucesso");
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
            txtCodigo.Text = "";
            mtbDataC.Text = "";
            cboStatus.SelectedIndex = -1;
            txtNome.Text = "";
            mtbCPF.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
            cboIDdepart.Text = "";
            cboDepart.SelectedIndex = -1;
            mtbCEP.Text = "";
            txtLogradouro.Text = "";
            mtbNumero.Text = "";
            txtBairro.Text = "";
            txtCity.Text = "";
            cboUF.SelectedIndex = -1;
            txtComple.Text = "";
            mtbTel1.Text = "";
            mtbTel2.Text = "";
            txtEmail.Text = "";
            txtObs.Text = "";
        }

        private void btoPesquisa_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "")
            {
                frmGridUsuario user = new frmGridUsuario();
                user.ShowDialog();
                txtCodigo.Text = user._codigo.ToString();
                
            }

            string sql = "select * from Usuario where id_Usuario =" + txtCodigo.Text;

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            conexao.Open();

            try
            {
                leitura = cmd.ExecuteReader();
                if (leitura.Read())
                {

                    mtbDataC.Text = leitura[1].ToString();
                    cboStatus.Text = leitura[2].ToString();
                    txtNome.Text = leitura[3].ToString();
                    mtbCPF.Text = leitura[4].ToString();
                    txtLogin.Text = leitura[5].ToString();
                    txtSenha.Text = leitura[6].ToString();
                    cboIDdepart.Text = leitura[7].ToString();
                    mtbCEP.Text = leitura[8].ToString();
                    txtLogradouro.Text = leitura[9].ToString();
                    mtbNumero.Text = leitura[10].ToString();
                    txtBairro.Text = leitura[11].ToString();
                    txtCity.Text = leitura[12].ToString();
                    cboUF.SelectedItem = leitura[13].ToString();
                    txtComple.Text = leitura[14].ToString();
                    mtbTel1.Text = leitura[15].ToString();
                    mtbTel2.Text = leitura[16].ToString();
                    txtEmail.Text = leitura[17].ToString();
                    txtObs.Text = leitura[18].ToString();


                }
                else
                {
                    MessageBox.Show("Código de Usuário inexistente");
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

        private void mtbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pcbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcbMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
            pcbMaximizar.Visible = true;
        }

        private void pcbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            
            pictureBox1.Visible = true;
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

