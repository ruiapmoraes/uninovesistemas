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

namespace AcademiaUninove.Sistema.Forms.Cadastro
{
    public partial class frmAluno : Form
    {
        #region Variáveis Globais
        private string _tpOperacao = string.Empty;
        private int _codAluno = 0;
        Aluno objAlunoDTO = new Aluno();
        AlunoBO objAlunoBO = new AlunoBO();
        Validacao objValidacao = new Validacao();
        #endregion

        public frmAluno()
        {
            InitializeComponent();
        }

        public frmAluno(string operacao, int codigo)
        {
            InitializeComponent();
            _tpOperacao = operacao;
            _codAluno = codigo;
        }

        private void frmAluno_Load(object sender, EventArgs e)
        {
            VerificaOperacao(_tpOperacao);
        }

        private void VerificaOperacao(string operacao)
        {
            if (operacao.ToUpper() == "EDITAR")
            {
                txtCodigo.ReadOnly = true;
                CarregaCamposAluno(_codAluno);
                //CarregaCamposFuncionario(_codFunc);
            }
            else
            {
                txtCodigo.ReadOnly = false;
                CarregaComboInstrutor();
            }
        }

        private void CarregaCamposAluno(int codigo)
        {
            DataTable dtInstrutorCombo = null;
            DataTable dtAluno = null;
            int intContador = 0;
            int linha = 0;

            FuncionarioBO objFuncionarioBO = new FuncionarioBO();
            AlunoBO objAlunoBO = new AlunoBO();
            dtAluno = objAlunoBO.ObterAluno(codigo);

            if (dtAluno.Rows.Count <= 0 || dtAluno == null)
            {
                return;
            }
            else
            {
                linha = int.Parse(dtAluno.Rows[0][1].ToString());
                dtInstrutorCombo = objFuncionarioBO.ObterFuncionario(linha);
                //dtInstrutorCombo.DefaultView.Sort = "Cargo asc";


                if (dtInstrutorCombo.Rows.Count < 0 && dtInstrutorCombo == null)
                {
                    intContador = 0;
                    cmbInstrutor.Items.Clear();
                }
                else
                {
                    cmbInstrutor.ValueMember = "Código";
                    cmbInstrutor.DisplayMember = "Nome Funcionário";
                    cmbInstrutor.DataSource = dtInstrutorCombo;

                    txtCodigo.Text = dtAluno.Rows[0][0].ToString();
                    txtAuno.Text = dtAluno.Rows[0][3].ToString();
                    txtCPF.Text = dtAluno.Rows[0][4].ToString();
                    txtRG.Text = dtAluno.Rows[0][5].ToString();
                    txtDataNasc.Text = dtAluno.Rows[0][6].ToString();
                    txtTelRes.Text = dtAluno.Rows[0][7].ToString();
                    txtTelCel.Text = dtAluno.Rows[0][8].ToString();
                    txtEndereco.Text = dtAluno.Rows[0][9].ToString();
                    txtCidade.Text = dtAluno.Rows[0][10].ToString();
                    txtCEP.Text = dtAluno.Rows[0][11].ToString();
                    txtStatusAluno.Text = dtAluno.Rows[0][12].ToString();
                    txtRestricao.Text = dtAluno.Rows[0][13].ToString();
                    txtObjetivo.Text = dtAluno.Rows[0][14].ToString();

                }
            }
        }

        private void CarregaComboInstrutor()
        {
            DataTable dtInstrutorCombo = null;

            int intContador = 0;
            FuncionarioBO objFuncionarioBO = new FuncionarioBO();
            dtInstrutorCombo = objFuncionarioBO.ObterFuncionario();
            dtInstrutorCombo.DefaultView.Sort = "Nome Funcionário asc";


            if (dtInstrutorCombo.Rows.Count < 0 && dtInstrutorCombo == null)
            {
                intContador = 0;
                cmbInstrutor.Items.Clear();
            }
            else
            {
                cmbInstrutor.ValueMember = "Código";
                cmbInstrutor.DisplayMember = "Nome Funcionário";
                cmbInstrutor.DataSource = dtInstrutorCombo;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_tpOperacao))
            {
                AtualizarAluno(Int32.Parse(txtCodigo.Text)
                    , Int32.Parse(cmbInstrutor.SelectedValue.ToString())
                    , txtAuno.Text
                    , txtCPF.Text
                    , txtRG.Text
                    , DateTime.Parse(txtDataNasc.Text)
                    , txtTelRes.Text
                    , txtTelCel.Text
                    , txtEndereco.Text
                    , txtCidade.Text
                    , txtCEP.Text
                    , txtStatusAluno.Text
                    , txtRestricao.Text
                    , txtObjetivo.Text

                    );
            }
            else
                InserirAluno(Int32.Parse(txtCodigo.Text)
                    , Int32.Parse(cmbInstrutor.SelectedValue.ToString())
                    , txtAuno.Text
                    , txtCPF.Text
                    , txtRG.Text
                    , DateTime.Parse(txtDataNasc.Text)
                    , txtTelRes.Text
                    , txtTelCel.Text
                    , txtEndereco.Text
                    , txtCidade.Text
                    , txtCEP.Text
                    , txtStatusAluno.Text
                    , txtRestricao.Text
                    , txtObjetivo.Text

                    );

            this.Close();
        }

        private void InserirAluno(int codigo
                                    , int codInstrutor
                                    , string nomeAluno
                                    , string cpf
                                    , string rg
                                    , DateTime dtNasc
                                    , string telRes
                                    , string telCel
                                    , string endereco
                                    , string cidade
                                    , string cep
                                    , string statusAluno
                                    , string restricao
                                    , string objetivo)
        {
             bool resultado = false;

            //TODO: inserir o codigo aqui
            objAlunoDTO.CodigoAluno = codigo;
            objAlunoDTO.CodigoFunc = codInstrutor;
            objAlunoDTO.NomeAluno = nomeAluno;
            objAlunoDTO.CpfAluno = cpf;
            objAlunoDTO.RgAluno = rg;
            objAlunoDTO.DtNascAluno = dtNasc;
            objAlunoDTO.TelResAluno = telRes;
            objAlunoDTO.TelCelAluno = telCel;
            objAlunoDTO.EndAluno = endereco;
            objAlunoDTO.CidadeAluno = cidade;
            objAlunoDTO.CepAluno = cep;
            objAlunoDTO.StatusAluno = statusAluno;
            objAlunoDTO.RestricaoAluno = restricao;
            objAlunoDTO.ObjetivoAluno = objetivo;

            resultado = objAlunoBO.InserirAluno(objAlunoDTO.CodigoAluno
                                    ,objAlunoDTO.CodigoFunc
                                    ,objAlunoDTO.NomeAluno
                                    ,objAlunoDTO.CpfAluno
                                    ,objAlunoDTO.RgAluno 
                                    ,objAlunoDTO.DtNascAluno
                                    ,objAlunoDTO.TelResAluno
                                    ,objAlunoDTO.TelCelAluno
                                    ,objAlunoDTO.EndAluno 
                                    ,objAlunoDTO.CidadeAluno 
                                    ,objAlunoDTO.CepAluno 
                                    ,objAlunoDTO.StatusAluno
                                    ,objAlunoDTO.RestricaoAluno
                                    ,objAlunoDTO.ObjetivoAluno                 
                                );

            if (resultado)
            {
                MessageBox.Show("Gravação efetuada com sucesso!");
                this.Close();
            }
            else
                MessageBox.Show("Ocorreu uma falha ao salvar o registro!");
        }

        private void AtualizarAluno(int codigo
                                    , int codInstrutor
                                    , string nomeAluno
                                    , string cpf
                                    , string rg
                                    , DateTime dtNasc
                                    , string telRes
                                    , string telCel
                                    , string endereco
                                    , string cidade
                                    , string cep
                                    , string statusAluno
                                    , string restricao
                                    , string objetivo)
        {
            bool resultado = false;

            //TODO: inserir o codigo aqui
            objAlunoDTO.CodigoAluno = codigo;
            objAlunoDTO.CodigoFunc = codInstrutor;
            objAlunoDTO.NomeAluno = nomeAluno;
            objAlunoDTO.CpfAluno = cpf;
            objAlunoDTO.RgAluno = rg;
            objAlunoDTO.DtNascAluno = dtNasc;
            objAlunoDTO.TelResAluno = telRes;
            objAlunoDTO.TelCelAluno = telCel;
            objAlunoDTO.EndAluno = endereco;
            objAlunoDTO.CidadeAluno = cidade;
            objAlunoDTO.CepAluno = cep;
            objAlunoDTO.StatusAluno = statusAluno;
            objAlunoDTO.RestricaoAluno = restricao;
            objAlunoDTO.ObjetivoAluno = objetivo;

            resultado = objAlunoBO.AtualizaAluno(objAlunoDTO.CodigoAluno
                                    ,objAlunoDTO.CodigoFunc
                                    ,objAlunoDTO.NomeAluno
                                    ,objAlunoDTO.CpfAluno
                                    ,objAlunoDTO.RgAluno 
                                    ,objAlunoDTO.DtNascAluno
                                    ,objAlunoDTO.TelResAluno
                                    ,objAlunoDTO.TelCelAluno
                                    ,objAlunoDTO.EndAluno 
                                    ,objAlunoDTO.CidadeAluno 
                                    ,objAlunoDTO.CepAluno 
                                    ,objAlunoDTO.StatusAluno
                                    ,objAlunoDTO.RestricaoAluno
                                    ,objAlunoDTO.ObjetivoAluno                 
                                );            
          
            if (resultado)
            {
                MessageBox.Show("Atualização efetuada com sucesso!");
                this.Close();
            }
            else
                MessageBox.Show("Ocorreu uma falha ao salvar o registro!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
