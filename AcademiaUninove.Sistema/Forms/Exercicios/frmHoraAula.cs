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

namespace AcademiaUninove.Sistema.Forms.Exercicios
{
    public partial class frmHoraAula : Form
    {
        #region Variáveis globais
        private string _tpOperacao = string.Empty;
        private int _codHoraAula = 0;
        HoraAula objHoraAulaDTO = new HoraAula();
        HoraAulaBO objHoraAulaBO = new HoraAulaBO();
        Validacao objValidacao = new Validacao();
        #endregion

        public frmHoraAula()
        {
            InitializeComponent();
        }

        public frmHoraAula(string operacao, int codigo)
        {
            // TODO: Complete member initialization
            _tpOperacao = operacao;
            _codHoraAula = codigo;
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

        private void frmHoraAula_Load(object sender, EventArgs e)
        {
            VerificarOperacao(_tpOperacao);
        }

        private void VerificarOperacao(string operacao)
        {
            if (operacao.ToUpper() == "EDITAR")
            {
                txtCodigo.ReadOnly = true;
                //TODO: Obter instrutores e Aulas
                //CarregaComboInstrutor();
                CarregaComboAula();
                txtCodigo.Text = _codHoraAula.ToString();
                txtCodigo.Focus();
            }
            else
            {
                txtCodigo.ReadOnly = false;
                //TODO: Obter instrutores e Aulas
                //CarregaComboInstrutor();
                CarregaComboAula();
                txtCodigo.Focus();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_tpOperacao))
            {
                AtualizaHoraAula(int.Parse(txtCodigo.Text),
                                      dtpHorario.Value,
                                      int.Parse(cmbAula.SelectedValue.ToString()));
            }
            else
                InsereHoraAula(int.Parse(txtCodigo.Text),
                                      dtpHorario.Value,
                                      int.Parse(cmbAula.SelectedValue.ToString()));
        }

        private void InsereHoraAula(int p1, DateTime dateTime, int p2)
        {
            throw new NotImplementedException();
        }

        private void AtualizaHoraAula(int p1, DateTime dateTime, int p2)
        {
            throw new NotImplementedException();
        }
    }
}
