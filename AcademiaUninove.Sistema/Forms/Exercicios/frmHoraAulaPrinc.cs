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
            int linha = 0;
            _tpOperacao = "editar";

            linha = dgvHoraAula.CurrentRow.Index;
            _codHoraAula = int.Parse(dgvHoraAula.Rows[linha].Cells[0].Value.ToString());

            frmHoraAula telaHoraAula = new frmHoraAula(_tpOperacao, _codHoraAula);
            telaHoraAula.ShowDialog();
        }

        private void tsbDeletar_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            int linha = 0;


            linha = dgvHoraAula.CurrentRow.Index;
            _codHoraAula = int.Parse(dgvHoraAula.Rows[linha].Cells[0].Value.ToString());
            HoraAulaBO objHoraAula = new HoraAulaBO();

            if (MessageBox.Show("Confirma exclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                resultado = objHoraAula.ExcluiHoraAula(_codHoraAula);
                if (resultado)
                {
                    MessageBox.Show("Registro excluído com sucesso!");
                    //dgvFuncAula.DataSource = DtFuncAula();
                    dgvHoraAula.DataSource = DadosHoraAula(int.Parse(cmbAula.SelectedValue.ToString()));
                    dgvHoraAula.Columns[1].Visible = false;
                    dgvHoraAula.Columns[3].Visible = false;
                }
            }
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

        public DataTable DadosHoraAula()
        {
            DataTable dtHoraAula = new DataTable();
            HoraAulaBO objHoraAula = new HoraAulaBO();
            dtHoraAula = objHoraAula.ObterHoraAula();

            return dtHoraAula;
        }

        public DataTable DadosHoraAula(int codigo)
        {
            DataTable dtHoraAula = new DataTable();
            HoraAulaBO objHoraAula = new HoraAulaBO();
            dtHoraAula = objHoraAula.ObterHoraAula(codigo);

            return dtHoraAula;
        }

        private void cmbAula_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvHoraAula.DataSource = DadosHoraAula(int.Parse(cmbAula.SelectedValue.ToString()));
            //TODO: Ver quais campos se deve ocultar

        }

        private void dgvHoraAula_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _tpOperacao = "editar";
            _codHoraAula = int.Parse(dgvHoraAula.Rows[e.RowIndex].Cells[0].Value.ToString());

            frmHoraAula telaHoraAula = new frmHoraAula(_tpOperacao, _codHoraAula);
            telaHoraAula.ShowDialog();
        }
    }
}
