﻿using System;
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
    public partial class frmFrequenciaPrinc : Form
    {
        public frmFrequenciaPrinc()
        {
            InitializeComponent();
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            frmFrequencia telaFreq = new frmFrequencia();
            telaFreq.ShowDialog();
        }
    }
}
