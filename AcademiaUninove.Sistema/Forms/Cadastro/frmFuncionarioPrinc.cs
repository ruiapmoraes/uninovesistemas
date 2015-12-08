using AcademiaUninove.Sistema.Negocio;
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
        #region Variáveis globais
        string _tpOperacao = string.Empty;
        int _codFunc = 0;
        #endregion

        public frmFuncionarioPrinc()
        {
            InitializeComponent();
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            frmFuncionario telaFuncionario = new frmFuncionario();
            telaFuncionario.ShowDialog();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int linha = 0;
            _tpOperacao = "editar";
            linha = dgvFuncionario.CurrentRow.Index;
            _codFunc = int.Parse(dgvFuncionario.Rows[linha].Cells[0].Value.ToString());

            frmFuncionario telaFunc = new frmFuncionario(_tpOperacao, _codFunc);
            telaFunc.ShowDialog();
        }

        private void tsbDeletar_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            int linha = 0;


            linha = dgvFuncionario.CurrentRow.Index;
            _codFunc = int.Parse(dgvFuncionario.Rows[linha].Cells[0].Value.ToString());
            FuncionarioBO objFuncionarioBO = new FuncionarioBO();

            if (MessageBox.Show("Confirma exclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                resultado = objFuncionarioBO.ExcluiFunc(_codFunc);
                if (resultado)
                {
                    MessageBox.Show("Exclusão de registro realizada com sucesso!");
                    dgvFuncionario.DataSource = DtFuncGeral();
                }
            }
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFuncionarioPrinc_Load(object sender, EventArgs e)
        {
            //TODO: Além de popular o gridview, é precido popular os campos
            dgvFuncionario.DataSource = DtFuncGeral();
            //CarregaComboCargo();
            dgvFuncionario.Columns[1].Visible = false;
        }

        public DataTable DtFuncGeral()
        {
            DataTable dtFuncLocal = new DataTable();
            FuncionarioBO objFuncionario = new FuncionarioBO();
            dtFuncLocal = objFuncionario.ObterFuncionario();

            return dtFuncLocal;
        }

        //TODO: Criar rotina para popular a tela a partir do combo do funcionáriop
        private void ObterComboFuncionario()
        {
            ;
        }

        private void dgvFuncionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _tpOperacao = "editar";
            _codFunc = int.Parse(dgvFuncionario.Rows[e.RowIndex].Cells[0].Value.ToString());

            frmFuncionario telaFuncionario = new frmFuncionario(_tpOperacao, _codFunc);
            telaFuncionario.ShowDialog();
        }

        private void CarregaComboCargo()
        {
            DataTable dtCargoCombo = null;
            DataView dvCargoCombro = null;
            int intContador = 0;
            CargoBO objCargoBO = new CargoBO();
            dtCargoCombo = objCargoBO.ObterCargo();
            dtCargoCombo.DefaultView.Sort = "Cargo asc";


            if (dtCargoCombo.Rows.Count < 0 && dtCargoCombo == null)
            {
                intContador = 0;
                cmbCargo.Items.Clear();
            }
            else
            {
                cmbCargo.ValueMember = "Código";
                cmbCargo.DisplayMember = "Cargo";
                cmbCargo.DataSource = dtCargoCombo;
            }
        }
    }
}
