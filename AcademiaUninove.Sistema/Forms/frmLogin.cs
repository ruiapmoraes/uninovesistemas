using AcademiaUninove.Sistema.Classes;
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

namespace AcademiaUninove.Sistema.Forms
{
    public partial class frmLogin : Form
    {
        #region Variáveis globais
        LoginBO objLoginBO = new LoginBO();
        Login objLoginDTO = new Login();
        #endregion

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Campos Preenchidos
        /// </summary>
        /// <param name="campo">Campo</param>
        /// <returns>Retorna se o campo está nulo</returns>
        private bool CamposPreechidos(string campo)
        {
            if (!string.IsNullOrEmpty(campo))
            {
                return false;
            }
            else
                return true;
        }

        /// <summary>
        /// Buscar Login
        /// </summary>
        private void VerificaLogin()
        {
            if (CamposPreechidos(txtUsuario.Text) && CamposPreechidos(txtSenha.Text))
            {
                //Verificar usuario no banco
                MessageBox.Show("O campo está nulo.");
                return;
            }
            else
            {

                objLoginDTO.Usuario = txtUsuario.Text.Trim();
                objLoginDTO.Senha = txtSenha.Text.Trim();




                bool resultado = objLoginBO.VerificaLogin(objLoginDTO.Usuario, objLoginDTO.Senha);

                if (resultado)
                {
                    MessageBox.Show("Usuário " + objLoginDTO.Usuario + " logado com sucesso. ", "Academia Univnove");
                    //TODO: Em caso de sucesso, redirecionar para o formulário principal
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Usuário não encontrado", "Academia Uninove",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Clear();
                    txtSenha.Clear();
                    txtUsuario.Focus();
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            VerificaLogin();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VerificaLogin();
            }
        }
    }
}
