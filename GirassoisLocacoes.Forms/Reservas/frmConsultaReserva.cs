using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GirassoisLocacoes.Commons;
using GirassoisLocacoes.Entidades;
using GirassoisLocacoes.Negocio;

namespace GirassoisLocacoes.Forms
{
    public partial class frmConsultaReserva : Form
    {
        #region "Variáveis"
        ENReserva entidadeReserva = new ENReserva();
        List<ENReservaItens> entidadeItensReserva = new List<ENReservaItens>();
        #endregion

        #region "Construtor"
        public frmConsultaReserva(ENReserva reserva, List<ENReservaItens> itensReserva)
        {
            entidadeReserva = reserva;
            entidadeItensReserva = itensReserva;
            InitializeComponent();
        }

        private void frmConsultaReserva_Load(object sender, EventArgs e)
        {
            CarregaDados();

            btnPadraoConfirmar.Visible = false;
            btnPadraoExcluir.Visible = false;
            btnPadraoNovo.Visible = false;
        }
        #endregion

        #region "Métodos"

        #region "CarregarDados"
        private void CarregaDados()
        {
            try
            {
                this.Text += " - Nº: " + Funcoes.Formatar(Convert.ToDouble(entidadeReserva.cdReserva),"000000");

                txtNome.Text = entidadeReserva.nmCliente;
                txtCPF.Text = FormHelper.Instance.MascaraCPFCNPJ(entidadeReserva.cpfcnpj);
                txtDtNasc.Text = entidadeReserva.dtNasc;
                txtTelefone.Text = FormHelper.Instance.MascaraTelefone(entidadeReserva.telCliente);
                txtEntregarEm.Text = entidadeReserva.nmLocalEntrega;
                txtCEP.Text = FormHelper.Instance.MascaraCEP(Convert.ToString(entidadeReserva.cep));
                txtEndereco.Text = entidadeReserva.endereco;
                txtComplemento.Text = entidadeReserva.compl;
                txtBairro.Text = entidadeReserva.bairro;
                txtCidade.Text = entidadeReserva.cidade;
                txtDtEntrega.Text = entidadeReserva.strDtHrEntrega;
                txtDtDevolucao.Text = entidadeReserva.strDtHrDevolucao;
                txtVlrBruto.Text = "R$ " + Funcoes.Formatar(Convert.ToDouble(entidadeReserva.vlrReserva),"N2");
                txtVlrDesconto.Text = "R$ " + Funcoes.Formatar(Convert.ToDouble(entidadeReserva.vlrDesconto),"N2");
                txtVlrTotal.Text = "R$ " + Funcoes.Formatar(Convert.ToDouble(entidadeReserva.vlrTotal),"N2");
                txtObservacoes.Text = entidadeReserva.observacao;

                if (entidadeReserva.ocorrencia)
                {
                    pnlOcorrencia.Visible = true;
                }
                else
                {
                    pnlReservaConcluida.Visible = true;
                }

                int i = 0;
                foreach (ENReservaItens Item in entidadeItensReserva)
                {
                    i = lvwInfo.Rows.Count;

                    lvwInfo.Rows.Add();
                    if (Item.nmItem.Contains("Reposição"))
                    {
                        lvwInfo["cdItem", i].Value = "";
                        lvwInfo["valorReposicao", i].Value = "";
                        lvwInfo["vlrDesconto", i].Value = "";
                    }
                    else
                    {
                        lvwInfo["cdItem", i].Value = Funcoes.Formatar(Convert.ToDouble(Item.cdItem), "000");
                        lvwInfo["valorReposicao", i].Value = "R$ " + Funcoes.Formatar(Convert.ToDouble(Item.vlrReposicao), "N2");
                        lvwInfo["vlrDesconto", i].Value = "R$ " + Funcoes.Formatar(Convert.ToDouble(Item.vlrDesconto), "N2");
                    }

                    lvwInfo["nmItem", i].Value = Item.nmItem;

                    lvwInfo["valorUnit", i].Value = "R$ " + Funcoes.Formatar(Convert.ToDouble(Item.vlrUnit), "N2");
                    lvwInfo["qtdeSolicitada", i].Value = Convert.ToString(Item.qtdeItem);
                    lvwInfo["total", i].Value = "R$ " + Funcoes.Formatar(Convert.ToDouble(Item.total), "N2");
                }

                ConfiguraGrid();

                lvwInfo.Rows[0].Selected = false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "ConfiguraGrid"
        private void ConfiguraGrid()
        {
            try
            {
                lvwInfo.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                lvwInfo.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                lvwInfo.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                lvwInfo.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                lvwInfo.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

                if (lvwInfo.Rows.Count > 4)
                    lvwInfo.Columns["nmItem"].Width = 160;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "Limpar"
        private void Limpar()
        {
            try
            {
                pnlOcorrencia.Visible = false;
                pnlReservaConcluida.Visible = false;
                lvwInfo.Rows.Clear();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #endregion

        #region "Eventos"

        #region "btnPadraoImprimir_Click"
        private void btnPadraoImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = entidadeReserva.nmCliente.ToString();
                string[] palavras = nome.Split(' ');

                GeraPDF.Instance.GeraPDFReservaA4(entidadeReserva, entidadeItensReserva, "Reserva_" + Convert.ToDouble(entidadeReserva.cdReserva).Formatar("00000") + "_" + $"{palavras[0]}");
            }
            catch(Exception ex)
            {
                throw ex;
            } 
        }
        #endregion

        #region "btnPadraoOcorrencia_Click"
        private void btnPadraoOcorrencia_Click(object sender, EventArgs e)
        {
            try
            {
                frmInserirOcorrencia frmOcorrencia = new frmInserirOcorrencia(entidadeReserva);
                this.Enabled = false;
                frmOcorrencia.ShowDialog();
                frmOcorrencia.BringToFront();
                this.Enabled = true;

                NEReserva.Instance.AtualizarValoresReserva(entidadeReserva);
                entidadeReserva = NEReserva.Instance.ObterDetalhesReserva(entidadeReserva);
                entidadeItensReserva = NEReserva.Instance.ObterItensReserva(entidadeReserva);

                Limpar();

                CarregaDados();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "frmConsultaReserva_KeyDown"
        private void frmConsultaReserva_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            else
            {
                if (e.KeyCode == Keys.P)
                {
                    if (e.Control)
                    {
                        btnPadraoImprimir.PerformClick();
                    }
                }
                if (e.KeyCode == Keys.I)
                {
                    if (e.Control)
                    {
                        btnPadraoOcorrencia.PerformClick();
                    }
                }
            }
        }
        #endregion

        #endregion

    }
}
