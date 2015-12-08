using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcademiaUninove.Sistema.Negocio;

namespace AcademiaUninove.Sistema.Forms.Cadastro
{
    public partial class frmFuncAulaPrinc : Form
    {
        #region Variáveis globais
        string _tpOperacao = string.Empty;
        int _codFuncAula = 0;
        #endregion

        public frmFuncAulaPrinc()
        {
            InitializeComponent();
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            frmFuncAula telaFuncAula = new frmFuncAula();
            telaFuncAula.ShowDialog();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int linha = 0;
            _tpOperacao = "editar";
         
            linha = dgvFuncAula.CurrentRow.Index;
            _codFuncAula = int.Parse(dgvFuncAula.Rows[linha].Cells[0].Value.ToString());          

            frmFuncAula telaFuncAula = new frmFuncAula(_tpOperacao, _codFuncAula);
            telaFuncAula.ShowDialog();
        }

        private void tsbDeletar_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            int linha = 0;


            linha = dgvFuncAula.CurrentRow.Index;
            _codFuncAula = int.Parse(dgvFuncAula.Rows[linha].Cells[0].Value.ToString());
            FuncAulaBO objFuncAulaBO = new FuncAulaBO();

            if (MessageBox.Show("Confirma exclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                resultado = objFuncAulaBO.ExcluirAulaInstrutor(_codFuncAula);
                if (resultado)
                {
                    MessageBox.Show("Registro excluído com sucesso!");
                    //dgvFuncAula.DataSource = DtFuncAula();
                    dgvFuncAula.DataSource = DtFuncAula(int.Parse(cmbInstrutor.SelectedValue.ToString()));
                    dgvFuncAula.Columns[1].Visible = false;
                    dgvFuncAula.Columns[3].Visible = false;
                }
            }
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFuncAulaPrinc_Load(object sender, EventArgs e)
        {
            //dgvFuncAula.DataSource = DtFuncAula();
            CarregaComboInstrutor();
        }

        private DataTable DtFuncAula()
        {
            DataTable dtFuncAulaLocal = new DataTable();
            FuncAulaBO objFuncAulaBO = new FuncAulaBO();
            dtFuncAulaLocal = objFuncAulaBO.ObterAulaFunc();

            return dtFuncAulaLocal;
        }

        private DataTable DtFuncAula(int codigo)
        {
            DataTable dtFuncAulaLocal = new DataTable();
            FuncAulaBO objFuncAulaBO = new FuncAulaBO();
            dtFuncAulaLocal = objFuncAulaBO.ObterAulaFunc(codigo);

            return dtFuncAulaLocal;
        }

        private void CarregaComboInstrutor(int codigo)
        {
            DataTable dtInstrutorCombo = null;

            int intContador = 0;
            FuncionarioBO objFuncionarioBO = new FuncionarioBO();
            dtInstrutorCombo = objFuncionarioBO.ObterFuncionario(codigo);
            dtInstrutorCombo.DefaultView.Sort = "Nome Funcionário asc";


            if (dtInstrutorCombo.Rows.Count < 0 && dtInstrutorCombo == null)
            {
                intContador = 0;
                cmbInstrutor.Items.Clear();
            }
            else
            {
                cmbInstrutor.ValueMember = "Código";
                cmbInstrutor.DisplayMember = "Nome Funcionário";
                cmbInstrutor.DataSource = dtInstrutorCombo;
            }
        }

        private void CarregaComboInstrutor()
        {
            DataTable dtInstrutorCombo = null;

            int intContador = 0;
            FuncionarioBO objFuncionarioBO = new FuncionarioBO();
            dtInstrutorCombo = objFuncionarioBO.ObterFuncionario();
            dtInstrutorCombo.DefaultView.Sort = "Nome Funcionário asc";


            if (dtInstrutorCombo.Rows.Count < 0 && dtInstrutorCombo == null)
            {
                intContador = 0;
                cmbInstrutor.Items.Clear();
            }
            else
            {
                cmbInstrutor.ValueMember = "Código";
                cmbInstrutor.DisplayMember = "Nome Funcionário";
                cmbInstrutor.DataSource = dtInstrutorCombo;
            }
        }

        private void CarregaCamposInstrutor(int codigo)
        {
            DataTable dtFuncAula = null;
            DataTable dtFuncAulaCombo = null;
            int intContador = 0;
            int linha = 0;
            CargoBO objCargoBO = new CargoBO();
            FuncionarioBO objFuncionarioBO = new FuncionarioBO();
            dtFuncAula = objFuncionarioBO.ObterFuncionario(codigo);

            if (dtFuncAula.Rows.Count <= 0 || dtFuncAula == null)
            {
                return;
            }
            else
            {
                linha = int.Parse(dtFuncAula.Rows[0][1].ToString());
                dtFuncAulaCombo = objCargoBO.ObterCargoCombo(linha);
                //dtCargoCombo.DefaultView.Sort = "Cargo asc";


                if (dtFuncAulaCombo.Rows.Count < 0 && dtFuncAulaCombo == null)
                {
                    intContador = 0;
                    cmbInstrutor.Items.Clear();
                }
                else
                {
                    cmbInstrutor.ValueMember = "Código";
                    cmbInstrutor.DisplayMember = "Nome Funcionário";
                    cmbInstrutor.DataSource = dtFuncAulaCombo;
                    #region Em desuso

                    //txtCodigoMask.Text = dtFuncAula.Rows[0][0].ToString();
                    //txtNome.Text = dtFuncAula.Rows[0][3].ToString();
                    //txtEndereco.Text = dtFuncAula.Rows[0][4].ToString();
                    //txtCidade.Text = dtFuncAula.Rows[0][5].ToString();
                    //txtCEP.Text = dtFuncAula.Rows[0][6].ToString();
                    //txtTelRes.Text = dtFuncAula.Rows[0][7].ToString();
                    //txtTelCel.Text = dtFuncAula.Rows[0][8].ToString(); 
                    #endregion

                }
            }
        }

        private void cmbInstrutor_SelectedValueChanged(object sender, EventArgs e)
        {
            //dgvFuncAula.DataSource = DtFuncAula(int.Parse(cmbInstrutor.SelectedValue.ToString()));
        }

        private void cmbInstrutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvFuncAula.DataSource = DtFuncAula(int.Parse(cmbInstrutor.SelectedValue.ToString()));
            dgvFuncAula.Columns[1].Visible = false;
            dgvFuncAula.Columns[3].Visible = false;

        }

        private void dgvFuncAula_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _tpOperacao = "editar";
            _codFuncAula = int.Parse(dgvFuncAula.Rows[e.RowIndex].Cells[0].Value.ToString());

            frmFuncAula telaFuncAula = new frmFuncAula(_tpOperacao, _codFuncAula);
            telaFuncAula.ShowDialog();
        }
    }
}
