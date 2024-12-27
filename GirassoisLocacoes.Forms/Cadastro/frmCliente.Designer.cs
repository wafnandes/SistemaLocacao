namespace GirassoisLocacoes.Forms
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.cboCidade = new System.Windows.Forms.ComboBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SSTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtDtNasc = new System.Windows.Forms.MaskedTextBox();
            this.chkCPFVerificado = new System.Windows.Forms.CheckBox();
            this.gpoObservacoes = new System.Windows.Forms.GroupBox();
            this.chkObservacoes = new System.Windows.Forms.CheckBox();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkCarregarInativos = new System.Windows.Forms.CheckBox();
            this.lvwInfo = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPadraoConfirmar = new System.Windows.Forms.ToolStripButton();
            this.btnPadraoExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnPadraoNovo = new System.Windows.Forms.ToolStripButton();
            this.lblClienteOcorrencia = new System.Windows.Forms.ToolStripLabel();
            this.imgLegenda = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.SSTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gpoObservacoes.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvwInfo)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLegenda)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(72, 33);
            this.txtNome.MaxLength = 40;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(480, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 999;
            this.label1.Text = "Nome";
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(72, 8);
            this.txtCPF.MaxLength = 14;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(133, 20);
            this.txtCPF.TabIndex = 1;
            this.txtCPF.Enter += new System.EventHandler(this.txtCPF_Enter);
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_KeyPress);
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 999;
            this.label2.Text = "CPF/CNPJ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 999;
            this.label3.Text = "Data de nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 999;
            this.label4.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(172, 22);
            this.txtEndereco.MaxLength = 40;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(370, 20);
            this.txtEndereco.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(292, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 999;
            this.label6.Text = "Cidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(210, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 999;
            this.label7.Text = "Telefone";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtCEP);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtComplemento);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.cboCidade);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 103);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço (Opcional)";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(39, 22);
            this.txtCEP.Mask = "00,000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(60, 20);
            this.txtCEP.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 999;
            this.label11.Text = "Bairro/Setor";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(84, 47);
            this.txtComplemento.MaxLength = 50;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(458, 20);
            this.txtComplemento.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 999;
            this.label10.Text = "CEP";
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(518, 72);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(22, 20);
            this.txtEstado.TabIndex = 21;
            this.txtEstado.Text = "GO";
            // 
            // cboCidade
            // 
            this.cboCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.Location = new System.Drawing.Point(334, 72);
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(170, 21);
            this.cboCidade.TabIndex = 10;
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(84, 72);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(202, 20);
            this.txtBairro.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 999;
            this.label5.Text = "Complemento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(506, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 999;
            this.label8.Text = "-";
            // 
            // SSTab
            // 
            this.SSTab.Controls.Add(this.tabPage1);
            this.SSTab.Controls.Add(this.tabPage2);
            this.SSTab.Location = new System.Drawing.Point(2, 3);
            this.SSTab.Name = "SSTab";
            this.SSTab.SelectedIndex = 0;
            this.SSTab.Size = new System.Drawing.Size(572, 344);
            this.SSTab.TabIndex = 21;
            this.SSTab.SelectedIndexChanged += new System.EventHandler(this.SSTab_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.txtTelefone);
            this.tabPage1.Controls.Add(this.txtDtNasc);
            this.tabPage1.Controls.Add(this.chkCPFVerificado);
            this.tabPage1.Controls.Add(this.gpoObservacoes);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtCPF);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(564, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(265, 58);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(94, 20);
            this.txtTelefone.TabIndex = 4;
            // 
            // txtDtNasc
            // 
            this.txtDtNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtNasc.Location = new System.Drawing.Point(115, 58);
            this.txtDtNasc.Mask = "00/00/0000";
            this.txtDtNasc.Name = "txtDtNasc";
            this.txtDtNasc.Size = new System.Drawing.Size(68, 20);
            this.txtDtNasc.TabIndex = 3;
            this.txtDtNasc.ValidatingType = typeof(System.DateTime);
            // 
            // chkCPFVerificado
            // 
            this.chkCPFVerificado.AutoSize = true;
            this.chkCPFVerificado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCPFVerificado.Location = new System.Drawing.Point(465, 10);
            this.chkCPFVerificado.Name = "chkCPFVerificado";
            this.chkCPFVerificado.Size = new System.Drawing.Size(96, 17);
            this.chkCPFVerificado.TabIndex = 5;
            this.chkCPFVerificado.Text = "CPF Verificado";
            this.chkCPFVerificado.UseVisualStyleBackColor = true;
            // 
            // gpoObservacoes
            // 
            this.gpoObservacoes.Controls.Add(this.chkObservacoes);
            this.gpoObservacoes.Controls.Add(this.txtObservacoes);
            this.gpoObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoObservacoes.Location = new System.Drawing.Point(11, 198);
            this.gpoObservacoes.Name = "gpoObservacoes";
            this.gpoObservacoes.Size = new System.Drawing.Size(545, 118);
            this.gpoObservacoes.TabIndex = 23;
            this.gpoObservacoes.TabStop = false;
            this.gpoObservacoes.Text = "Observações";
            // 
            // chkObservacoes
            // 
            this.chkObservacoes.AutoSize = true;
            this.chkObservacoes.Location = new System.Drawing.Point(8, 0);
            this.chkObservacoes.Name = "chkObservacoes";
            this.chkObservacoes.Size = new System.Drawing.Size(121, 17);
            this.chkObservacoes.TabIndex = 11;
            this.chkObservacoes.Text = "Possui observações";
            this.chkObservacoes.UseVisualStyleBackColor = true;
            this.chkObservacoes.CheckedChanged += new System.EventHandler(this.chkObservacoes_CheckedChanged);
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoes.Location = new System.Drawing.Point(8, 22);
            this.txtObservacoes.MaxLength = 200;
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(531, 89);
            this.txtObservacoes.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.chkCarregarInativos);
            this.tabPage2.Controls.Add(this.lvwInfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(564, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registro";
            // 
            // chkCarregarInativos
            // 
            this.chkCarregarInativos.AutoSize = true;
            this.chkCarregarInativos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCarregarInativos.Location = new System.Drawing.Point(465, 6);
            this.chkCarregarInativos.Name = "chkCarregarInativos";
            this.chkCarregarInativos.Size = new System.Drawing.Size(91, 17);
            this.chkCarregarInativos.TabIndex = 27;
            this.chkCarregarInativos.Text = "Exibir Inativos";
            this.chkCarregarInativos.UseVisualStyleBackColor = true;
            this.chkCarregarInativos.CheckedChanged += new System.EventHandler(this.chkCarregarInativos_CheckedChanged);
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
            this.lvwInfo.Location = new System.Drawing.Point(6, 29);
            this.lvwInfo.MultiSelect = false;
            this.lvwInfo.Name = "lvwInfo";
            this.lvwInfo.ReadOnly = true;
            this.lvwInfo.RowHeadersVisible = false;
            this.lvwInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.lvwInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lvwInfo.Size = new System.Drawing.Size(550, 283);
            this.lvwInfo.TabIndex = 0;
            this.lvwInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lvwInfo_CellDoubleClick);
            this.lvwInfo.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.lvwInfo_DataBindingComplete);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPadraoConfirmar,
            this.btnPadraoExcluir,
            this.btnPadraoNovo,
            this.lblClienteOcorrencia});
            this.toolStrip1.Location = new System.Drawing.Point(0, 345);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(574, 27);
            this.toolStrip1.TabIndex = 1001;
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
            // lblClienteOcorrencia
            // 
            this.lblClienteOcorrencia.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblClienteOcorrencia.Enabled = false;
            this.lblClienteOcorrencia.Name = "lblClienteOcorrencia";
            this.lblClienteOcorrencia.Size = new System.Drawing.Size(130, 24);
            this.lblClienteOcorrencia.Text = "Cliente com ocorrência";
            // 
            // imgLegenda
            // 
            this.imgLegenda.Image = ((System.Drawing.Image)(resources.GetObject("imgLegenda.Image")));
            this.imgLegenda.Location = new System.Drawing.Point(422, 350);
            this.imgLegenda.Name = "imgLegenda";
            this.imgLegenda.Size = new System.Drawing.Size(18, 15);
            this.imgLegenda.TabIndex = 1028;
            this.imgLegenda.TabStop = false;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(574, 372);
            this.Controls.Add(this.imgLegenda);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.SSTab);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCliente_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SSTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gpoObservacoes.ResumeLayout(false);
            this.gpoObservacoes.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvwInfo)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLegenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboCidade;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl SSTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gpoObservacoes;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.CheckBox chkObservacoes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.CheckBox chkCPFVerificado;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.DataGridView lvwInfo;
        private System.Windows.Forms.CheckBox chkCarregarInativos;
        private System.Windows.Forms.MaskedTextBox txtDtNasc;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPadraoConfirmar;
        private System.Windows.Forms.ToolStripButton btnPadraoExcluir;
        private System.Windows.Forms.ToolStripButton btnPadraoNovo;
        private System.Windows.Forms.ToolStripLabel lblClienteOcorrencia;
        private System.Windows.Forms.PictureBox imgLegenda;
    }
}