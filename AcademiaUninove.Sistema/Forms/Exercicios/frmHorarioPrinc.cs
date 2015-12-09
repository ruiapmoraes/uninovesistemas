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
    public partial class frmHorarioPrinc : Form
    {
        #region Variáveis Globais
        string _tpOperacao = string.Empty;
        int _codHorario = 0;

        #endregion

        public frmHorarioPrinc()
        {
            InitializeComponent();
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            frmHorario telaHorario = new frmHorario();
            telaHorario.ShowDialog();
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

        private void frmHorarioPrinc_Load(object sender, EventArgs e)
        {
            dgvHorario.DataSource = DtHorarioGeral();
        }

        private DataTable DtHorarioGeral()
        {
            DataTable dtHorarioLocal = new DataTable();
            HorarioBO objHorario = new HorarioBO();
            dtHorarioLocal = objHorario.ObterHorario();

            //TODO: Obter Cargo geral
            return dtHorarioLocal;
        }

        private void dgvHorario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _tpOperacao = "editar";
            _codHorario = int.Parse(dgvHorario.Rows[e.RowIndex].Cells[0].Value.ToString());


            frmHorario telaHorario = new frmHorario(_tpOperacao, _codHorario);
            telaHorario.ShowDialog();
        }
    }
}
