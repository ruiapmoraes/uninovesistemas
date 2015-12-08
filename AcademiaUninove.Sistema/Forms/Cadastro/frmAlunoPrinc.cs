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
            //TODO: Além de popular o gridview, é precido popular os campos

            dgvAluno.DataSource = DtAlunoGeral();
            linha = dgvAluno.CurrentRow.Index;
            _codAluno = int.Parse(dgvAluno.Rows[linha].Cells[1].Value.ToString());
            CarregaCamposAluno(_codAluno);
            dgvAluno.Columns[1].Visible = false;
        }

        private void CarregaCamposAluno(int _codAluno)
        {
            throw new NotImplementedException();
        }

        private DataTable DtAlunoGeral()
        {
            DataTable dtAlunoLocal = new DataTable();
            AlunoBO objAlunoBO = new AlunoBO();
            dtAlunoLocal = objAlunoBO.ObterAluno();

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
              
    }
}
