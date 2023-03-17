namespace ProjetoIntegrador
{
    partial class MDIDepart
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIDepart));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.rHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarDepartamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxRestaurar = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBoxMaximizar = new System.Windows.Forms.PictureBox();
            this.pictureBoxFechar = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rHToolStripMenuItem,
            this.fiToolStripMenuItem,
            this.vendasToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(81, 829);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // rHToolStripMenuItem
            // 
            this.rHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem,
            this.criarDepartamentosToolStripMenuItem});
            this.rHToolStripMenuItem.Name = "rHToolStripMenuItem";
            this.rHToolStripMenuItem.Size = new System.Drawing.Size(66, 19);
            this.rHToolStripMenuItem.Text = "RH";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // criarDepartamentosToolStripMenuItem
            // 
            this.criarDepartamentosToolStripMenuItem.Name = "criarDepartamentosToolStripMenuItem";
            this.criarDepartamentosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.criarDepartamentosToolStripMenuItem.Text = "Criar Departamentos";
            this.criarDepartamentosToolStripMenuItem.Click += new System.EventHandler(this.criarDepartamentosToolStripMenuItem_Click);
            // 
            // fiToolStripMenuItem
            // 
            this.fiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planosToolStripMenuItem,
            this.criarDepartamentoToolStripMenuItem});
            this.fiToolStripMenuItem.Name = "fiToolStripMenuItem";
            this.fiToolStripMenuItem.Size = new System.Drawing.Size(66, 19);
            this.fiToolStripMenuItem.Text = "Financeiro";
            // 
            // planosToolStripMenuItem
            // 
            this.planosToolStripMenuItem.Name = "planosToolStripMenuItem";
            this.planosToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.planosToolStripMenuItem.Text = "Planos";
            this.planosToolStripMenuItem.Click += new System.EventHandler(this.planosToolStripMenuItem_Click);
            // 
            // criarDepartamentoToolStripMenuItem
            // 
            this.criarDepartamentoToolStripMenuItem.Name = "criarDepartamentoToolStripMenuItem";
            this.criarDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.criarDepartamentoToolStripMenuItem.Text = "Contratos";
            this.criarDepartamentoToolStripMenuItem.Click += new System.EventHandler(this.criarDepartamentoToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroClienteToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(66, 19);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // cadastroClienteToolStripMenuItem
            // 
            this.cadastroClienteToolStripMenuItem.Name = "cadastroClienteToolStripMenuItem";
            this.cadastroClienteToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.cadastroClienteToolStripMenuItem.Text = "Cadastro Cliente";
            this.cadastroClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastroClienteToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(81, 807);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(985, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.pictureBoxRestaurar);
            this.panel1.Controls.Add(this.pictureBoxMinimizar);
            this.panel1.Controls.Add(this.pictureBoxMaximizar);
            this.panel1.Controls.Add(this.pictureBoxFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(81, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 35);
            this.panel1.TabIndex = 4;
            // 
            // pictureBoxRestaurar
            // 
            this.pictureBoxRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRestaurar.Image")));
            this.pictureBoxRestaurar.Location = new System.Drawing.Point(895, 3);
            this.pictureBoxRestaurar.Name = "pictureBoxRestaurar";
            this.pictureBoxRestaurar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRestaurar.TabIndex = 6;
            this.pictureBoxRestaurar.TabStop = false;
            this.pictureBoxRestaurar.Click += new System.EventHandler(this.pictureBoxRestaurar_Click);
            // 
            // pictureBoxMinimizar
            // 
            this.pictureBoxMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinimizar.Image")));
            this.pictureBoxMinimizar.Location = new System.Drawing.Point(864, 3);
            this.pictureBoxMinimizar.Name = "pictureBoxMinimizar";
            this.pictureBoxMinimizar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimizar.TabIndex = 6;
            this.pictureBoxMinimizar.TabStop = false;
            this.pictureBoxMinimizar.Click += new System.EventHandler(this.pictureBoxMinimizar_Click);
            // 
            // pictureBoxMaximizar
            // 
            this.pictureBoxMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMaximizar.Image")));
            this.pictureBoxMaximizar.Location = new System.Drawing.Point(926, 3);
            this.pictureBoxMaximizar.Name = "pictureBoxMaximizar";
            this.pictureBoxMaximizar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMaximizar.TabIndex = 6;
            this.pictureBoxMaximizar.TabStop = false;
            this.pictureBoxMaximizar.Click += new System.EventHandler(this.pictureBoxMaximizar_Click);
            // 
            // pictureBoxFechar
            // 
            this.pictureBoxFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFechar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFechar.Image")));
            this.pictureBoxFechar.Location = new System.Drawing.Point(957, 3);
            this.pictureBoxFechar.Name = "pictureBoxFechar";
            this.pictureBoxFechar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFechar.TabIndex = 6;
            this.pictureBoxFechar.TabStop = false;
            this.pictureBoxFechar.Click += new System.EventHandler(this.pictureBoxFechar_Click);
            // 
            // MDIDepart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1066, 829);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MDIDepart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MDIDepart_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem rHToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem fiToolStripMenuItem;
        private ToolStripMenuItem planosToolStripMenuItem;
        private ToolStripMenuItem criarDepartamentoToolStripMenuItem;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private ToolStripMenuItem cadastroClienteToolStripMenuItem;
        private ToolStripMenuItem criarDepartamentosToolStripMenuItem;
        private Panel panel1;
        private PictureBox pictureBoxRestaurar;
        private PictureBox pictureBoxMinimizar;
        private PictureBox pictureBoxMaximizar;
        private PictureBox pictureBoxFechar;
    }
}



