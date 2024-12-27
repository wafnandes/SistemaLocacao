namespace GirassoisLocacoes
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.espaçoáreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentoDePreçosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.parâmetrosDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizarReservaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueNaDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itensAlugadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoDeReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stsLabelNomeSistema = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsLabelData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripNomeBase = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovaReserva = new System.Windows.Forms.ToolStripButton();
            this.btnFinalizarReserva = new System.Windows.Forms.ToolStripButton();
            this.btnPadraoProximo = new System.Windows.Forms.ToolStripButton();
            this.btnPadraoVoltar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEstoqueNaData = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.movimentaçãoToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(865, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.espaçoáreaToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.parâmetrosDoSistemaToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // espaçoáreaToolStripMenuItem
            // 
            this.espaçoáreaToolStripMenuItem.Name = "espaçoáreaToolStripMenuItem";
            this.espaçoáreaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.espaçoáreaToolStripMenuItem.Text = "Espaço/área de eventos";
            this.espaçoáreaToolStripMenuItem.Click += new System.EventHandler(this.espaçoáreaToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeEstoqueToolStripMenuItem,
            this.agendamentoDePreçosToolStripMenuItem1});
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // cadastroDeEstoqueToolStripMenuItem
            // 
            this.cadastroDeEstoqueToolStripMenuItem.Name = "cadastroDeEstoqueToolStripMenuItem";
            this.cadastroDeEstoqueToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.cadastroDeEstoqueToolStripMenuItem.Text = "Cadastro de estoque";
            this.cadastroDeEstoqueToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeEstoqueToolStripMenuItem_Click);
            // 
            // agendamentoDePreçosToolStripMenuItem1
            // 
            this.agendamentoDePreçosToolStripMenuItem1.Name = "agendamentoDePreçosToolStripMenuItem1";
            this.agendamentoDePreçosToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.agendamentoDePreçosToolStripMenuItem1.Text = "Agendamento de preços";
            this.agendamentoDePreçosToolStripMenuItem1.Click += new System.EventHandler(this.agendamentoDePreçosToolStripMenuItem_Click);
            // 
            // parâmetrosDoSistemaToolStripMenuItem
            // 
            this.parâmetrosDoSistemaToolStripMenuItem.Name = "parâmetrosDoSistemaToolStripMenuItem";
            this.parâmetrosDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.parâmetrosDoSistemaToolStripMenuItem.Text = "Parâmetros do sistema";
            this.parâmetrosDoSistemaToolStripMenuItem.Click += new System.EventHandler(this.parâmetrosDoSistemaToolStripMenuItem_Click);
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservaToolStripMenuItem,
            this.finalizarReservaToolStripMenuItem1});
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.movimentaçãoToolStripMenuItem.Text = "Reserva";
            // 
            // reservaToolStripMenuItem
            // 
            this.reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            this.reservaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.reservaToolStripMenuItem.Text = "Nova Reserva";
            this.reservaToolStripMenuItem.Click += new System.EventHandler(this.reservaToolStripMenuItem_Click);
            // 
            // finalizarReservaToolStripMenuItem1
            // 
            this.finalizarReservaToolStripMenuItem1.Name = "finalizarReservaToolStripMenuItem1";
            this.finalizarReservaToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.finalizarReservaToolStripMenuItem1.Text = "Finalizar Reserva";
            this.finalizarReservaToolStripMenuItem1.Click += new System.EventHandler(this.finalizarReservaToolStripMenuItem1_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueNaDataToolStripMenuItem,
            this.itensAlugadosToolStripMenuItem,
            this.históricoDeReservasToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatóriosToolStripMenuItem.Text = "Consulta";
            // 
            // estoqueNaDataToolStripMenuItem
            // 
            this.estoqueNaDataToolStripMenuItem.Name = "estoqueNaDataToolStripMenuItem";
            this.estoqueNaDataToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.estoqueNaDataToolStripMenuItem.Text = "Estoque na data";
            // 
            // itensAlugadosToolStripMenuItem
            // 
            this.itensAlugadosToolStripMenuItem.Name = "itensAlugadosToolStripMenuItem";
            this.itensAlugadosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.itensAlugadosToolStripMenuItem.Text = "Itens Alugados";
            // 
            // históricoDeReservasToolStripMenuItem
            // 
            this.históricoDeReservasToolStripMenuItem.Name = "históricoDeReservasToolStripMenuItem";
            this.históricoDeReservasToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.históricoDeReservasToolStripMenuItem.Text = "Histórico de reservas";
            this.históricoDeReservasToolStripMenuItem.Click += new System.EventHandler(this.históricoDeReservasToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsLabelNomeSistema,
            this.stsLabelData,
            this.toolStripNomeBase});
            this.statusStrip1.Location = new System.Drawing.Point(0, 453);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(865, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stsLabelNomeSistema
            // 
            this.stsLabelNomeSistema.Name = "stsLabelNomeSistema";
            this.stsLabelNomeSistema.Size = new System.Drawing.Size(135, 17);
            this.stsLabelNomeSistema.Text = "Girassois Locações v. 1.0";
            // 
            // stsLabelData
            // 
            this.stsLabelData.Name = "stsLabelData";
            this.stsLabelData.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripNomeBase
            // 
            this.toolStripNomeBase.Name = "toolStripNomeBase";
            this.toolStripNomeBase.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovaReserva,
            this.btnFinalizarReserva,
            this.btnPadraoProximo,
            this.btnPadraoVoltar,
            this.toolStripSeparator1,
            this.btnEstoqueNaData,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(865, 27);
            this.toolStrip1.TabIndex = 1038;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNovaReserva
            // 
            this.btnNovaReserva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovaReserva.Image = global::GirassoisLocacoes.Properties.Resources.contrato__1_;
            this.btnNovaReserva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovaReserva.Name = "btnNovaReserva";
            this.btnNovaReserva.Size = new System.Drawing.Size(24, 24);
            this.btnNovaReserva.Text = "Nova Reserva";
            this.btnNovaReserva.Click += new System.EventHandler(this.btnNovaReserva_Click);
            // 
            // btnFinalizarReserva
            // 
            this.btnFinalizarReserva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFinalizarReserva.Image = global::GirassoisLocacoes.Properties.Resources.carimbo;
            this.btnFinalizarReserva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFinalizarReserva.Name = "btnFinalizarReserva";
            this.btnFinalizarReserva.Size = new System.Drawing.Size(24, 24);
            this.btnFinalizarReserva.Text = "Finalizar Reserva";
            this.btnFinalizarReserva.Click += new System.EventHandler(this.btnFinalizarReserva_Click);
            // 
            // btnPadraoProximo
            // 
            this.btnPadraoProximo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnPadraoProximo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPadraoProximo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPadraoProximo.Name = "btnPadraoProximo";
            this.btnPadraoProximo.Size = new System.Drawing.Size(23, 24);
            this.btnPadraoProximo.Text = "Avançar (F2)";
            // 
            // btnPadraoVoltar
            // 
            this.btnPadraoVoltar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnPadraoVoltar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPadraoVoltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPadraoVoltar.Name = "btnPadraoVoltar";
            this.btnPadraoVoltar.Size = new System.Drawing.Size(23, 24);
            this.btnPadraoVoltar.Text = "Retornar (F1)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnEstoqueNaData
            // 
            this.btnEstoqueNaData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEstoqueNaData.Image = global::GirassoisLocacoes.Properties.Resources.cronograma;
            this.btnEstoqueNaData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEstoqueNaData.Name = "btnEstoqueNaData";
            this.btnEstoqueNaData.Size = new System.Drawing.Size(24, 24);
            this.btnEstoqueNaData.Text = "Estoque na data";
            this.btnEstoqueNaData.Click += new System.EventHandler(this.btnEstoqueNaData_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::GirassoisLocacoes.Properties.Resources.data_analytics;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GirassoisLocacoes.Properties.Resources.Ativo_15;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(865, 475);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Girassois Locações";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stsLabelNomeSistema;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem espaçoáreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parâmetrosDoSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalizarReservaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel stsLabelData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripNomeBase;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentoDePreçosToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPadraoProximo;
        private System.Windows.Forms.ToolStripButton btnPadraoVoltar;
        private System.Windows.Forms.ToolStripButton btnNovaReserva;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnFinalizarReserva;
        private System.Windows.Forms.ToolStripButton btnEstoqueNaData;
        private System.Windows.Forms.ToolStripMenuItem estoqueNaDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itensAlugadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoDeReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}