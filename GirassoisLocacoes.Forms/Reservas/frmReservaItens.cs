using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using GirassoisLocacoes.Commons;
using GirassoisLocacoes.Entidades;
using GirassoisLocacoes.Negocio;

namespace GirassoisLocacoes.Forms
{
    public partial class frmReservaItens : Form
    {
        #region "Variáveis"
        private int qtdeDisponivelSelecionado = 0;
        private int cdItemSelecionado = 0;
        private ENEstoque entidade = new ENEstoque();
        private ENReserva dados = new ENReserva();
        private List<ENReservaItens> entidadeItens = new List<ENReservaItens>();
        #endregion

        #region "Construtor"
        public frmReservaItens(ENReserva entidade)
        {
            dados = entidade;
            InitializeComponent();
        }
        #endregion

        #region "Métodos"

        #region "PesquisaProd"
        private void PesquisaProd()
        {
            try
            {
                ENReserva entidadeItens = new ENReserva();

                entidadeItens.dtEntrega = dados.dtEntrega;
                entidadeItens.dtDevolucao = dados.dtDevolucao;
                entidadeItens.nmItem = txtNomeItem.Text;

                lvwInfo2.DataSource = NEReserva.Instance.ObterEstoqueDisponivel(entidadeItens).Tables[0];

                if (lvwInfo2.Rows.Count > 0)
                {
                    lvwInfo2.Columns["cdItem"].Visible = false;
                    lvwInfo2.Columns["qtdDisponivel"].Visible = true;
                    lvwInfo2.Columns["vlrUnit"].Visible = false;
                    lvwInfo2.Columns["vlrReposicao"].Visible = false;
                    lvwInfo2.Columns["nmItem"].Width = 400;
                    lvwInfo2.Columns["qtdDisponivel"].Width = 42;

                    txtNomeItem.ReadOnly = true;

                    lvwInfo2.Visible = true;
                    lvwInfo2.Focus();
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "CarregaProduto"
        private void CarregaProduto()
        {
            qtdeDisponivelSelecionado = Convert.ToInt32(lvwInfo2.CurrentRow.Cells["qtdDisponivel"].Value);
            cdItemSelecionado = Convert.ToInt32(lvwInfo2.CurrentRow.Cells["cdItem"].Value);
            entidade.nomeItem = Convert.ToString(lvwInfo2.CurrentRow.Cells["nmItem"].Value);
            entidade.cdItem = Convert.ToInt32(lvwInfo2.CurrentRow.Cells["cdItem"].Value);
            entidade.valorUnit = Convert.ToDecimal(lvwInfo2.CurrentRow.Cells["vlrUnit"].Value);
            entidade.valorReposicao = Convert.ToDecimal(lvwInfo2.CurrentRow.Cells["vlrReposicao"].Value);
            entidade.qtdeEstoque = qtdeDisponivelSelecionado;
            txtNomeItem.Text = Convert.ToString(lvwInfo2.CurrentRow.Cells["nmItem"].Value);
            lvwInfo2.Visible = false;
           
            txtQtde.Focus();
        }
        #endregion

        #region "CarregaDetalhes"
        private void CarregaDetalhes()
        {
            DataSet ds = new DataSet();
            double total = 0;
            int i = lvwInfo.Rows.Count;

            entidade.qtdeSolicitada = Convert.ToInt32(txtQtde.Text.Trim());

            ds = NEEstoque.Instance.ObterItem(entidade);

            foreach(DataGridViewRow row in lvwInfo.Rows)
            {
                if (Convert.ToInt32(row.Cells["cdItem"].Value) == Convert.ToInt32(ds.Tables[0].Rows[0]["cdItem"]))
                {
                    FormHelper.Instance.Advertencia("O item " + Convert.ToString(ds.Tables[0].Rows[0]["nmItem"]) + " já está na lista!\n" +
                        "Exclua o item da lista e insira novamente!");
                    return;
                }  
            }

            lvwInfo.Rows.Add();
            lvwInfo["cdItem", i].Value = entidade.cdItem;
            lvwInfo["nmItem", i].Value = entidade.nomeItem;
            lvwInfo["qtdEstoque", i].Value = entidade.qtdeEstoque;
            lvwInfo["valorUnit", i].Value = Convert.ToDouble(entidade.valorUnit).Formatar("N2");
            lvwInfo["vlrDesconto", i].Value = "0,00";
            lvwInfo["valorReposicao", i].Value = Convert.ToDouble(entidade.valorReposicao).Formatar("N2");
            lvwInfo["cSit", i].Value = 1;
            lvwInfo["qtdeSolicitada", i].Value = entidade.qtdeSolicitada;

            total = Convert.ToDouble(entidade.valorUnit) * Convert.ToDouble(ds.Tables[0].Rows[0]["qtdeSolicitada"]);

            lvwInfo["total",i].Value = Convert.ToString(Funcoes.Formatar(total, "N2"));
            lvwInfo["totalBruto", i].Value = Convert.ToString(Funcoes.Formatar(total, "N2"));

            if (i > 4)
                lvwInfo.Columns["nmItem"].Width = 155;

            CalculaTotal();

            lvwInfo.Rows[i].Selected = true;

            qtdeDisponivelSelecionado = 0;
            cdItemSelecionado = 0;
        }
        #endregion

        #region "CalculaTotal"
        private void CalculaTotal()
        {
            try
            {
                double total = 0;
                double bruto = 0;

                foreach (DataGridViewRow row in lvwInfo.Rows)
                {
                    total += Convert.ToDouble(row.Cells["total"].Value);
                    bruto += Convert.ToDouble(row.Cells["valorUnit"].Value) * Convert.ToDouble(row.Cells["qtdeSolicitada"].Value);
                }

                txtValorBruto.Text = "R$ " + Funcoes.Formatar(total, "N2");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "Confirmar"
        private void Confirmar()
        {
            try
            {
                decimal vlrDesconto = 0;
                decimal vlrTotal = 0;
                decimal vlrBruto = 0;

                if(lvwInfo.Rows.Count == 0)
                {
                    FormHelper.Instance.Advertencia("Não há nenhum item na lista!");
                    txtNomeItem.Focus();
                    return;
                }

                if (FormHelper.Instance.Pergunta("Confirma itens do pedido?", false) == DialogResult.No)
                    return;

                foreach (DataGridViewRow row in lvwInfo.Rows)
                {
                    ENReservaItens entidadeitem = new ENReservaItens();
                    entidadeitem.cdItem = Convert.ToInt32(row.Cells["cdItem"].Value);
                    entidadeitem.nmItem = Convert.ToString(row.Cells["nmItem"].Value);
                    entidadeitem.vlrUnit = Convert.ToDecimal(row.Cells["valorUnit"].Value);
                    entidadeitem.vlrDesconto = Convert.ToDecimal(row.Cells["vlrDesconto"].Value);
                    entidadeitem.vlrReposicao = Convert.ToDecimal(row.Cells["valorReposicao"].Value);
                    entidadeitem.qtdeItem = Convert.ToInt32(row.Cells["qtdeSolicitada"].Value);
                    entidadeitem.total = Convert.ToDecimal(row.Cells["total"].Value);

                    entidadeItens.Add(entidadeitem);

                    vlrBruto += entidadeitem.vlrUnit * entidadeitem.qtdeItem;
                    vlrDesconto += entidadeitem.vlrDesconto* entidadeitem.qtdeItem;
                    vlrTotal += entidadeitem.total;
                }

                txtValorBruto.Text = txtValorBruto.Text.Trim().Replace('R',' ').Replace('$',' ').Trim();

                dados.vlrReserva = vlrBruto;
                dados.vlrDesconto = vlrDesconto;
                dados.vlrTotal = vlrTotal;

                this.Dispose();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "GetEntidade"
        public List<ENReservaItens> GetEntidade()
        {
            return entidadeItens;
        }
        #endregion

        #region "GetValores"
        public ENReserva GetValores()
        {
            return dados;
        }
        #endregion

        #region "Excluir"
        private void Excluir()
        {
            try
            {
                if (lvwInfo.Rows.Count > 0)
                {
                    if (FormHelper.Instance.Pergunta("Deseja excluir o item da lista?", false) == DialogResult.No)
                        return;

                    lvwInfo.Rows.RemoveAt(lvwInfo.CurrentRow.Index);

                    CalculaTotal();
                }
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
            if (FormHelper.Instance.Pergunta("Deseja limpar os itens da lista?", false) == DialogResult.No)
                return;

            lvwInfo.Rows.Clear();
            txtNomeItem.Text = "";
            txtQtde.Text = "1";

            CalculaTotal();
        }
        #endregion

        #region "AplicarDesconto"
        private void AplicarDesconto()
        {
            try
            {
                if (lvwInfo.Rows.Count == 0)
                    return;

                ENReservaItens item = new ENReservaItens();
                item.cdItem = Convert.ToInt32(lvwInfo.SelectedRows[0].Cells["cdItem"].Value);
                item.nmItem = lvwInfo.SelectedRows[0].Cells["nmItem"].Value.ToString();
                item.qtdeItem = Convert.ToInt32(lvwInfo.SelectedRows[0].Cells["qtdeSolicitada"].Value);
                item.vlrUnit = Convert.ToDecimal(lvwInfo.SelectedRows[0].Cells["valorUnit"].Value);
                item.total = Convert.ToDecimal(lvwInfo.SelectedRows[0].Cells["total"].Value);

                frmDescontoItem frmDesconto = new frmDescontoItem(item);
                this.Enabled = false;
                frmDesconto.ShowDialog();
                item = frmDesconto.GetEntidade();

                lvwInfo.SelectedRows[0].Cells["vlrDesconto"].Value = Convert.ToDouble(item.vlrDesconto).Formatar("N2");
                lvwInfo.SelectedRows[0].Cells["total"].Value = Convert.ToDouble(item.total).Formatar("N2");

                CalculaTotal();

                this.Enabled = true;

                txtNomeItem.Focus();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #endregion

        #region "Eventos"

        #region "lvwInfo2_CellDoubleClick"
        private void lvwInfo2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            qtdeDisponivelSelecionado = Convert.ToInt32(lvwInfo2.CurrentRow.Cells["qtdDisponivel"].Value);
            cdItemSelecionado = Convert.ToInt32(lvwInfo2.CurrentRow.Cells["cdItem"].Value);
            txtNomeItem.Text = Convert.ToString(lvwInfo2.CurrentRow.Cells["nmItem"].Value);
            txtQtde.Focus();
            lvwInfo2.Visible = false;
        }
        #endregion

        #region "lvwInfo2_KeyDown"
        private void lvwInfo2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.Handled = e.SuppressKeyPress = true;
                CarregaProduto();
            }
            else
            {
                if (e.KeyCode == Keys.Escape)
                {
                    lvwInfo2.Visible = false;
                    txtQtde.Text = "1";
                    txtNomeItem.ReadOnly = false;
                    txtNomeItem.Text = "";
                    txtNomeItem.Focus();
                }
            }
        }
        #endregion

        #region "lvwInfo2_Leave"
        private void lvwInfo2_Leave(object sender, EventArgs e)
        {
            if (!lvwInfo2.Visible)
                return;

            lvwInfo2.Visible = false;
            lvwInfo2.DataSource = null;

            txtNomeItem.Focus();
        }
        #endregion

        #region "txtQtde_KeyDown"
        private void txtQtde_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Convert.ToInt32(txtQtde.Text.Trim()) > qtdeDisponivelSelecionado)
                    {
                        FormHelper.Instance.Advertencia("A quantidade solicitada é maior que a quantidade disponível!\nQuantidade solicitada: " + Convert.ToString(txtQtde.Text.Trim()) + ".\nQuantidade disponível: " + Convert.ToString(qtdeDisponivelSelecionado) + ".");
                        txtQtde.Focus();
                        return;
                    }
                    else
                    {
                        CarregaDetalhes();
                        txtNomeItem.ReadOnly = false;
                        txtNomeItem.Text = "";
                        txtQtde.Text = "1";
                        txtNomeItem.Focus();
                    }
                }
                else
                {
                    if (e.KeyCode == Keys.Escape)
                    {
                        txtNomeItem.ReadOnly = false;
                        qtdeDisponivelSelecionado = 0;
                        cdItemSelecionado = 0;
                        txtQtde.Text = "1";
                        txtNomeItem.Text = "";
                        txtNomeItem.Focus();
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            e.Handled = true;
        }
        #endregion

        #region "frmReservaItens_KeyDown"
        private void frmReservaItens_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnPadraoConfirmar.PerformClick();
            }
            else
            {
                if (e.KeyCode == Keys.F12 || e.KeyCode == Keys.Delete)
                {
                    btnPadraoExcluir.PerformClick();
                }
                else
                {
                    if (e.KeyCode == Keys.F3)
                    {
                        btnPadraoNovo.PerformClick();
                    }
                    else
                    {
                        if (e.KeyCode == Keys.Escape)
                        {
                            if (lvwInfo2.Visible)
                            {
                                lvwInfo2.Visible = false;
                                txtNomeItem.Text = "";
                                txtNomeItem.Focus();
                            }
                        }
                        else
                        {
                            if(e.KeyCode == Keys.D)
                            {
                                if(e.Control)
                                {
                                    AplicarDesconto();
                                }
                            }
                        }
                    }
                }
            }
        }
        #endregion 

        #region "txtQtde_KeyPress"
        private void txtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
        #endregion

        #region "btnPadraoConfirmar_Click"
        private void btnPadraoConfirmar_Click(object sender, EventArgs e)
        {
            Confirmar();
        }
        #endregion

        #region "btnPadraoExcluir_Click"
        private void btnPadraoExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }
        #endregion

        #region "btnPadraoNovo_Click"
        private void btnPadraoNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        #endregion

        #region "txtNomeItem_KeyDown"
        private void txtNomeItem_KeyDown(object sender, KeyEventArgs e)
        {
            lvwInfo2.Columns.Clear();

            if (e.KeyCode == Keys.Return)
            {
                if (qtdeDisponivelSelecionado == 0)
                {
                    if (txtNomeItem.Text.Trim() == "")
                    {
                        lvwInfo2.Visible = false;
                        return;
                    }

                    PesquisaProd();
                }
                else
                {
                    txtQtde.Focus();
                }
            }
            else
            {
                if (e.KeyCode == Keys.Escape)
                {
                    txtQtde.Text = "1";
                    txtNomeItem.Text = "";
                    txtNomeItem.Focus();
                }
            }
        }
        #endregion

        #region "txtNomeItem_Leave"
        private void txtNomeItem_Leave(object sender, EventArgs e)
        {
            try
            {
                if (cdItemSelecionado == 0 && !lvwInfo2.Visible)
                {
                    txtNomeItem.Focus();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #endregion


    }
}
