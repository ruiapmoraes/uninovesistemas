using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using AcademiaUninove.Sistema.Helpers;
using AcademiaUninove.Sistema.Classes;
using AcademiaUninove.Sistema.Negocio;

namespace AcademiaUninove.Sistema.Forms.Cadastro
{
    public partial class frmAula : Form
    {
        #region variáveis globais
        string _tpOperacao = string.Empty;
        int _codAula = 0;
        Aula objAulaDTO = new Aula();
        AulaBO objAulaBO = new AulaBO();
        Validacao objValidacao = new Validacao();
        #endregion

        public frmAula()
        {
            InitializeComponent();
        }

        public frmAula(string tpOperacao, int codigo)
        {
            InitializeComponent();
            _tpOperacao = tpOperacao;
            _codAula = codigo;
            PopularCampos();
        }

        private void PopularCampos()
        {
            Aula objAulaEdit = new Aula();
            DataTable dtAula = new DataTable();

            dtAula = dtAulaGeral();
            objAulaEdit.CodigoAula = Int32.Parse(dtAula.Rows[0][0].ToString());
            objAulaEdit.NomeAula = dtAula.Rows[0][1].ToString();

            txtCodigo.Text = objAulaEdit.CodigoAula.ToString();
            txtAula.Text = objAulaEdit.NomeAula;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_tpOperacao))
            {
                AtualizarAula(Int32.Parse(txtCodigo.Text), txtAula.Text);
            }
            else
                InserirAula(Int32.Parse(txtCodigo.Text), txtAula.Text);

            this.Close();
        }

        private void InserirAula(int codigo, string aula)
        {
            bool resultado;

            if (objValidacao.NumeroPreenchido(codigo) && objValidacao.CamposPreechidos(aula))
            {
                //Verificar usuario no banco
                MessageBox.Show("Há campos nulos.");
                return;
            }
            else
            {
                objAulaDTO.CodigoAula = codigo;
                objAulaDTO.NomeAula = aula;

                resultado = objAulaBO.InserirAula(objAulaDTO.CodigoAula, objAulaDTO.NomeAula);

                if (resultado)
                {
                    MessageBox.Show("Gravação efetuada com sucesso!");
                    this.Close();
                }
                else
                    MessageBox.Show("Ocorreu uma falha ao salvar o registro!");
            }
        }

        private void AtualizarAula(int codigo, string aula)
        {
            bool resultado;

            if (objValidacao.NumeroPreenchido(codigo) && objValidacao.CamposPreechidos(aula))
            {
                //Verificar usuario no banco
                MessageBox.Show("Há campos nulos.");
                return;
            }
            else
            {
                objAulaDTO.CodigoAula = codigo;
                objAulaDTO.NomeAula = aula;

                resultado = objAulaBO.AtualizaAula(objAulaDTO.CodigoAula, objAulaDTO.NomeAula);

                if (resultado)
                {
                    MessageBox.Show("Atualização efetuada com sucesso!");
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

        private void frmAula_Load(object sender, EventArgs e)
        {

        }

        private DataTable dtAulaGeral()
        {

            DataTable dtAulaLocal = new DataTable();
            AulaBO objAulaBO = new AulaBO();
            dtAulaLocal = objAulaBO.ObterAula(_codAula);

            return dtAulaLocal;
        }
    }
}
