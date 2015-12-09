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
    public partial class frmAlunoPrinc : Form
    {
        #region Variáveis globais
        string _tpOperacao = string.Empty;
        int _codAluno = 0;
        #endregion

        public frmAlunoPrinc()
        {
            InitializeComponent();
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            frmAluno telaAluno = new frmAluno();            
            telaAluno.ShowDialog();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            _tpOperacao = "editar";
            _codAluno = int.Parse(dgvAluno.Rows[e.RowIndex].Cells[0].Value.ToString());

            frmAluno telaAluno = new frmAluno(_tpOperacao, _codAluno);
            telaAluno.ShowDialog();
        }

        private void tsbDeletar_Click(object sender, EventArgs e)
        {

        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAlunoPrinc_Load(object sender, EventArgs e)
        {
            int linha = 0;
            bool sucesso = false;
            //TODO: Além de popular o gridview, é precido popular os campos

            dgvAluno.DataSource = DtAlunoGeral(out sucesso);

            if (!sucesso)
            {
                linha = 0;
            }
            else
            {
                linha = dgvAluno.CurrentRow.Index;
                _codAluno = int.Parse(dgvAluno.Rows[linha].Cells[1].Value.ToString());
                CarregaCamposAluno(_codAluno);
                dgvAluno.Columns[1].Visible = false;
            }

        
        }

        private void CarregaCamposAluno(int codigo)
        {
            DataTable dtInstrutorCombo = null;
            DataTable dtAluno = null;
            int intContador = 0;
            int linha = 0;
          
            FuncionarioBO objFuncionarioBO = new FuncionarioBO();
            AlunoBO objAlunoBO = new AlunoBO();
            dtAluno = objAlunoBO.ObterAluno(codigo);

            if (dtAluno.Rows.Count <= 0 || dtAluno == null)
            {
                return;
            }
            else
            {
                linha = int.Parse(dtAluno.Rows[0][1].ToString());
                dtInstrutorCombo = objFuncionarioBO.ObterFuncionario(linha);
                //dtInstrutorCombo.DefaultView.Sort = "Cargo asc";


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

                    txtCodigo.Text = dtAluno.Rows[0][0].ToString();
                    txtAuno.Text = dtAluno.Rows[0][3].ToString();                    
                    txtCPF.Text = dtAluno.Rows[0][4].ToString();
                    txtRG.Text = dtAluno.Rows[0][5].ToString();
                    txtDataNasc.Text = dtAluno.Rows[0][6].ToString();
                    txtTelRes.Text = dtAluno.Rows[0][7].ToString();
                    txtTelCel.Text = dtAluno.Rows[0][8].ToString();
                    txtEndereco.Text = dtAluno.Rows[0][9].ToString();
                    txtCidade.Text = dtAluno.Rows[0][10].ToString();
                    txtCEP.Text = dtAluno.Rows[0][11].ToString();
                    txtStatusAluno.Text = dtAluno.Rows[0][12].ToString();
                    txtRestricao.Text = dtAluno.Rows[0][13].ToString();
                    txtObjetivo.Text = dtAluno.Rows[0][14].ToString();

                }
            }

        }

        private DataTable DtAlunoGeral(out bool sucesso)
        {
            DataTable dtAlunoLocal = new DataTable();
            AlunoBO objAlunoBO = new AlunoBO();
            dtAlunoLocal = objAlunoBO.ObterAluno(out sucesso);

            return dtAlunoLocal;
        }

        //Métodos abaixo

        /// <summary>
        /// Busca Instrutores
        /// </summary>
        /// <param name="codigo"></param>
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

        private void VerificarOperacao(string operacao)
        {
            if (operacao.ToUpper() == "EDITAR")
            {
                txtCodigo.ReadOnly = true;
                //CarregaCamposFuncionario(_codFunc);
            }
            else
            {
                txtCodigo.ReadOnly = false;
                //CarregaComboCargo();
            }
        }

        private void dgvAluno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _tpOperacao = "editar";
            _codAluno = int.Parse(dgvAluno.Rows[e.RowIndex].Cells[0].Value.ToString());

            frmAluno telaAluno = new frmAluno(_tpOperacao, _codAluno);
            telaAluno.ShowDialog();
        }

        private void dgvAluno_SelectionChanged(object sender, EventArgs e)
        {
            int linha = 0;
            linha = dgvAluno.CurrentRow.Index;
            _codAluno = int.Parse(dgvAluno.Rows[linha].Cells[0].Value.ToString());
            CarregaCamposAluno(_codAluno);
        }              
    }
}
