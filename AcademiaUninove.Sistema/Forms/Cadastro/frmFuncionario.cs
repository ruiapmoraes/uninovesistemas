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
using AcademiaUninove.Sistema.Helpers;

namespace AcademiaUninove.Sistema.Forms.Cadastro
{
    public partial class frmFuncionario : Form
    {
        #region Variáveis globais
        private string _tpOperacao;
        private int _codFunc;
        Funcionario objFuncionarioDTO = new Funcionario();
        FuncionarioBO objFuncionarioBO = new FuncionarioBO();
        Validacao objValidacao = new Validacao();
        #endregion

        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void PopulaCampos()
        {
            //TODO: Inserir para novos campos
            ;
        }

        public frmFuncionario(string tpOperacao, int codFunc)
        {
            // TODO: Complete member initialization
            this._tpOperacao = tpOperacao;
            this._codFunc = codFunc;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_tpOperacao))
            {
                AtualizarFuncionario(Int32.Parse(txtCodigo.Text), Int32.Parse(cmbCargo.SelectedValue.ToString()), txtNome.Text, txtEndereco.Text, txtCidade.Text, txtCEP.Text, txtTelRes.Text, txtTelCel.Text);
            }
            else
                InserirFuncionario(Int32.Parse(txtCodigo.Text), Int32.Parse(cmbCargo.SelectedValue.ToString()), txtNome.Text, txtEndereco.Text, txtCidade.Text, txtCEP.Text, txtTelRes.Text, txtTelCel.Text);

            this.Close();
        }

        private void InserirFuncionario(int codigo, int cargo, string nome, string endereco, string cidade, string cep, string telres, string telcel)
        {
            bool resultado;

            //if (objValidacao.NumeroPreenchido(codigo) && objValidacao.CamposPreechidos(aula))
            //{
            //    //Verificar usuario no banco
            //    MessageBox.Show("Há campos nulos.");
            //    return;
            //}
            //else
            //{
            objFuncionarioDTO.CodigoFunc = codigo;
            objFuncionarioDTO.CodigoCargo = cargo;
            objFuncionarioDTO.NomeFuncionario = nome;
            objFuncionarioDTO.EndFuncionario = endereco;
            objFuncionarioDTO.CidadeFunc = cidade;
            objFuncionarioDTO.CEPFunc = cep;
            objFuncionarioDTO.TelResFunc = telres;
            objFuncionarioDTO.TelCelFunc = telcel;

            resultado = objFuncionarioBO.InseriFuncionario(objFuncionarioDTO.CodigoFunc, objFuncionarioDTO.CodigoCargo, objFuncionarioDTO.NomeFuncionario,
                            objFuncionarioDTO.EndFuncionario, objFuncionarioDTO.CidadeFunc, objFuncionarioDTO.CEPFunc, objFuncionarioDTO.TelResFunc, objFuncionarioDTO.TelCelFunc);

            if (resultado)
            {
                MessageBox.Show("Gravação efetuada com sucesso!");
                this.Close();
            }
            else
                MessageBox.Show("Ocorreu uma falha ao salvar o registro!");
            //}
        }

        private void AtualizarFuncionario(int codigo, int cargo, string nome, string endereco, string cidade, string cep, string telres, string telcel)
        {
            //TODO: Pensar numa solução opara validar n campos da tela
            bool resultado = false;

            objFuncionarioDTO.CodigoFunc = codigo;
            objFuncionarioDTO.CodigoCargo = cargo;
            objFuncionarioDTO.NomeFuncionario = nome;
            objFuncionarioDTO.EndFuncionario = endereco;
            objFuncionarioDTO.CidadeFunc = cidade;
            objFuncionarioDTO.CEPFunc = cep;
            objFuncionarioDTO.TelResFunc = telres;
            objFuncionarioDTO.TelCelFunc = telcel;

            resultado = objFuncionarioBO.AtualizaFuncionario(objFuncionarioDTO.CodigoFunc, objFuncionarioDTO.CodigoFunc, objFuncionarioDTO.NomeFuncionario,
                            objFuncionarioDTO.EndFuncionario, objFuncionarioDTO.CidadeFunc, objFuncionarioDTO.CEPFunc, objFuncionarioDTO.TelResFunc, objFuncionarioDTO.TelCelFunc);

            if (resultado)
            {
                MessageBox.Show("Atualização efetuada com sucesso!");
                this.Close();
            }
            else
                MessageBox.Show("Ocorreu uma falha ao salvar o registro!");
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

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            CarregaComboCargo();
        }
    }
}
