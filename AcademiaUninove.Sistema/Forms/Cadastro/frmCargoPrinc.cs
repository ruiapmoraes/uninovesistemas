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

        string _tpOperacao = string.Empty;
        int _codCargo = 0;

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

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            frmCargo telaCargo = new frmCargo();
            telaCargo.ShowDialog();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            _tpOperacao = "editar";
            _codCargo = int.Parse(dgvCargo.Rows[e.RowIndex].Cells[0].Value.ToString());


            frmCargo telaCargo = new frmCargo(_tpOperacao, _codCargo);
            telaCargo.Show();
        }

        private void dgvCargo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _tpOperacao = "editar";
            _codCargo = int.Parse(dgvCargo.Rows[e.RowIndex].Cells[0].Value.ToString());


            frmCargo telaCargo = new frmCargo(_tpOperacao, _codCargo);
            telaCargo.Show();
            //TODO:
            //dgvCargo.Rows[e.RowIndex].Cells[0].Value
        }

        private int BuscaIdCargo()
        {
            return 0;
        }
    }
}
