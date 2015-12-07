using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaUninove.Sistema.Forms.Cadastro
{
    public partial class frmFuncionarioPrinc : Form
    {
        public frmFuncionarioPrinc()
        {
            InitializeComponent();
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            frmFuncionario telaFunc = new frmFuncionario();
            telaFunc.ShowDialog();
        }
    }
}
