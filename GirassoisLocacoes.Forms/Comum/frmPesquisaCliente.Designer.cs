namespace GirassoisLocacoes.Forms
{
    partial class frmPesquisaCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisaCliente));
            this.lvwInfo = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblClienteOcorrencia = new System.Windows.Forms.ToolStripLabel();
            this.imgLegenda = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lvwInfo)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLegenda)).BeginInit();
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
            this.lvwInfo.Location = new System.Drawing.Point(2, 4);
            this.lvwInfo.MultiSelect = false;
            this.lvwInfo.Name = "lvwInfo";
            this.lvwInfo.ReadOnly = true;
            this.lvwInfo.RowHeadersVisible = false;
            this.lvwInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.lvwInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lvwInfo.Size = new System.Drawing.Size(550, 188);
            this.lvwInfo.TabIndex = 1;
            this.lvwInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lvwInfo_CellDoubleClick);
            this.lvwInfo.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.lvwInfo_DataBindingComplete);
            this.lvwInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvwInfo_KeyDown);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblClienteOcorrencia});
            this.toolStrip1.Location = new System.Drawing.Point(0, 195);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(554, 25);
            this.toolStrip1.TabIndex = 1002;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblClienteOcorrencia
            // 
            this.lblClienteOcorrencia.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblClienteOcorrencia.Enabled = false;
            this.lblClienteOcorrencia.Name = "lblClienteOcorrencia";
            this.lblClienteOcorrencia.Size = new System.Drawing.Size(130, 22);
            this.lblClienteOcorrencia.Text = "Cliente com ocorrência";
            // 
            // imgLegenda
            // 
            this.imgLegenda.Image = ((System.Drawing.Image)(resources.GetObject("imgLegenda.Image")));
            this.imgLegenda.Location = new System.Drawing.Point(402, 199);
            this.imgLegenda.Name = "imgLegenda";
            this.imgLegenda.Size = new System.Drawing.Size(18, 15);
            this.imgLegenda.TabIndex = 1029;
            this.imgLegenda.TabStop = false;
            // 
            // frmPesquisaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 220);
            this.Controls.Add(this.imgLegenda);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lvwInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPesquisaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de cliente";
            this.Load += new System.EventHandler(this.frmPesquisaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lvwInfo)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLegenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lvwInfo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblClienteOcorrencia;
        private System.Windows.Forms.PictureBox imgLegenda;
    }
}