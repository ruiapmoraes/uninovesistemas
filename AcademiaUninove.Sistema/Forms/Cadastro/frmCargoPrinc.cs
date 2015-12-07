using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//TODO: somente teste
using AcademiaUninove.Sistema.ADO;
using AcademiaUninove.Sistema.Negocio;

namespace AcademiaUninove.Sistema.Forms.Cadastro
{
    public partial class frmCargoPrinc : Form
    {
        public frmCargoPrinc()
        {
            InitializeComponent();
        }

        private void frmCargoPrinc_Load(object sender, EventArgs e)
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
