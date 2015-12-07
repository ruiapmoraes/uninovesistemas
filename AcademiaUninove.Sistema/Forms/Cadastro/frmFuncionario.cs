using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcademiaUninove.Sistema.Classes;
using AcademiaUninove.Sistema.Negocio;

namespace AcademiaUninove.Sistema.Forms.Cadastro
{
    public partial class frmFuncionario : Form
    {
        #region Variáveis globais
        private string _tpOperacao;
        private int _codFunc;
        Funcionario objFuncionarioDTO = new Funcionario();
        FuncionarioBO objFuncionarioBO = new FuncionarioBO();
        #endregion

        public frmFuncionario()
        {
            InitializeComponent();
        }

        public frmFuncionario(string tpOperacao, int codFunc)
        {
            // TODO: Complete member initialization
            this._tpOperacao = tpOperacao;
            this._codFunc = codFunc;
        }
    }
}
