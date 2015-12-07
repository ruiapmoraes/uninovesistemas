using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcademiaUninove.Sistema.Forms;
using AcademiaUninove.Sistema.Negocio;

namespace AcademiaUninove.Sistema.Forms.Cadastro
{
    public partial class frmAulaPrinc : Form
    {
        public frmAulaPrinc()
        {
            InitializeComponent();
        }
        #region Variáveis Globais
        string _tpOperacao = string.Empty;
        int _codAula = 0;
        string _nomeAula = string.Empty;
        #endregion

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            frmAula telaAula = new frmAula();
            telaAula.ShowDialog();
        }

        private void frmAulaPrinc_Load(object sender, EventArgs e)
        {
            dgvAula.DataSource = dtAulaGeral();
        }

        private DataTable dtAulaGeral()
        {
            DataTable dtAulaLocal = new DataTable();
            AulaBO objAulaBO = new AulaBO();
            dtAulaLocal = objAulaBO.ObterAula();

            //TODO: Obter Cargo geral
            return dtAulaLocal;
        }

        private void dgvAula_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            _tpOperacao = "editar";
            _codAula = int.Parse(dgvAula.Rows[e.RowIndex].Cells[0].Value.ToString());


            frmAula telaAula = new frmAula(_tpOperacao, _codAula);
            telaAula.Show();
        }

        private void tsbDeletar_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            int linha = 0;


            linha = dgvAula.CurrentRow.Index;
            _codAula = int.Parse(dgvAula.Rows[linha].Cells[0].Value.ToString());
            AulaBO objAulaBO = new AulaBO();

            if (MessageBox.Show("Confirma exclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                resultado = objAulaBO.ExcluiAula(_codAula);
                if (resultado)
                {
                    MessageBox.Show("Registro excluído com sucesso!");
                    dgvAula.DataSource = dtAulaGeral();
                }
            }
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
