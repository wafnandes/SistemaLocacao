namespace GirassoisLocacoes.Forms
{
    partial class frmFinalizarReserva
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinalizarReserva));
            this.lvwInfo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPadraoConfirmar = new System.Windows.Forms.ToolStripButton();
            this.btnPadraoExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnPadraoNovo = new System.Windows.Forms.ToolStripButton();
            this.btnPadraoRefresh = new System.Windows.Forms.ToolStripButton();
            this.mnuContexto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuEditarReserva = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.lvwInfo)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.mnuContexto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwInfo
            // 
            this.lvwInfo.AllowUserToAddRows = false;
            this.lvwInfo.AllowUserToDeleteRows = false;
            this.lvwInfo.AllowUserToResizeColumns = false;
            this.lvwInfo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lvwInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.lvwInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.lvwInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.lvwInfo.Location = new System.Drawing.Point(7, 20);
            this.lvwInfo.MultiSelect = false;
            this.lvwInfo.Name = "lvwInfo";
            this.lvwInfo.RowHeadersVisible = false;
            this.lvwInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.lvwInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lvwInfo.Size = new System.Drawing.Size(799, 176);
            this.lvwInfo.TabIndex = 1;
            this.lvwInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lvwInfo_CellClick);
            this.lvwInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvwInfo_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione as reservas que deseja finalizar";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPadraoConfirmar,
            this.btnPadraoExcluir,
            this.btnPadraoNovo,
            this.btnPadraoRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 203);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(814, 27);
            this.toolStrip1.TabIndex = 1006;
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
            // btnPadraoExcluir
            // 
            this.btnPadraoExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPadraoExcluir.Image = global::GirassoisLocacoes.Forms.Properties.Resources.cancela;
            this.btnPadraoExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPadraoExcluir.Name = "btnPadraoExcluir";
            this.btnPadraoExcluir.Size = new System.Drawing.Size(24, 24);
            this.btnPadraoExcluir.Text = "Excluir";
            // 
            // btnPadraoNovo
            // 
            this.btnPadraoNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPadraoNovo.Image = global::GirassoisLocacoes.Forms.Properties.Resources.novo2;
            this.btnPadraoNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPadraoNovo.Name = "btnPadraoNovo";
            this.btnPadraoNovo.Size = new System.Drawing.Size(24, 24);
            this.btnPadraoNovo.Text = "Limpar";
            // 
            // btnPadraoRefresh
            // 
            this.btnPadraoRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPadraoRefresh.Image = global::GirassoisLocacoes.Forms.Properties.Resources.atualizar;
            this.btnPadraoRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPadraoRefresh.Name = "btnPadraoRefresh";
            this.btnPadraoRefresh.Size = new System.Drawing.Size(24, 24);
            this.btnPadraoRefresh.Text = "toolStripButton1";
            this.btnPadraoRefresh.Click += new System.EventHandler(this.btnPadraoRefresh_Click);
            // 
            // mnuContexto
            // 
            this.mnuContexto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditarReserva});
            this.mnuContexto.Name = "mnuContexto";
            this.mnuContexto.Size = new System.Drawing.Size(167, 26);
            // 
            // mnuEditarReserva
            // 
            this.mnuEditarReserva.Name = "mnuEditarReserva";
            this.mnuEditarReserva.Size = new System.Drawing.Size(166, 22);
            this.mnuEditarReserva.Text = "Visualizar Reserva";
            this.mnuEditarReserva.Click += new System.EventHandler(this.mnuEditarReserva_Click);
            // 
            // frmFinalizarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 230);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmFinalizarReserva";
            this.Text = "Finalizar Reserva";
            this.Load += new System.EventHandler(this.frmFinalizarReserva_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFinalizarReserva_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.lvwInfo)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.mnuContexto.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPadraoConfirmar;
        private System.Windows.Forms.ToolStripButton btnPadraoExcluir;
        private System.Windows.Forms.ToolStripButton btnPadraoNovo;
        private System.Windows.Forms.DataGridView lvwInfo;
        private System.Windows.Forms.ToolStripButton btnPadraoRefresh;
        private System.Windows.Forms.ContextMenuStrip mnuContexto;
        private System.Windows.Forms.ToolStripMenuItem mnuEditarReserva;
    }
}