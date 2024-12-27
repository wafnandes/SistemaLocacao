namespace GirassoisLocacoes.Forms
{
    partial class frmTaxaEntrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaxaEntrega));
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPadraoConfirmar = new System.Windows.Forms.ToolStripButton();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPadraoConfirmar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 51);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(157, 27);
            this.toolStrip1.TabIndex = 1065;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPadraoConfirmar
            // 
            this.btnPadraoConfirmar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPadraoConfirmar.Image = global::GirassoisLocacoes.Forms.Properties.Resources.confirme2;
            this.btnPadraoConfirmar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPadraoConfirmar.Name = "btnPadraoConfirmar";
            this.btnPadraoConfirmar.Size = new System.Drawing.Size(24, 24);
            this.btnPadraoConfirmar.Text = "Confirmar";
            this.btnPadraoConfirmar.Click += new System.EventHandler(this.btnPadraoConfirmar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(59, 16);
            this.txtValor.MaxLength = 6;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(73, 20);
            this.txtValor.TabIndex = 1066;
            this.txtValor.Text = "0,00";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValor_KeyDown);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // frmTaxaEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(157, 78);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTaxaEntrega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taxa de Entrega";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTaxaEntrega_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPadraoConfirmar;
        private System.Windows.Forms.TextBox txtValor;
    }
}