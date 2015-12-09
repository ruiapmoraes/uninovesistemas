using AcademiaUninove.Sistema.Classes;
using AcademiaUninove.Sistema.Helpers;
using AcademiaUninove.Sistema.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaUninove.Sistema.Forms.Exercicios
{
    public partial class frmHorario : Form
    {
        #region variáveis globais
        string _tpOperacao = string.Empty;
        int _codHorario = 0;
        Horario objHorarioDTO = new Horario();
        HorarioBO objHorarioBO = new HorarioBO();
        Validacao objValidacao = new Validacao();
        #endregion

        public frmHorario()
        {
            InitializeComponent();
        }

        public frmHorario(string operacao, int codigo)
        {
            InitializeComponent();
            _tpOperacao = operacao;
            _codHorario = codigo;
            PopulaCampos();
        }

        private void PopulaCampos()
        {
            CultureInfo culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            culture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy HH:mm:ss";
            culture.DateTimeFormat.LongTimePattern = "";
            Thread.CurrentThread.CurrentCulture = culture;

            Horario objHorarioEdit = new Horario();
            DataTable dtHorario = new DataTable();

            dtHorario = DtHorarioGeral();
            objHorarioEdit.CodigoHorario = Int32.Parse(dtHorario.Rows[0][0].ToString());
            objHorarioEdit.DataHorario = DateTime.Parse(dtHorario.Rows[0][1].ToString());
            objHorarioEdit.Hora = DateTime.Parse(dtHorario.Rows[0][2].ToString());

            txtCodigo.Text = objHorarioEdit.CodigoHorario.ToString();
            txtDataHorario.Text = objHorarioEdit.DataHorario.ToString();
            txtHora.Text  = objHorarioEdit.Hora.ToString();
        }

        private DataTable DtHorarioGeral()
        {
            DataTable dtHorarioLocal = new DataTable();
            HorarioBO objHorarioBO = new HorarioBO();
            dtHorarioLocal = objHorarioBO.ObterHorario(_codHorario);

            return dtHorarioLocal;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(_tpOperacao))
            {
                AtualizaHorario(Int32.Parse(txtCodigo.Text),
                              DateTime.Parse(txtDataHorario.Text),
                              DateTime.Parse(txtHora.Text));
            }
            else
                InsereHorario(Int32.Parse(txtCodigo.Text),
                              DateTime.Parse(txtDataHorario.Text),
                              DateTime.Parse(txtHora.Text));

            this.Close();
        }

        private void InsereHorario(int codigo, DateTime dataHorario, DateTime hora)
        {
            bool resultado;


            objHorarioDTO.CodigoHorario = codigo;
            objHorarioDTO.DataHorario = dataHorario;
            objHorarioDTO.Hora = hora;;

            resultado = objHorarioBO.InsereHorario(objHorarioDTO.CodigoHorario,
                                                   objHorarioDTO.DataHorario,
                                                   objHorarioDTO.Hora);

            if (resultado)
            {
                MessageBox.Show("Gravação efetuada com sucesso!");
                this.Close();
            }
            else
                MessageBox.Show("Ocorreu uma falha ao salvar o registro!");

        }

        private void AtualizaHorario(int codigo, DateTime dataHorario, DateTime hora)
        {
            bool resultado;


            objHorarioDTO.CodigoHorario = codigo;
            objHorarioDTO.DataHorario = dataHorario;
            objHorarioDTO.Hora = hora; ;

            resultado = objHorarioBO.AtualizaHorario(objHorarioDTO.CodigoHorario,
                                                   objHorarioDTO.DataHorario,
                                                   objHorarioDTO.Hora);

            if (resultado)
            {
                MessageBox.Show("Gravação efetuada com sucesso!");
                this.Close();
            }
            else
                MessageBox.Show("Ocorreu uma falha ao salvar o registro!");
        }
    }
}
