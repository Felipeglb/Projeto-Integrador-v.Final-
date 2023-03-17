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
    public partial class MDIDepart : Form
    {
        private int childFormNumber = 0;

        public MDIDepart()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        string stringConexao = frmLogin.stringConexao;

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

        private void MDIDepart_Load(object sender, EventArgs e)
        {
            testarconexao();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmCadUsuario frm = new frmCadUsuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void planosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlanos frm = new frmPlanos();
            frm.MdiParent = this;
            frm.Show();
        }



        private void cadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParceiro frm = new frmParceiro();
            frm.MdiParent = this;
            frm.Show();
        }

        private void criarDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContrato frm = new frmContrato();
            frm.MdiParent = this;
            frm.Show();
        }

        private void criarDepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCriarDepartamento frm = new frmCriarDepartamento();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pictureBoxFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
     
            pictureBoxMaximizar.Visible = true;
        }

        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
           
            pictureBoxRestaurar.Visible = true;
        }
    }
}
