namespace ProjetoIntegrador
{
    partial class frmCadUsuario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadUsuario));
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btoPesquisa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboIDdepart = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.mtbTel1 = new System.Windows.Forms.MaskedTextBox();
            this.mtbTel2 = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.mtbDataC = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtbNumero = new System.Windows.Forms.MaskedTextBox();
            this.cboDepart = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtComple = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btoSair = new System.Windows.Forms.Button();
            this.btoLimpar = new System.Windows.Forms.Button();
            this.btoCadastro = new System.Windows.Forms.Button();
            this.btoAlterar = new System.Windows.Forms.Button();
            this.pnlEmcima = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcbMinimizar = new System.Windows.Forms.PictureBox();
            this.pcbMaximizar = new System.Windows.Forms.PictureBox();
            this.pcbFechar = new System.Windows.Forms.PictureBox();
            this.pictureBoxFechar = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.pnlEmcima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(0, 25);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(113, 29);
            this.txtCodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Ativo",
            "Demitido",
            "Suspenso"});
            this.cboStatus.Location = new System.Drawing.Point(902, 32);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(139, 29);
            this.cboStatus.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(902, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status";
            // 
            // btoPesquisa
            // 
            this.btoPesquisa.Location = new System.Drawing.Point(121, 25);
            this.btoPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.btoPesquisa.Name = "btoPesquisa";
            this.btoPesquisa.Size = new System.Drawing.Size(96, 29);
            this.btoPesquisa.TabIndex = 1;
            this.btoPesquisa.Text = "&Pesquisar";
            this.btoPesquisa.UseVisualStyleBackColor = true;
            this.btoPesquisa.Click += new System.EventHandler(this.btoPesquisa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(738, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "CPF";
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(738, 32);
            this.mtbCPF.Margin = new System.Windows.Forms.Padding(4);
            this.mtbCPF.Mask = "###.###.###-##";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(156, 29);
            this.mtbCPF.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(8, 30);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(355, 29);
            this.txtNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(230, 190);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Login";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(230, 214);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(187, 29);
            this.txtLogin.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(8, 190);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID Depart.";
            // 
            // cboIDdepart
            // 
            this.cboIDdepart.FormattingEnabled = true;
            this.cboIDdepart.Location = new System.Drawing.Point(8, 215);
            this.cboIDdepart.Margin = new System.Windows.Forms.Padding(4);
            this.cboIDdepart.Name = "cboIDdepart";
            this.cboIDdepart.Size = new System.Drawing.Size(76, 29);
            this.cboIDdepart.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(708, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(708, 99);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(186, 29);
            this.txtBairro.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(8, 68);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Logradouro";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(8, 99);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(355, 29);
            this.txtLogradouro.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(8, 132);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "Cidade";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(8, 157);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(260, 29);
            this.txtCity.TabIndex = 11;
            // 
            // cboUF
            // 
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cboUF.Location = new System.Drawing.Point(276, 157);
            this.cboUF.Margin = new System.Windows.Forms.Padding(4);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(87, 29);
            this.cboUF.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(276, 133);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "UF";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(371, 131);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 21);
            this.label14.TabIndex = 28;
            this.label14.Text = "Telefone1";
            // 
            // mtbTel1
            // 
            this.mtbTel1.Location = new System.Drawing.Point(371, 156);
            this.mtbTel1.Margin = new System.Windows.Forms.Padding(4);
            this.mtbTel1.Mask = "(##)#####-####";
            this.mtbTel1.Name = "mtbTel1";
            this.mtbTel1.Size = new System.Drawing.Size(166, 29);
            this.mtbTel1.TabIndex = 13;
            // 
            // mtbTel2
            // 
            this.mtbTel2.Location = new System.Drawing.Point(545, 157);
            this.mtbTel2.Margin = new System.Windows.Forms.Padding(4);
            this.mtbTel2.Mask = "(##)#####-####";
            this.mtbTel2.Name = "mtbTel2";
            this.mtbTel2.Size = new System.Drawing.Size(156, 29);
            this.mtbTel2.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(543, 131);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 21);
            this.label15.TabIndex = 30;
            this.label15.Text = "Telefone2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.mtbDataC);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btoPesquisa);
            this.groupBox1.Location = new System.Drawing.Point(13, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1051, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(902, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 21);
            this.label17.TabIndex = 8;
            this.label17.Text = "Data de Cadastro";
            // 
            // mtbDataC
            // 
            this.mtbDataC.Enabled = false;
            this.mtbDataC.Location = new System.Drawing.Point(902, 29);
            this.mtbDataC.Mask = "##/##/#### ##:##";
            this.mtbDataC.Name = "mtbDataC";
            this.mtbDataC.Size = new System.Drawing.Size(139, 29);
            this.mtbDataC.TabIndex = 7;
            this.mtbDataC.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.mtbNumero);
            this.groupBox2.Controls.Add(this.cboDepart);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cboIDdepart);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtSenha);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtComple);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtLogin);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.mtbCEP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboStatus);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cboUF);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCity);
            this.groupBox2.Controls.Add(this.mtbCPF);
            this.groupBox2.Controls.Add(this.mtbTel2);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.mtbTel1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtLogradouro);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtBairro);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(13, 135);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1051, 270);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // mtbNumero
            // 
            this.mtbNumero.Location = new System.Drawing.Point(370, 99);
            this.mtbNumero.Name = "mtbNumero";
            this.mtbNumero.Size = new System.Drawing.Size(87, 29);
            this.mtbNumero.TabIndex = 7;
            this.mtbNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbNumero_KeyPress);
            // 
            // cboDepart
            // 
            this.cboDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboDepart.FormattingEnabled = true;
            this.cboDepart.Location = new System.Drawing.Point(91, 214);
            this.cboDepart.Name = "cboDepart";
            this.cboDepart.Size = new System.Drawing.Size(132, 29);
            this.cboDepart.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(95, 190);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 21);
            this.label12.TabIndex = 25;
            this.label12.Text = "Departamento";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(425, 190);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 21);
            this.label20.TabIndex = 44;
            this.label20.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(425, 214);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(217, 29);
            this.txtSenha.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(708, 130);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 21);
            this.label19.TabIndex = 42;
            this.label19.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(708, 156);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(333, 29);
            this.txtEmail.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(463, 75);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 21);
            this.label18.TabIndex = 40;
            this.label18.Text = "Complemento";
            // 
            // txtComple
            // 
            this.txtComple.Location = new System.Drawing.Point(463, 99);
            this.txtComple.Name = "txtComple";
            this.txtComple.Size = new System.Drawing.Size(238, 29);
            this.txtComple.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(371, 75);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 21);
            this.label13.TabIndex = 37;
            this.label13.Text = "Nº";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(902, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 21);
            this.label6.TabIndex = 35;
            this.label6.Text = "CEP";
            // 
            // mtbCEP
            // 
            this.mtbCEP.Location = new System.Drawing.Point(902, 99);
            this.mtbCEP.Margin = new System.Windows.Forms.Padding(4);
            this.mtbCEP.Mask = "#####-###";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(139, 29);
            this.mtbCEP.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gray;
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txtObs);
            this.groupBox3.Location = new System.Drawing.Point(13, 402);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1051, 155);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(8, 19);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(92, 21);
            this.label21.TabIndex = 1;
            this.label21.Text = "Observação";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(8, 43);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(1033, 85);
            this.txtObs.TabIndex = 21;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Gray;
            this.groupBox4.Controls.Add(this.btoSair);
            this.groupBox4.Controls.Add(this.btoLimpar);
            this.groupBox4.Controls.Add(this.btoCadastro);
            this.groupBox4.Controls.Add(this.btoAlterar);
            this.groupBox4.Location = new System.Drawing.Point(13, 548);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1051, 67);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(947, 17);
            this.btoSair.Margin = new System.Windows.Forms.Padding(4);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(94, 40);
            this.btoSair.TabIndex = 25;
            this.btoSair.Text = "&Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // btoLimpar
            // 
            this.btoLimpar.Location = new System.Drawing.Point(845, 17);
            this.btoLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btoLimpar.Name = "btoLimpar";
            this.btoLimpar.Size = new System.Drawing.Size(94, 40);
            this.btoLimpar.TabIndex = 24;
            this.btoLimpar.Text = "&Limpar";
            this.btoLimpar.UseVisualStyleBackColor = true;
            this.btoLimpar.Click += new System.EventHandler(this.btoLimpar_Click);
            // 
            // btoCadastro
            // 
            this.btoCadastro.Location = new System.Drawing.Point(641, 17);
            this.btoCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.btoCadastro.Name = "btoCadastro";
            this.btoCadastro.Size = new System.Drawing.Size(94, 40);
            this.btoCadastro.TabIndex = 22;
            this.btoCadastro.Text = "&Cadastro";
            this.btoCadastro.UseVisualStyleBackColor = true;
            this.btoCadastro.Click += new System.EventHandler(this.btoCadastro_Click_1);
            // 
            // btoAlterar
            // 
            this.btoAlterar.Location = new System.Drawing.Point(743, 17);
            this.btoAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btoAlterar.Name = "btoAlterar";
            this.btoAlterar.Size = new System.Drawing.Size(94, 40);
            this.btoAlterar.TabIndex = 23;
            this.btoAlterar.Text = "&Alterar";
            this.btoAlterar.UseVisualStyleBackColor = true;
            this.btoAlterar.Click += new System.EventHandler(this.btoAlterar_Click);
            // 
            // pnlEmcima
            // 
            this.pnlEmcima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.pnlEmcima.Controls.Add(this.pictureBoxMinimizar);
            this.pnlEmcima.Controls.Add(this.pictureBoxFechar);
            this.pnlEmcima.Controls.Add(this.pictureBox1);
            this.pnlEmcima.Controls.Add(this.pcbMinimizar);
            this.pnlEmcima.Controls.Add(this.pcbMaximizar);
            this.pnlEmcima.Controls.Add(this.pcbFechar);
            this.pnlEmcima.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEmcima.Location = new System.Drawing.Point(0, 0);
            this.pnlEmcima.Name = "pnlEmcima";
            this.pnlEmcima.Size = new System.Drawing.Size(1073, 35);
            this.pnlEmcima.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1435, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pcbMinimizar
            // 
            this.pcbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pcbMinimizar.Image")));
            this.pcbMinimizar.Location = new System.Drawing.Point(1404, 7);
            this.pcbMinimizar.Name = "pcbMinimizar";
            this.pcbMinimizar.Size = new System.Drawing.Size(25, 25);
            this.pcbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbMinimizar.TabIndex = 1;
            this.pcbMinimizar.TabStop = false;
            this.pcbMinimizar.Click += new System.EventHandler(this.pcbMinimizar_Click);
            // 
            // pcbMaximizar
            // 
            this.pcbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("pcbMaximizar.Image")));
            this.pcbMaximizar.Location = new System.Drawing.Point(1466, 7);
            this.pcbMaximizar.Name = "pcbMaximizar";
            this.pcbMaximizar.Size = new System.Drawing.Size(25, 25);
            this.pcbMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbMaximizar.TabIndex = 1;
            this.pcbMaximizar.TabStop = false;
            this.pcbMaximizar.Click += new System.EventHandler(this.pcbMaximizar_Click);
            // 
            // pcbFechar
            // 
            this.pcbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbFechar.Image = ((System.Drawing.Image)(resources.GetObject("pcbFechar.Image")));
            this.pcbFechar.Location = new System.Drawing.Point(1497, 7);
            this.pcbFechar.Name = "pcbFechar";
            this.pcbFechar.Size = new System.Drawing.Size(25, 25);
            this.pcbFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbFechar.TabIndex = 0;
            this.pcbFechar.TabStop = false;
            this.pcbFechar.Click += new System.EventHandler(this.pcbFechar_Click);
            // 
            // pictureBoxFechar
            // 
            this.pictureBoxFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFechar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFechar.Image")));
            this.pictureBoxFechar.Location = new System.Drawing.Point(1036, 7);
            this.pictureBoxFechar.Name = "pictureBoxFechar";
            this.pictureBoxFechar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFechar.TabIndex = 3;
            this.pictureBoxFechar.TabStop = false;
            this.pictureBoxFechar.Click += new System.EventHandler(this.pictureBoxFechar_Click);
            // 
            // pictureBoxMinimizar
            // 
            this.pictureBoxMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinimizar.Image")));
            this.pictureBoxMinimizar.Location = new System.Drawing.Point(1005, 7);
            this.pictureBoxMinimizar.Name = "pictureBoxMinimizar";
            this.pictureBoxMinimizar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimizar.TabIndex = 4;
            this.pictureBoxMinimizar.TabStop = false;
            this.pictureBoxMinimizar.Click += new System.EventHandler(this.pictureBoxMinimizar_Click);
            // 
            // frmCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1073, 640);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlEmcima);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCadUsuario";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroUsuário";
            this.Load += new System.EventHandler(this.CadUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.pnlEmcima.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtCodigo;
        private Label label1;
        private ComboBox cboStatus;
        private Label label3;
        private Button btoPesquisa;
        private Label label4;
        private MaskedTextBox mtbCPF;
        private TextBox txtNome;
        private Label label2;
        private Label label5;
        private TextBox txtLogin;
        private Label label7;
        private ComboBox cboIDdepart;
        private Label label8;
        private TextBox txtBairro;
        private Label label9;
        private TextBox txtLogradouro;
        private Label label10;
        private TextBox txtCity;
        private ComboBox cboUF;
        private Label label11;
        private Label label14;
        private MaskedTextBox mtbTel1;
        private MaskedTextBox mtbTel2;
        private Label label15;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label6;
        private MaskedTextBox mtbCEP;
        private GroupBox groupBox4;
        private Button btoAlterar;
        private Button btoSair;
        private Button btoLimpar;
        private Button btoCadastro;
        private Label label13;
        private Label label12;
        private Label label17;
        private MaskedTextBox mtbDataC;
        private Label label19;
        private TextBox txtEmail;
        private Label label18;
        private TextBox txtComple;
        private Label label20;
        private TextBox txtSenha;
        private Label label21;
        private TextBox txtObs;
        private ComboBox cboDepart;
        private MaskedTextBox mtbNumero;
        private Panel pnlEmcima;
        private PictureBox pcbMinimizar;
        private PictureBox pcbMaximizar;
        private PictureBox pcbFechar;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxFechar;
        private PictureBox pictureBoxMinimizar;
    }
}