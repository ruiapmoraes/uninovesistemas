namespace AcademiaUninove.Sistema.Forms.Cadastro
{
    partial class frmFuncAulaPrinc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncAulaPrinc));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNovo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbDeletar = new System.Windows.Forms.ToolStripButton();
            this.tsbFechar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvFuncAula = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbInstrutor = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncAula)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNovo,
            this.tsbEditar,
            this.tsbDeletar,
            this.tsbFechar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(419, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNovo
            // 
            this.tsbNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNovo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNovo.Image")));
            this.tsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovo.Name = "tsbNovo";
            this.tsbNovo.Size = new System.Drawing.Size(23, 22);
            this.tsbNovo.Text = "Novo";
            this.tsbNovo.Click += new System.EventHandler(this.tsbNovo_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbDeletar
            // 
            this.tsbDeletar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeletar.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeletar.Image")));
            this.tsbDeletar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeletar.Name = "tsbDeletar";
            this.tsbDeletar.Size = new System.Drawing.Size(23, 22);
            this.tsbDeletar.Text = "Deletar";
            this.tsbDeletar.Click += new System.EventHandler(this.tsbDeletar_Click);
            // 
            // tsbFechar
            // 
            this.tsbFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFechar.Image = ((System.Drawing.Image)(resources.GetObject("tsbFechar.Image")));
            this.tsbFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFechar.Name = "tsbFechar";
            this.tsbFechar.Size = new System.Drawing.Size(23, 22);
            this.tsbFechar.Text = "Fechar";
            this.tsbFechar.Click += new System.EventHandler(this.tsbFechar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvFuncAula);
            this.groupBox1.Location = new System.Drawing.Point(2, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 228);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Aulas";
            // 
            // dgvFuncAula
            // 
            this.dgvFuncAula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncAula.Location = new System.Drawing.Point(7, 20);
            this.dgvFuncAula.Name = "dgvFuncAula";
            this.dgvFuncAula.ReadOnly = true;
            this.dgvFuncAula.Size = new System.Drawing.Size(377, 202);
            this.dgvFuncAula.TabIndex = 0;
            this.dgvFuncAula.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncAula_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Instrutor";
            // 
            // cmbInstrutor
            // 
            this.cmbInstrutor.FormattingEnabled = true;
            this.cmbInstrutor.Location = new System.Drawing.Point(73, 53);
            this.cmbInstrutor.Name = "cmbInstrutor";
            this.cmbInstrutor.Size = new System.Drawing.Size(259, 21);
            this.cmbInstrutor.TabIndex = 12;
            this.cmbInstrutor.SelectedIndexChanged += new System.EventHandler(this.cmbInstrutor_SelectedIndexChanged);
            this.cmbInstrutor.SelectedValueChanged += new System.EventHandler(this.cmbInstrutor_SelectedValueChanged);
            // 
            // frmFuncAulaPrinc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 331);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbInstrutor);
            this.Name = "frmFuncAulaPrinc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro das Aulas do Instrutor";
            this.Load += new System.EventHandler(this.frmFuncAulaPrinc_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncAula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNovo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbDeletar;
        private System.Windows.Forms.ToolStripButton tsbFechar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvFuncAula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbInstrutor;
    }
}