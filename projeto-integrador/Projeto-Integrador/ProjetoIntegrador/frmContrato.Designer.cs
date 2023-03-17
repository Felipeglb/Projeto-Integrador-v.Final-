namespace ProjetoIntegrador
{
    partial class frmContrato
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContrato));
            this.txtIDcontrato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdPlano = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdParceiro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpEmissao = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTermino = new System.Windows.Forms.DateTimePicker();
            this.txtNomePlano = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorPlano = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeParceiro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btoPesquisa6 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btoPesquisar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btoSair = new System.Windows.Forms.Button();
            this.btoLimpar = new System.Windows.Forms.Button();
            this.btoCadastrar = new System.Windows.Forms.Button();
            this.btoPesquisar2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTipoPlano = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxFechar = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDcontrato
            // 
            this.txtIDcontrato.Location = new System.Drawing.Point(3, 47);
            this.txtIDcontrato.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDcontrato.Name = "txtIDcontrato";
            this.txtIDcontrato.Size = new System.Drawing.Size(124, 29);
            this.txtIDcontrato.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(0, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Contrato";
            // 
            // txtIdPlano
            // 
            this.txtIdPlano.Location = new System.Drawing.Point(4, 39);
            this.txtIdPlano.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPlano.Name = "txtIdPlano";
            this.txtIdPlano.Size = new System.Drawing.Size(127, 29);
            this.txtIdPlano.TabIndex = 0;
            this.txtIdPlano.TextChanged += new System.EventHandler(this.txtIdPlano_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(7, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID plano";
            // 
            // txtIdParceiro
            // 
            this.txtIdParceiro.Location = new System.Drawing.Point(3, 38);
            this.txtIdParceiro.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdParceiro.Name = "txtIdParceiro";
            this.txtIdParceiro.Size = new System.Drawing.Size(127, 29);
            this.txtIdParceiro.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID Parceiro";
            // 
            // dtpEmissao
            // 
            this.dtpEmissao.Location = new System.Drawing.Point(6, 170);
            this.dtpEmissao.Name = "dtpEmissao";
            this.dtpEmissao.Size = new System.Drawing.Size(334, 29);
            this.dtpEmissao.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(7, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Data Emissão";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(8, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Data Termino";
            // 
            // dtpTermino
            // 
            this.dtpTermino.Location = new System.Drawing.Point(6, 237);
            this.dtpTermino.Name = "dtpTermino";
            this.dtpTermino.Size = new System.Drawing.Size(334, 29);
            this.dtpTermino.TabIndex = 2;
            // 
            // txtNomePlano
            // 
            this.txtNomePlano.Location = new System.Drawing.Point(138, 97);
            this.txtNomePlano.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomePlano.Name = "txtNomePlano";
            this.txtNomePlano.Size = new System.Drawing.Size(127, 29);
            this.txtNomePlano.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(134, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nome Plano";
            // 
            // txtValorPlano
            // 
            this.txtValorPlano.Location = new System.Drawing.Point(5, 97);
            this.txtValorPlano.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorPlano.Name = "txtValorPlano";
            this.txtValorPlano.Size = new System.Drawing.Size(127, 29);
            this.txtValorPlano.TabIndex = 0;
            this.txtValorPlano.Enter += new System.EventHandler(this.txtValorPlano_Enter);
            this.txtValorPlano.Leave += new System.EventHandler(this.txtValorPlano_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(4, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Valor Plano";
            // 
            // txtNomeParceiro
            // 
            this.txtNomeParceiro.Location = new System.Drawing.Point(169, 100);
            this.txtNomeParceiro.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeParceiro.Name = "txtNomeParceiro";
            this.txtNomeParceiro.Size = new System.Drawing.Size(127, 29);
            this.txtNomeParceiro.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(169, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nome Parceiro";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(3, 100);
            this.txtCnpj.Margin = new System.Windows.Forms.Padding(4);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(158, 29);
            this.txtCnpj.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(3, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "CNPJ Parceiro";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.btoPesquisa6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIDcontrato);
            this.groupBox1.Location = new System.Drawing.Point(0, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 109);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btoPesquisa6
            // 
            this.btoPesquisa6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btoPesquisa6.Location = new System.Drawing.Point(134, 47);
            this.btoPesquisa6.Name = "btoPesquisa6";
            this.btoPesquisa6.Size = new System.Drawing.Size(75, 30);
            this.btoPesquisa6.TabIndex = 1;
            this.btoPesquisa6.Text = "Pesquisar";
            this.btoPesquisa6.UseVisualStyleBackColor = true;
            this.btoPesquisa6.Click += new System.EventHandler(this.btoPesquisa6_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.btoPesquisar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtCnpj);
            this.groupBox2.Controls.Add(this.txtIdParceiro);
            this.groupBox2.Controls.Add(this.txtNomeParceiro);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(0, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 166);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btoPesquisar
            // 
            this.btoPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btoPesquisar.Location = new System.Drawing.Point(135, 38);
            this.btoPesquisar.Name = "btoPesquisar";
            this.btoPesquisar.Size = new System.Drawing.Size(74, 29);
            this.btoPesquisar.TabIndex = 1;
            this.btoPesquisar.Text = "Pesquisar";
            this.btoPesquisar.UseVisualStyleBackColor = true;
            this.btoPesquisar.Click += new System.EventHandler(this.btoPesquisar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gray;
            this.groupBox3.Controls.Add(this.btoSair);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dtpTermino);
            this.groupBox3.Controls.Add(this.txtNomePlano);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btoLimpar);
            this.groupBox3.Controls.Add(this.txtValorPlano);
            this.groupBox3.Controls.Add(this.btoCadastrar);
            this.groupBox3.Controls.Add(this.btoPesquisar2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dtpEmissao);
            this.groupBox3.Controls.Add(this.txtTipoPlano);
            this.groupBox3.Controls.Add(this.txtIdPlano);
            this.groupBox3.Location = new System.Drawing.Point(0, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(450, 319);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // btoSair
            // 
            this.btoSair.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btoSair.Location = new System.Drawing.Point(215, 280);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(75, 23);
            this.btoSair.TabIndex = 4;
            this.btoSair.Text = "Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // btoLimpar
            // 
            this.btoLimpar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btoLimpar.Location = new System.Drawing.Point(134, 280);
            this.btoLimpar.Name = "btoLimpar";
            this.btoLimpar.Size = new System.Drawing.Size(75, 23);
            this.btoLimpar.TabIndex = 4;
            this.btoLimpar.Text = "Limpar";
            this.btoLimpar.UseVisualStyleBackColor = true;
            this.btoLimpar.Click += new System.EventHandler(this.btoLimpar_Click);
            // 
            // btoCadastrar
            // 
            this.btoCadastrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btoCadastrar.Location = new System.Drawing.Point(53, 280);
            this.btoCadastrar.Name = "btoCadastrar";
            this.btoCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btoCadastrar.TabIndex = 4;
            this.btoCadastrar.Text = "Cadastrar";
            this.btoCadastrar.UseVisualStyleBackColor = true;
            this.btoCadastrar.Click += new System.EventHandler(this.btoCadastrar_Click);
            // 
            // btoPesquisar2
            // 
            this.btoPesquisar2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btoPesquisar2.Location = new System.Drawing.Point(135, 39);
            this.btoPesquisar2.Name = "btoPesquisar2";
            this.btoPesquisar2.Size = new System.Drawing.Size(75, 29);
            this.btoPesquisar2.TabIndex = 3;
            this.btoPesquisar2.Text = "Pesquisar";
            this.btoPesquisar2.UseVisualStyleBackColor = true;
            this.btoPesquisar2.Click += new System.EventHandler(this.btoPesquisar2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(270, 72);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tipo Plano";
            // 
            // txtTipoPlano
            // 
            this.txtTipoPlano.Location = new System.Drawing.Point(269, 97);
            this.txtTipoPlano.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoPlano.Name = "txtTipoPlano";
            this.txtTipoPlano.Size = new System.Drawing.Size(127, 29);
            this.txtTipoPlano.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.pictureBoxFechar);
            this.panel1.Controls.Add(this.pictureBoxMinimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 33);
            this.panel1.TabIndex = 6;
            // 
            // pictureBoxFechar
            // 
            this.pictureBoxFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFechar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFechar.Image")));
            this.pictureBoxFechar.Location = new System.Drawing.Point(425, 5);
            this.pictureBoxFechar.Name = "pictureBoxFechar";
            this.pictureBoxFechar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFechar.TabIndex = 0;
            this.pictureBoxFechar.TabStop = false;
            this.pictureBoxFechar.Click += new System.EventHandler(this.pictureBoxFechar_Click);
            // 
            // pictureBoxMinimizar
            // 
            this.pictureBoxMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinimizar.Image")));
            this.pictureBoxMinimizar.Location = new System.Drawing.Point(394, 5);
            this.pictureBoxMinimizar.Name = "pictureBoxMinimizar";
            this.pictureBoxMinimizar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimizar.TabIndex = 0;
            this.pictureBoxMinimizar.TabStop = false;
            this.pictureBoxMinimizar.Click += new System.EventHandler(this.pictureBoxMinimizar_Click);
            // 
            // frmContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(453, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmContrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmContrato";
            this.Load += new System.EventHandler(this.frmContrato_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtIDcontrato;
        private Label label1;
        private TextBox txtIdPlano;
        private Label label2;
        private TextBox txtIdParceiro;
        private Label label3;
        private DateTimePicker dtpEmissao;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpTermino;
        private TextBox txtNomePlano;
        private Label label6;
        private TextBox txtValorPlano;
        private Label label7;
        private TextBox txtNomeParceiro;
        private Label label8;
        private TextBox txtCnpj;
        private Label label9;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label10;
        private TextBox txtTipoPlano;
        private Button btoPesquisa6;
        private Button btoPesquisar;
        private Button btoPesquisar2;
        private Button btoSair;
        private Button btoLimpar;
        private Button btoCadastrar;
        private Panel panel1;
        private PictureBox pictureBoxFechar;
        private PictureBox pictureBoxMinimizar;
    }
}