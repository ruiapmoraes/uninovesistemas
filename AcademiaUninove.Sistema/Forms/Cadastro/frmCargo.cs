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
using AcademiaUninove.Sistema.Classes;
using AcademiaUninove.Sistema.Helpers;

namespace AcademiaUninove.Sistema.Forms.Cadastro
{
    public partial class frmCargo : Form
    {
        public frmCargo()
        {
            InitializeComponent();
        }

        public frmCargo(string tipoOperacao, int codCargo)
        {
            InitializeComponent();
            _tpOperacao = tipoOperacao;
            _codCargo = codCargo;
            PopularCampos();
        }

        string _tpOperacao = string.Empty;
        int _codCargo = 0;

        #region Variáveis Globais
        Cargo objCargoDTO = new Cargo();
        CargoBO objCargoBO = new CargoBO();
        Validacao objValidacao = new Validacao();
        #endregion


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_tpOperacao))
            {
                AtualizarCargo(Int32.Parse(txtCodigo.Text), txtCargo.Text);
            }
            else
                InserirCargo(Int32.Parse(txtCodigo.Text), txtCargo.Text);




            this.Close();
        }

        private void AtualizarCargo(int codigo, string cargo)
        {
            bool resultado;

            if (objValidacao.NumeroPreenchido(codigo) && objValidacao.CamposPreechidos(cargo))
            {
                //Verificar usuario no banco
                MessageBox.Show("Há campos nulos.");
                return;
            }
            else
            {
                objCargoDTO.CodigoCargo = codigo;
                objCargoDTO.NomeCargo = cargo;

                resultado = objCargoBO.AtualizaCargo(objCargoDTO.CodigoCargo, objCargoDTO.NomeCargo);

                if (resultado)
                {
                    MessageBox.Show("Atualização efetuada com sucesso!");
                    this.Close();
                }
                else
                    MessageBox.Show("Ocorreu uma falha ao salvar o registro!");
            }
        }

        private void InserirCargo(int codigo, string cargo)
        {
            bool resultado;

            if (objValidacao.NumeroPreenchido(codigo) && objValidacao.CamposPreechidos(cargo))
            {
                //Verificar usuario no banco
                MessageBox.Show("Há campos nulos.");
                return;
            }
            else
            {
                objCargoDTO.CodigoCargo = codigo;
                objCargoDTO.NomeCargo = cargo;

                resultado = objCargoBO.InserirCargo(objCargoDTO.CodigoCargo, objCargoDTO.NomeCargo);

                if (resultado)
                {
                    MessageBox.Show("Gravação efetuada com sucesso!");
                    this.Close();
                }
                else
                    MessageBox.Show("Ocorreu uma falha ao salvar o registro!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCargo_Load(object sender, EventArgs e)
        {
            VerificarOperacao(_tpOperacao);
        }

        private void VerificarOperacao(string operacao)
        {
            if (operacao.ToUpper() == "EDITAR")
            {
                txtCodigo.ReadOnly = true;
            }
            else
                txtCodigo.ReadOnly = false;
        }

        private DataTable dtCargoGeral()
        {
            DataTable dtCargoLocal = new DataTable();
            CargoBO objCargo = new CargoBO();
            dtCargoLocal = objCargo.ObterCargo(_codCargo);

            //TODO: Obter Cargo geral
            return dtCargoLocal;
        }

        private void PopularCampos()
        {
            Cargo objCargoEdit = new Cargo();
            DataTable dtCargo = new DataTable();

            dtCargo = dtCargoGeral();
            objCargoEdit.CodigoCargo = Int32.Parse(dtCargo.Rows[0][0].ToString());
            objCargoEdit.NomeCargo = dtCargo.Rows[0][1].ToString();

            txtCodigo.Text = objCargoEdit.CodigoCargo.ToString();
            txtCargo.Text = objCargoEdit.NomeCargo;
        }
    }
}
