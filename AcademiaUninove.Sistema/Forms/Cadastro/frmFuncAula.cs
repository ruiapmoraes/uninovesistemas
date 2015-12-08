using AcademiaUninove.Sistema.Classes;
using AcademiaUninove.Sistema.Helpers;
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
    public partial class frmFuncAula : Form
    {
        #region Variáveis globais
        private string _tpOperacao = string.Empty;
        private int _codFuncAula = 0;
        FuncAula objFuncAulaDTO = new FuncAula();
        FuncAulaBO objFuncAulaBO = new FuncAulaBO();
        Validacao objValidacao = new Validacao();
        #endregion

        public frmFuncAula()
        {
            InitializeComponent();
        }

        public frmFuncAula(string operacao,int codigo)
        {
            InitializeComponent();
            _tpOperacao = operacao;
            _codFuncAula = codigo;
        }

        private void frmFuncAula_Load(object sender, EventArgs e)
        {
            

            VerificarOperacao(_tpOperacao);
        }

        private void VerificarOperacao(string operacao)
        {
            if (operacao.ToUpper() == "EDITAR")
            {
                txtCodigo.ReadOnly = true;
                //TODO: Obter instrutores e Aulas
                CarregaComboInstrutor();
                CarregaComboAula();
                txtCodigo.Text = _codFuncAula.ToString();
                txtCodigo.Focus();
            }
            else
            {
                txtCodigo.ReadOnly = false;
                //TODO: Obter instrutores e Aulas
                CarregaComboInstrutor();
                CarregaComboAula();
                txtCodigo.Focus();
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

        private void CarregaComboAula()
        {
            DataTable dtAulaCombo = null;
            int intContador = 0;
            AulaBO objAulaBO = new AulaBO();
            dtAulaCombo = objAulaBO.ObterAula();
            dtAulaCombo.DefaultView.Sort = "NOME_AULA asc";

            if (dtAulaCombo.Rows.Count < 0 && dtAulaCombo == null)
            {
                intContador = 0;
                cmbAula.Items.Clear();

            }
            else
            {
                cmbAula.ValueMember = "CD_AULA";
                cmbAula.DisplayMember = "NOME_AULA";
                cmbAula.DataSource = dtAulaCombo;
            }
 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_tpOperacao))
            {
                AtualizaAulaInstrutor(int.Parse(txtCodigo.Text),
                                      int.Parse(cmbInstrutor.SelectedValue.ToString()),
                                      int.Parse(cmbAula.SelectedValue.ToString()));
            }
            else
                InsereAulaInstrutor(int.Parse(txtCodigo.Text),
                                      int.Parse(cmbInstrutor.SelectedValue.ToString()),
                                      int.Parse(cmbAula.SelectedValue.ToString()));
        }

        private void InsereAulaInstrutor(int codigo, int codigoInstrutor, int codigoAula)
        {
            bool resultado = false;

            objFuncAulaDTO.CodigoFuncAula = codigo;
            objFuncAulaDTO.CodigoFunc = codigoInstrutor;
            objFuncAulaDTO.CodigoAula = codigoAula;

            resultado = objFuncAulaBO.InserirAulaInstruitor(objFuncAulaDTO.CodigoFuncAula,
                                                            objFuncAulaDTO.CodigoFunc,
                                                            objFuncAulaDTO.CodigoAula);

            if (resultado)
            {
                MessageBox.Show("Gravação efetuada com sucesso!");
                this.Close();
            }
            else
                MessageBox.Show("Ocorreu uma falha ao salvar o registro!");
        }

        private void AtualizaAulaInstrutor(int codigo, int codigoInstrutor, int codigoAula)
        {
            bool resultado = false;

            objFuncAulaDTO.CodigoFuncAula = codigo;
            objFuncAulaDTO.CodigoFunc = codigoInstrutor;
            objFuncAulaDTO.CodigoAula = codigoAula;

            resultado = objFuncAulaBO.AtualizaAulaInstrutor(objFuncAulaDTO.CodigoFuncAula,
                                                            objFuncAulaDTO.CodigoFunc,
                                                            objFuncAulaDTO.CodigoAula);

            if (resultado)
            {
                MessageBox.Show("Atualização efetuada com sucesso!");
                this.Close();
            }
            else
                MessageBox.Show("Ocorreu uma falha ao salvar o registro!");
        }
    }
}
