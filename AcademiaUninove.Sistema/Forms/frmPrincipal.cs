using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcademiaUninove.Sistema.Forms.Cadastro;

namespace AcademiaUninove.Sistema.Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargoPrinc telaCargo = new frmCargoPrinc();
            telaCargo.MdiParent = this;
            telaCargo.Show();
        }

        private void aulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAulaPrinc telaAula = new frmAulaPrinc();
            telaAula.MdiParent = this;
            telaAula.Show();
        }
    }
}
