namespace GirassoisLocacoes.Forms
{
    partial class frmInserirOcorrencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInserirOcorrencia));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPadraoConfirmar = new System.Windows.Forms.ToolStripButton();
            this.btnPadraoNovo = new System.Windows.Forms.ToolStripButton();
            this.txtDescOcorrencia = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblNroReserva = new System.Windows.Forms.Label();
            this.chkReposicao = new System.Windows.Forms.CheckBox();
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.cboQtde = new System.Windows.Forms.ComboBox();
            this.gpoItem = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.gpoItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPadraoConfirmar,
            this.btnPadraoNovo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 164);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(525, 27);
            this.toolStrip1.TabIndex = 1006;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPadraoConfirmar
            // 
            this.btnPadraoConfirmar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPadraoConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btnPadraoConfirmar.Image")));
            this.btnPadraoConfirmar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPadraoConfirmar.Name = "btnPadraoConfirmar";
            this.btnPadraoConfirmar.Size = new System.Drawing.Size(24, 24);
            this.btnPadraoConfirmar.Text = "Confirmar";
            this.btnPadraoConfirmar.Click += new System.EventHandler(this.btnPadraoConfirmar_Click);
            // 
            // btnPadraoNovo
            // 
            this.btnPadraoNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPadraoNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnPadraoNovo.Image")));
            this.btnPadraoNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPadraoNovo.Name = "btnPadraoNovo";
            this.btnPadraoNovo.Size = new System.Drawing.Size(24, 24);
            this.btnPadraoNovo.Text = "Limpar";
            this.btnPadraoNovo.Click += new System.EventHandler(this.btnPadraoNovo_Click);
            // 
            // txtDescOcorrencia
            // 
            this.txtDescOcorrencia.Location = new System.Drawing.Point(4, 25);
            this.txtDescOcorrencia.MaxLength = 200;
            this.txtDescOcorrencia.Multiline = true;
            this.txtDescOcorrencia.Name = "txtDescOcorrencia";
            this.txtDescOcorrencia.Size = new System.Drawing.Size(517, 73);
            this.txtDescOcorrencia.TabIndex = 1007;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(170, 13);
            this.label15.TabIndex = 1021;
            this.label15.Text = "Resumo da ocorrência na reserva ";
            // 
            // lblNroReserva
            // 
            this.lblNroReserva.AutoSize = true;
            this.lblNroReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroReserva.Location = new System.Drawing.Point(168, 9);
            this.lblNroReserva.Name = "lblNroReserva";
            this.lblNroReserva.Size = new System.Drawing.Size(0, 13);
            this.lblNroReserva.TabIndex = 1022;
            // 
            // chkReposicao
            // 
            this.chkReposicao.AutoSize = true;
            this.chkReposicao.Location = new System.Drawing.Point(14, 102);
            this.chkReposicao.Name = "chkReposicao";
            this.chkReposicao.Size = new System.Drawing.Size(129, 17);
            this.chkReposicao.TabIndex = 1023;
            this.chkReposicao.Text = "Cliente danificou itens";
            this.chkReposicao.UseVisualStyleBackColor = true;
            this.chkReposicao.CheckedChanged += new System.EventHandler(this.chkReposicao_CheckedChanged);
            // 
            // cboItem
            // 
            this.cboItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Location = new System.Drawing.Point(117, 22);
            this.cboItem.MaxDropDownItems = 4;
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(164, 21);
            this.cboItem.TabIndex = 1024;
            this.cboItem.SelectedValueChanged += new System.EventHandler(this.cboItem_SelectedValueChanged);
            // 
            // cboQtde
            // 
            this.cboQtde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQtde.Enabled = false;
            this.cboQtde.FormattingEnabled = true;
            this.cboQtde.Location = new System.Drawing.Point(427, 22);
            this.cboQtde.MaxDropDownItems = 5;
            this.cboQtde.Name = "cboQtde";
            this.cboQtde.Size = new System.Drawing.Size(50, 21);
            this.cboQtde.TabIndex = 1025;
            // 
            // gpoItem
            // 
            this.gpoItem.BackColor = System.Drawing.SystemColors.Control;
            this.gpoItem.Controls.Add(this.label2);
            this.gpoItem.Controls.Add(this.label1);
            this.gpoItem.Controls.Add(this.cboQtde);
            this.gpoItem.Controls.Add(this.cboItem);
            this.gpoItem.Enabled = false;
            this.gpoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoItem.Location = new System.Drawing.Point(4, 104);
            this.gpoItem.Name = "gpoItem";
            this.gpoItem.Size = new System.Drawing.Size(517, 56);
            this.gpoItem.TabIndex = 1026;
            this.gpoItem.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1027;
            this.label2.Text = "Quantidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1026;
            this.label1.Text = "Item danificado";
            // 
            // frmInserirOcorrencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 191);
            this.Controls.Add(this.chkReposicao);
            this.Controls.Add(this.gpoItem);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblNroReserva);
            this.Controls.Add(this.txtDescOcorrencia);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInserirOcorrencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Ocorrência";
            this.Load += new System.EventHandler(this.frmInserirOcorrencia_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmInserirOcorrencia_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gpoItem.ResumeLayout(false);
            this.gpoItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPadraoConfirmar;
        private System.Windows.Forms.ToolStripButton btnPadraoNovo;
        private System.Windows.Forms.TextBox txtDescOcorrencia;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblNroReserva;
        private System.Windows.Forms.CheckBox chkReposicao;
        private System.Windows.Forms.ComboBox cboItem;
        private System.Windows.Forms.ComboBox cboQtde;
        private System.Windows.Forms.GroupBox gpoItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}