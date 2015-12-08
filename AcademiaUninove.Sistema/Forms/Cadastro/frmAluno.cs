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
    public partial class frmAluno : Form
    {
        #region Variáveis Globais
        private string _tpOperacao = string.Empty;
        private int _codAluno = 0;
        Aluno objAlunoDTO = new Aluno();
        AlunoBO objAlunoBO = new AlunoBO();
        Validacao objValidacao = new Validacao();
        #endregion

        public frmAluno()
        {
            InitializeComponent();
        }

        public frmAluno(string operacao, int codigo)
        {
            InitializeComponent();
            _tpOperacao = operacao;
            _codAluno = codigo;
        }

        private void frmAluno_Load(object sender, EventArgs e)
        {
            VerificaOperacao(_tpOperacao);
        }

        private void VerificaOperacao(string operacao)
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
