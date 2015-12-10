using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcademiaUninove.Sistema.Forms.Cadastro;
using System.Threading;
using AcademiaUninove.Sistema.Forms.Exercicios;

namespace AcademiaUninove.Sistema.Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

         
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargoPrinc telaCargo = new frmCargoPrinc();
            telaCargo.MdiParent = this;
            telaCargo.Show();
        }

        private void aulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncionarioPrinc telaFunc = new frmFuncionarioPrinc();
            telaFunc.MdiParent = this;
            telaFunc.Show();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlunoPrinc telaAluno = new frmAlunoPrinc();
            telaAluno.MdiParent = this;
            telaAluno.Show();
        }

        private void medidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedidasPrinc telaMedidas = new frmMedidasPrinc();
            telaMedidas.MdiParent = this;
            telaMedidas.Show();
        }

        private void horárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHorarioPrinc telaHorario = new frmHorarioPrinc();
            telaHorario.MdiParent = this;
            telaHorario.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHoraAulaPrinc telaHoraAula = new frmHoraAulaPrinc();
            telaHoraAula.MdiParent = this;
            telaHoraAula.Show();
        }

        private void frequênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFrequenciaPrinc telaFreq = new frmFrequenciaPrinc();
            telaFreq.MdiParent = this;
            telaFreq.Show();
        }

        private void fichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFichaExerciciosPrinc telaFicha = new frmFichaExerciciosPrinc();
            telaFicha.MdiParent = this;
            telaFicha.Show();
        }

        private void aulaDosInstrutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncAulaPrinc telaFuncAula = new frmFuncAulaPrinc();
            telaFuncAula.MdiParent = this;
            telaFuncAula.Show();
        }

        private void fecharTodasAsJanelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChildForm in MdiChildren)
            {
                mdiChildForm.Close();
            }
        }

        private void cadastroDeAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAulaPrinc telaAula = new frmAulaPrinc();
            telaAula.MdiParent = this;
            telaAula.Show();
        }
    }
}
