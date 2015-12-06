using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UninoveAcademiaSistemas.Formularios.Exercicios
{
    public partial class frmMedidasPrinc : Form
    {
        public frmMedidasPrinc()
        {
            InitializeComponent();
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            frmMedidas telaMedidas = new frmMedidas();
            telaMedidas.ShowDialog();
        }
    }
}
