using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using UninoveAcademiaSistemas.ADO;
using UninoveAcademiaSistemas.Negocio;

namespace UninoveAcademiaSistemas.Formularios.Cadastro
{
    public partial class frmCargoPrincipal : Form
    {
        public frmCargoPrincipal()
        {
            InitializeComponent();
        }

        private void tsbSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            frmCargo telaCargo = new frmCargo();
            //telaCargo.MdiChildActivate = this;          
            telaCargo.ShowDialog();
            this.Focus();
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            frmCargo telaCargo = new frmCargo();
            telaCargo.ShowDialog();
            this.Focus();
        }

        private void tsbDeletar_Click(object sender, EventArgs e)
        {
            //TODO: Criar função para excluir registro
        }

        private void frmCargoPrincipal_Load(object sender, EventArgs e)
        {
            DataTable dtLocal = null;
            //CargoADO objCargoADO = new CargoADO();
            //objCargoADO.ConsultaCargo();
            dgvCargo.DataSource = dtCargoGeral();
        }

        private DataTable dtCargoGeral()
        {
            DataTable dtCargoLocal = new DataTable();
            CargoBO objCargo = new CargoBO();
            dtCargoLocal = objCargo.ObterCargo();

            //TODO: Obter Cargo geral
            return dtCargoLocal;
        }
    }
}
