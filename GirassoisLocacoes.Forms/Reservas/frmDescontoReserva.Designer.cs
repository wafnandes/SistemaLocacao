namespace GirassoisLocacoes.Forms
{
    partial class frmDescontoReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDescontoReserva));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVlrAtualReserva = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVlrDesconto = new System.Windows.Forms.TextBox();
            this.txtPercDesconto = new System.Windows.Forms.TextBox();
            this.txtNovoVlrReserva = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPadraoConfirmar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor atual da reserva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "___________________________________";
            // 
            // lblVlrAtualReserva
            // 
            this.lblVlrAtualReserva.BackColor = System.Drawing.Color.White;
            this.lblVlrAtualReserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVlrAtualReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlrAtualReserva.Location = new System.Drawing.Point(128, 6);
            this.lblVlrAtualReserva.Name = "lblVlrAtualReserva";
            this.lblVlrAtualReserva.Size = new System.Drawing.Size(89, 20);
            this.lblVlrAtualReserva.TabIndex = 1076;
            this.lblVlrAtualReserva.Text = "0,00";
            this.lblVlrAtualReserva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 1081;
            this.label9.Text = "% do Desconto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 1080;
            this.label8.Text = "Valor do Desconto";
            // 
            // txtVlrDesconto
            // 
            this.txtVlrDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVlrDesconto.Location = new System.Drawing.Point(128, 68);
            this.txtVlrDesconto.Name = "txtVlrDesconto";
            this.txtVlrDesconto.Size = new System.Drawing.Size(89, 20);
            this.txtVlrDesconto.TabIndex = 2;
            this.txtVlrDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVlrDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVlrDesconto_KeyPress);
            this.txtVlrDesconto.Leave += new System.EventHandler(this.txtVlrDesconto_Leave);
            // 
            // txtPercDesconto
            // 
            this.txtPercDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPercDesconto.Location = new System.Drawing.Point(128, 43);
            this.txtPercDesconto.MaxLength = 10;
            this.txtPercDesconto.Name = "txtPercDesconto";
            this.txtPercDesconto.Size = new System.Drawing.Size(89, 20);
            this.txtPercDesconto.TabIndex = 1;
            this.txtPercDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPercDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPercDesconto_KeyPress);
            this.txtPercDesconto.Leave += new System.EventHandler(this.txtPercDesconto_Leave);
            // 
            // txtNovoVlrReserva
            // 
            this.txtNovoVlrReserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNovoVlrReserva.Location = new System.Drawing.Point(128, 93);
            this.txtNovoVlrReserva.MaxLength = 10;
            this.txtNovoVlrReserva.Name = "txtNovoVlrReserva";
            this.txtNovoVlrReserva.Size = new System.Drawing.Size(89, 20);
            this.txtNovoVlrReserva.TabIndex = 3;
            this.txtNovoVlrReserva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNovoVlrReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNovoVlrReserva_KeyPress);
            this.txtNovoVlrReserva.Leave += new System.EventHandler(this.txtNovoVlrReserva_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 1084;
            this.label4.Text = "Novo valor da reserva";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPadraoConfirmar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 118);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(223, 27);
            this.toolStrip1.TabIndex = 1085;
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
            // frmDescontoReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 145);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtNovoVlrReserva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtVlrDesconto);
            this.Controls.Add(this.txtPercDesconto);
            this.Controls.Add(this.lblVlrAtualReserva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDescontoReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicar desconto na reserva";
            this.Load += new System.EventHandler(this.frmDescontoReserva_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDescontoReserva_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVlrAtualReserva;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVlrDesconto;
        private System.Windows.Forms.TextBox txtPercDesconto;
        private System.Windows.Forms.TextBox txtNovoVlrReserva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPadraoConfirmar;
    }
}