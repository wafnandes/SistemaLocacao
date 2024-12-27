namespace GirassoisLocacoes.Forms
{
    partial class frmReservaItens
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservaItens));
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvwInfo2 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPadraoConfirmar = new System.Windows.Forms.ToolStripButton();
            this.btnPadraoExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnPadraoNovo = new System.Windows.Forms.ToolStripButton();
            this.txtNomeItem = new System.Windows.Forms.TextBox();
            this.lvwInfo = new System.Windows.Forms.DataGridView();
            this.cdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorReposicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlrDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdeSolicitada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorBruto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lvwInfo2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvwInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQtde
            // 
            this.txtQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtde.Location = new System.Drawing.Point(503, 4);
            this.txtQtde.MaxLength = 4;
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(42, 20);
            this.txtQtde.TabIndex = 4;
            this.txtQtde.Text = "1";
            this.txtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQtde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQtde_KeyDown);
            this.txtQtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtde_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1000;
            this.label2.Text = "Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1001;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvwInfo2
            // 
            this.lvwInfo2.AllowUserToAddRows = false;
            this.lvwInfo2.AllowUserToDeleteRows = false;
            this.lvwInfo2.AllowUserToResizeColumns = false;
            this.lvwInfo2.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lvwInfo2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.lvwInfo2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwInfo2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.lvwInfo2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwInfo2.ColumnHeadersHeight = 29;
            this.lvwInfo2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.lvwInfo2.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lvwInfo2.DefaultCellStyle = dataGridViewCellStyle2;
            this.lvwInfo2.EnableHeadersVisualStyles = false;
            this.lvwInfo2.Location = new System.Drawing.Point(39, 24);
            this.lvwInfo2.MultiSelect = false;
            this.lvwInfo2.Name = "lvwInfo2";
            this.lvwInfo2.ReadOnly = true;
            this.lvwInfo2.RowHeadersVisible = false;
            this.lvwInfo2.RowHeadersWidth = 51;
            this.lvwInfo2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.lvwInfo2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lvwInfo2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lvwInfo2.Size = new System.Drawing.Size(442, 68);
            this.lvwInfo2.TabIndex = 1003;
            this.lvwInfo2.Visible = false;
            this.lvwInfo2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lvwInfo2_CellDoubleClick);
            this.lvwInfo2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvwInfo2_KeyDown);
            this.lvwInfo2.Leave += new System.EventHandler(this.lvwInfo2_Leave);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPadraoConfirmar,
            this.btnPadraoExcluir,
            this.btnPadraoNovo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 204);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(550, 27);
            this.toolStrip1.TabIndex = 1004;
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
            // txtNomeItem
            // 
            this.txtNomeItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeItem.Location = new System.Drawing.Point(39, 4);
            this.txtNomeItem.MaxLength = 40;
            this.txtNomeItem.Name = "txtNomeItem";
            this.txtNomeItem.Size = new System.Drawing.Size(441, 20);
            this.txtNomeItem.TabIndex = 3;
            this.txtNomeItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeItem_KeyDown);
            this.txtNomeItem.Leave += new System.EventHandler(this.txtNomeItem_Leave);
            // 
            // lvwInfo
            // 
            this.lvwInfo.AllowUserToAddRows = false;
            this.lvwInfo.AllowUserToDeleteRows = false;
            this.lvwInfo.AllowUserToResizeColumns = false;
            this.lvwInfo.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lvwInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.lvwInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lvwInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.lvwInfo.ColumnHeadersHeight = 20;
            this.lvwInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.lvwInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdItem,
            this.nmItem,
            this.qtdEstoque,
            this.valorReposicao,
            this.valorUnit,
            this.vlrDesconto,
            this.qtdeSolicitada,
            this.descItem,
            this.cSit,
            this.total,
            this.totalBruto});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lvwInfo.DefaultCellStyle = dataGridViewCellStyle5;
            this.lvwInfo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.lvwInfo.Location = new System.Drawing.Point(5, 28);
            this.lvwInfo.MultiSelect = false;
            this.lvwInfo.Name = "lvwInfo";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lvwInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.lvwInfo.RowHeadersVisible = false;
            this.lvwInfo.RowHeadersWidth = 51;
            this.lvwInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.lvwInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lvwInfo.Size = new System.Drawing.Size(540, 143);
            this.lvwInfo.TabIndex = 1014;
            // 
            // cdItem
            // 
            this.cdItem.HeaderText = "codigo";
            this.cdItem.MinimumWidth = 6;
            this.cdItem.Name = "cdItem";
            this.cdItem.ReadOnly = true;
            this.cdItem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cdItem.Visible = false;
            this.cdItem.Width = 125;
            // 
            // nmItem
            // 
            this.nmItem.HeaderText = "Nome";
            this.nmItem.MinimumWidth = 6;
            this.nmItem.Name = "nmItem";
            this.nmItem.ReadOnly = true;
            this.nmItem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nmItem.Width = 186;
            // 
            // qtdEstoque
            // 
            this.qtdEstoque.HeaderText = "Qtde. Estoque";
            this.qtdEstoque.MinimumWidth = 6;
            this.qtdEstoque.Name = "qtdEstoque";
            this.qtdEstoque.ReadOnly = true;
            this.qtdEstoque.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.qtdEstoque.Visible = false;
            this.qtdEstoque.Width = 70;
            // 
            // valorReposicao
            // 
            this.valorReposicao.HeaderText = "Vlr. Repo";
            this.valorReposicao.MinimumWidth = 6;
            this.valorReposicao.Name = "valorReposicao";
            this.valorReposicao.ReadOnly = true;
            this.valorReposicao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.valorReposicao.Width = 70;
            // 
            // valorUnit
            // 
            this.valorUnit.HeaderText = "Valor Unit.";
            this.valorUnit.MaxInputLength = 5;
            this.valorUnit.MinimumWidth = 6;
            this.valorUnit.Name = "valorUnit";
            this.valorUnit.ReadOnly = true;
            this.valorUnit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.valorUnit.Width = 70;
            // 
            // vlrDesconto
            // 
            this.vlrDesconto.HeaderText = "Desc. Unit.";
            this.vlrDesconto.Name = "vlrDesconto";
            this.vlrDesconto.ReadOnly = true;
            this.vlrDesconto.Width = 70;
            // 
            // qtdeSolicitada
            // 
            this.qtdeSolicitada.HeaderText = "Qtde.";
            this.qtdeSolicitada.MinimumWidth = 6;
            this.qtdeSolicitada.Name = "qtdeSolicitada";
            this.qtdeSolicitada.ReadOnly = true;
            this.qtdeSolicitada.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.qtdeSolicitada.Width = 70;
            // 
            // descItem
            // 
            this.descItem.HeaderText = "descricao";
            this.descItem.MinimumWidth = 6;
            this.descItem.Name = "descItem";
            this.descItem.ReadOnly = true;
            this.descItem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.descItem.Visible = false;
            this.descItem.Width = 125;
            // 
            // cSit
            // 
            this.cSit.HeaderText = "cSit";
            this.cSit.MinimumWidth = 6;
            this.cSit.Name = "cSit";
            this.cSit.Visible = false;
            this.cSit.Width = 125;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.total.Width = 70;
            // 
            // totalBruto
            // 
            this.totalBruto.HeaderText = "TotalBruto";
            this.totalBruto.Name = "totalBruto";
            this.totalBruto.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(392, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 1018;
            this.label5.Text = "Valor Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 13);
            this.label6.TabIndex = 1019;
            this.label6.Text = "Clique duas vezes na coluna para alterar o valor.";
            // 
            // txtValorBruto
            // 
            this.txtValorBruto.BackColor = System.Drawing.Color.White;
            this.txtValorBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorBruto.Location = new System.Drawing.Point(456, 176);
            this.txtValorBruto.Name = "txtValorBruto";
            this.txtValorBruto.Size = new System.Drawing.Size(89, 20);
            this.txtValorBruto.TabIndex = 1056;
            this.txtValorBruto.Text = "R$ 0,00";
            this.txtValorBruto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmReservaItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 231);
            this.Controls.Add(this.lvwInfo2);
            this.Controls.Add(this.lvwInfo);
            this.Controls.Add(this.txtValorBruto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.txtNomeItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmReservaItens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Montar Pedido";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmReservaItens_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.lvwInfo2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvwInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView lvwInfo2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPadraoConfirmar;
        private System.Windows.Forms.ToolStripButton btnPadraoExcluir;
        private System.Windows.Forms.ToolStripButton btnPadraoNovo;
        private System.Windows.Forms.TextBox txtNomeItem;
        private System.Windows.Forms.DataGridView lvwInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtValorBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorReposicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlrDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdeSolicitada;
        private System.Windows.Forms.DataGridViewTextBoxColumn descItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSit;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBruto;
    }
}