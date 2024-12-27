namespace GirassoisLocacoes.Forms
{
    partial class frmPesquisaEspaco
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
            this.lvwInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.lvwInfo)).BeginInit();
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
            this.lvwInfo.Location = new System.Drawing.Point(2, 3);
            this.lvwInfo.MultiSelect = false;
            this.lvwInfo.Name = "lvwInfo";
            this.lvwInfo.ReadOnly = true;
            this.lvwInfo.RowHeadersVisible = false;
            this.lvwInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.lvwInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lvwInfo.Size = new System.Drawing.Size(550, 214);
            this.lvwInfo.TabIndex = 2;
            this.lvwInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lvwInfo_CellDoubleClick);
            this.lvwInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvwInfo_KeyDown);
            // 
            // frmPesquisaEspaco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 220);
            this.Controls.Add(this.lvwInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPesquisaEspaco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de espaços/áreas de eventos";
            this.Load += new System.EventHandler(this.frmPesquisaEspaco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lvwInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView lvwInfo;
    }
}