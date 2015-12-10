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

namespace AcademiaUninove.Sistema.Forms.Exercicios
{
    public partial class frmHoraAulaPrinc : Form
    {
        #region Variáveis globais
        string _tpOperacao = string.Empty;
        int _codHoraAula = 0;
        #endregion
        public frmHoraAulaPrinc()
        {
            InitializeComponent();
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            frmHoraAula telaHoraAula = new frmHoraAula();
            telaHoraAula.ShowDialog();
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

        private void frmHoraAulaPrinc_Load(object sender, EventArgs e)
        {
            CarregaComboAula();
        }

        private void CarregaComboAula() {
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

        private void CarregaComboAula(int codigo)
        {
            DataTable dtAulaCombo = null;
            int intContador = 0;
            AulaBO objAulaBO = new AulaBO();
            dtAulaCombo = objAulaBO.ObterAula(codigo);
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
    }
}
