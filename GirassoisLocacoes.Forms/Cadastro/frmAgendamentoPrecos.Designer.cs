namespace GirassoisLocacoes.Forms
{
    partial class frmAgendamentoPrecos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgendamentoPrecos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPadraoConfirmar = new System.Windows.Forms.ToolStripButton();
            this.btnPadraoExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnPadraoNovo = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvwInfo = new System.Windows.Forms.DataGridView();
            this.SSTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtVlrUnit = new System.Windows.Forms.Label();
            this.txtNovoVlrUnit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvwInfo)).BeginInit();
            this.SSTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPadraoConfirmar,
            this.btnPadraoExcluir,
            this.btnPadraoNovo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 155);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(520, 27);
            this.toolStrip1.TabIndex = 1036;
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
            this.btnPadraoExcluir.Click += new System.EventHandler(this.btnPadraoExcluir_Click);
            // 
            // btnPadraoNovo
            // 
            this.btnPadraoNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPadraoNovo.Image = global::GirassoisLocacoes.Forms.Properties.Resources.novo2;
            this.btnPadraoNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPadraoNovo.Name = "btnPadraoNovo";
            this.btnPadraoNovo.Size = new System.Drawing.Size(24, 24);
            this.btnPadraoNovo.Text = "Limpar";
            this.btnPadraoNovo.Click += new System.EventHandler(this.btnPadraoNovo_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.lvwInfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(505, 124);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registro";
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
            this.lvwInfo.Location = new System.Drawing.Point(6, 6);
            this.lvwInfo.MultiSelect = false;
            this.lvwInfo.Name = "lvwInfo";
            this.lvwInfo.ReadOnly = true;
            this.lvwInfo.RowHeadersVisible = false;
            this.lvwInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.lvwInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lvwInfo.Size = new System.Drawing.Size(494, 115);
            this.lvwInfo.TabIndex = 0;
            this.lvwInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lvwInfo_CellDoubleClick);
            this.lvwInfo.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.lvwInfo_DataBindingComplete);
            // 
            // SSTab
            // 
            this.SSTab.Controls.Add(this.tabPage1);
            this.SSTab.Controls.Add(this.tabPage2);
            this.SSTab.Location = new System.Drawing.Point(4, 4);
            this.SSTab.Name = "SSTab";
            this.SSTab.SelectedIndex = 0;
            this.SSTab.Size = new System.Drawing.Size(513, 150);
            this.SSTab.TabIndex = 1037;
            this.SSTab.SelectedIndexChanged += new System.EventHandler(this.SSTab_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.txtVlrUnit);
            this.tabPage1.Controls.Add(this.txtNovoVlrUnit);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dtpFim);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dtpInicio);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cboItem);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(505, 124);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            // 
            // txtVlrUnit
            // 
            this.txtVlrUnit.BackColor = System.Drawing.Color.White;
            this.txtVlrUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVlrUnit.Location = new System.Drawing.Point(404, 7);
            this.txtVlrUnit.Name = "txtVlrUnit";
            this.txtVlrUnit.Size = new System.Drawing.Size(95, 20);
            this.txtVlrUnit.TabIndex = 1049;
            this.txtVlrUnit.Text = "0,00";
            this.txtVlrUnit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNovoVlrUnit
            // 
            this.txtNovoVlrUnit.Location = new System.Drawing.Point(110, 46);
            this.txtNovoVlrUnit.MaxLength = 5;
            this.txtNovoVlrUnit.Name = "txtNovoVlrUnit";
            this.txtNovoVlrUnit.Size = new System.Drawing.Size(95, 20);
            this.txtNovoVlrUnit.TabIndex = 1;
            this.txtNovoVlrUnit.Text = "0,00";
            this.txtNovoVlrUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNovoVlrUnit.Enter += new System.EventHandler(this.txtNovoVlrUnit_Enter);
            this.txtNovoVlrUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNovoVlrUnit_KeyPress);
            this.txtNovoVlrUnit.Leave += new System.EventHandler(this.txtNovoVlrUnit_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 1045;
            this.label6.Text = "Novo valor unitário";
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(110, 98);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(95, 20);
            this.dtpFim.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 1043;
            this.label5.Text = "Data de fim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1041;
            this.label3.Text = "Valor unitário";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(110, 72);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(95, 20);
            this.dtpInicio.TabIndex = 2;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1040;
            this.label2.Text = "Data de início";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1039;
            this.label1.Text = "Selecione o item";
            // 
            // cboItem
            // 
            this.cboItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Location = new System.Drawing.Point(110, 7);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(198, 21);
            this.cboItem.TabIndex = 1035;
            this.cboItem.SelectedValueChanged += new System.EventHandler(this.cboItem_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(499, 13);
            this.label4.TabIndex = 1042;
            this.label4.Text = "_________________________________________________________________________________" +
    "_";
            // 
            // frmAgendamentoPrecos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 182);
            this.Controls.Add(this.SSTab);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmAgendamentoPrecos";
            this.Text = "Agendamento de preços";
            this.Load += new System.EventHandler(this.frmAgendamentoPrecos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAgendamentoPrecos_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lvwInfo)).EndInit();
            this.SSTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPadraoConfirmar;
        private System.Windows.Forms.ToolStripButton btnPadraoExcluir;
        private System.Windows.Forms.ToolStripButton btnPadraoNovo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView lvwInfo;
        private System.Windows.Forms.TabControl SSTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNovoVlrUnit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtVlrUnit;
    }
}