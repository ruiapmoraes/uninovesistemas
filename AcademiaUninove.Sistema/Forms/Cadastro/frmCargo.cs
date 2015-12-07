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

        #region Variáveis Globais
        Cargo objCargoDTO = new Cargo();
        CargoBO objCargoBO = new CargoBO();
        Validacao objValidacao = new Validacao();
        #endregion


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            InserirCargo(Int32.Parse(txtCodigo.Text), txtCargo.Text);


            this.Close();
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
    }
}
