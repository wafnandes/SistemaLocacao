using GirassoisLocacoes.Commons;
using GirassoisLocacoes.Entidades;
using GirassoisLocacoes.Forms;
using GirassoisLocacoes.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirassoisLocacoes.Forms
{
    public partial class frmMontarReserva : Form
    {
        private ENCliente pEntidadeDadosCliente = new ENCliente();
        private ENEspaco pEntidadeDadosEspaco = new ENEspaco();
        private ENEstoque pEntidadeEstoque = new ENEstoque();
        private int telaSelecionada = 1;
        private int qtdeDisponivelSelecionado = 0;
        private int cdItemSelecionado = 0;

        public frmMontarReserva()
        {
            InitializeComponent();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                frmPesquisaCliente pesquisa = new frmPesquisaCliente();
                this.Enabled = false;
                pesquisa.ShowDialog();
                pEntidadeDadosCliente = pesquisa.GetEntidade();
                this.Enabled = true;

                if (Convert.ToInt64(pEntidadeDadosCliente.cpfcnpj) != 0)
                {
                    txtNome.Text = pEntidadeDadosCliente.nome;
                    txtCPF.Text = FormHelper.Instance.MascaraCPFCNPJ(pEntidadeDadosCliente.cpfcnpj.ToString());
                    txtDtNasc.Text = pEntidadeDadosCliente.dataNascimento.ToString();
                    txtTelefone.Text = pEntidadeDadosCliente.telefone.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmMontarReserva_Load(object sender, EventArgs e)
        {
            Limpar();
        }

        #region "CarregaComboTipoEndereco"
        private void CarregaComboTipoEndereco()
        {
            cboTpEndereco.Items.Add("Endereço do cadastro");
            cboTpEndereco.Items.Add("Espaço de eventos");
            cboTpEndereco.Items.Add("Novo endereço");
        }
        #endregion

        private void Limpar()
        {
            CarregaComboTipoEndereco();
            CarregaComboCidade();
            pnlCliente.BringToFront();

            //Removendo botões padrão
            btnPadraoConfirmar.Visible = false;
            btnPadraoExcluir.Visible = false;
            btnPadraoNovo.Visible = false;

            //Limpando controles da tela de seleção do endereço
            FormHelper.Instance.setControlInitialState(false, false, txtEntregarEm, txtCEP, txtEndereco, txtComplemento, txtBairro, cboCidade, txtEstado);

            dtpEntrega.Value = DateTime.Now;
            dtpDevolucao.Value = DateTime.Now;
        }

        private void btnPadraoProximo_Click(object sender, EventArgs e)
        {
            if(telaSelecionada == 1)
            {
                if(txtNome.Text.Trim() == "")
                {
                    FormHelper.Instance.Critica("Informe o cliente da reserva!");
                    return;
                }

                pnlEndereco.BringToFront();
                cboTpEndereco.Focus();
                telaSelecionada = 2;
            }
            else
            {
                if (telaSelecionada == 2)
                {
                    pnlEntregaDevolucao.BringToFront();
                    dtpEntrega.Focus();
                    telaSelecionada = 3;
                }
                else
                {
                    if(telaSelecionada == 3)
                    {
                        if (!ValidaDatas())
                            return;

                        lvwInfo.Rows.Clear();
                        txtNomeItem.Text = "";
                        txtQtde.Text = "1";

                        pnlMontarPedido.BringToFront();
                        txtNomeItem.Focus();
                        telaSelecionada = 4;
                    }
                    else
                    {
                        if(telaSelecionada == 4)
                        {
                            if (lvwInfo.Rows.Count == 0)
                            {
                                FormHelper.Instance.Advertencia("É necessário incluir um item para salvar a reserva!");
                                return;
                            }
                        }
                    }
                }
            }
            
        }

        private void cboTpEndereco_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cboTpEndereco.Text)
            {
                case "Endereço do cadastro":
                    EnderecoCadastro();
                    break;
                case "Espaço de eventos":
                    EnderecoEspacoEventos();
                    break;
                case "Novo endereço":
                    NovoEndereco();
                    break;
            }
        }

        private void EnderecoCadastro()
        {
            try
            {
                FormHelper.Instance.setControlInitialState(false, false, txtEntregarEm, txtCEP, txtEndereco, txtComplemento, txtBairro, cboCidade, txtEstado);

                if (pEntidadeDadosCliente.cep != 0)
                {

                    if (Convert.ToString(pEntidadeDadosCliente.cep) != "0")
                        txtCEP.Text = pEntidadeDadosCliente.cep.ToString();

                    txtEntregarEm.Text = "Endereço do cliente";
                    txtEndereco.Text = pEntidadeDadosCliente.endereco.ToString();
                    txtComplemento.Text = pEntidadeDadosCliente.complemento.ToString();
                    txtBairro.Text = pEntidadeDadosCliente.bairro.ToString();
                    cboCidade.SelectedItem = pEntidadeDadosCliente.cidade.ToString();
                    txtEstado.Text = pEntidadeDadosCliente.estado.ToString();
                }
                else
                {
                    FormHelper.Instance.Advertencia("Cliente não tem endereço cadastrado!");
                    cboTpEndereco.Focus();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }   
        }

        private void EnderecoEspacoEventos()
        {
            try
            {
                FormHelper.Instance.setControlInitialState(false, false, txtEntregarEm, txtCEP, txtEndereco, txtComplemento, txtBairro, cboCidade, txtEstado);
                frmPesquisaEspaco pesquisa = new frmPesquisaEspaco();
                this.Enabled = false;
                pesquisa.ShowDialog();
                pEntidadeDadosEspaco = pesquisa.GetEntidade();
                this.Enabled = true;

                if (pEntidadeDadosEspaco.cep > 0)
                {
                    txtEntregarEm.Text = pEntidadeDadosEspaco.nmEspaco;
                    txtCEP.Text = pEntidadeDadosEspaco.cep.ToString();
                    txtEndereco.Text = pEntidadeDadosEspaco.endEspaco.ToString();
                    txtComplemento.Text = pEntidadeDadosEspaco.compl.ToString();
                    txtBairro.Text = pEntidadeDadosEspaco.bairro.ToString();
                    cboCidade.Text = pEntidadeDadosEspaco.cidade.ToString();
                    txtEstado.Text = pEntidadeDadosEspaco.estado.ToString();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void NovoEndereco()
        {
            try
            {
                FormHelper.Instance.setControlInitialState(true, true, txtEntregarEm, txtCEP, txtEndereco, txtComplemento, txtBairro, cboCidade);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void CarregaComboCidade()
        {
            cboCidade.Items.Add("Aparecida de Goiânia");
            cboCidade.Items.Add("Aragoiânia");
            cboCidade.Items.Add("Goiânia");
            cboCidade.Items.Add("Hidrolândia");
            cboCidade.Items.Add("Senador Canedo");
        }

        private void btnPadraoVoltar_Click(object sender, EventArgs e)
        {
            if(telaSelecionada == 2)
            {
                telaSelecionada = 1;
                pnlCliente.BringToFront();
                btnPesquisa.Focus();
            }
            else
            {
                if(telaSelecionada == 3)
                {
                    telaSelecionada = 2;
                    pnlEndereco.BringToFront();
                    cboTpEndereco.Focus();
                }
                else
                {
                    if(telaSelecionada == 4)
                    {
                        telaSelecionada = 3;
                        pnlEntregaDevolucao.BringToFront();
                        dtpEntrega.Focus();
                    }
                }
            }
        }

        private void frmMontarReserva_KeyDown(object sender, KeyEventArgs e)
        {
            if (telaSelecionada == 5)
            {
                if (e.KeyCode == Keys.F2)
                {
                    btnPadraoConfirmar.PerformClick();
                }
                else
                {
                    if (e.KeyCode == Keys.F12)
                    {
                        btnPadraoExcluir.PerformClick();
                    }
                    else
                    {
                        if (e.KeyCode == Keys.F3)
                        {
                            btnPadraoNovo.PerformClick();
                        }
                    }
                }
            }
            else
            {
                if (e.KeyCode == Keys.F2)
                {
                    btnPadraoProximo.PerformClick();
                }
                else
                {
                    if (e.KeyCode == Keys.F1)
                    {
                        btnPadraoVoltar.PerformClick();
                    }
                }
            }
        }

        private void txtHrEntrega_Leave(object sender, EventArgs e)
        {
            if (txtHrEntrega.Text == "  :" || txtHrEntrega.Text.Trim().Length < 5)
            {
                if (txtHrEntrega.Text.Substring(0, 2) == "  ")
                    return;

                if (Convert.ToInt32(txtHrEntrega.Text.Substring(0, 2)) > 0 && Convert.ToInt32(txtHrEntrega.Text.Substring(0, 2)) < 24 && txtHrEntrega.Text.Length == 3)
                {
                    if (Convert.ToInt32(txtHrEntrega.Text.Substring(0, 2)) < 10)
                        txtHrEntrega.Text = "0" + txtHrEntrega.Text.Trim();

                    txtHrEntrega.Text = txtHrEntrega.Text.Trim() + "00";
                    return;
                }
                else
                {
                    txtHrEntrega.Clear();
                    txtHrEntrega.Focus();
                    return;
                }
            }
            if (Convert.ToInt32(txtHrEntrega.Text.Substring(0, 2)) > 23 || Convert.ToInt32(txtHrEntrega.Text.Substring(3, 2)) > 59 || Convert.ToString(txtHrEntrega.Text.Trim().Substring(3, 2)) == "")
            {
                txtHrEntrega.Clear();
                txtHrEntrega.Focus();
                return;
            }
        }

        private void dtpDevolucao_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dtpDevolucao.Value) < DateTime.Today)
            {
                dtpDevolucao.Value = DateTime.Today;
                return;
            }
            else
            {
                if(Convert.ToDateTime(dtpDevolucao.Value) < Convert.ToDateTime(dtpEntrega.Value))
                {
                    dtpDevolucao.Value = dtpEntrega.Value;
                }
            }
        }

        private void dtpEntrega_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dtpEntrega.Value) < DateTime.Today)
            {
                dtpEntrega.Value = DateTime.Today;
                return;
            }
            dtpDevolucao.Value = dtpEntrega.Value;
        }

        private void txtHrDevolucao_Leave(object sender, EventArgs e)
        {
            if (txtHrDevolucao.Text == "  :" || txtHrDevolucao.Text.Trim().Length < 5)
            {
                if (txtHrDevolucao.Text.Substring(0, 2) == "  ")
                    return;

                if (Convert.ToInt32(txtHrDevolucao.Text.Substring(0, 2)) > 0 && Convert.ToInt32(txtHrDevolucao.Text.Substring(0, 2)) < 24 && txtHrDevolucao.Text.Length == 3)
                {
                    if (Convert.ToInt32(txtHrDevolucao.Text.Substring(0, 2)) < 10)
                        txtHrDevolucao.Text = "0" + txtHrDevolucao.Text.Trim();

                    txtHrDevolucao.Text = txtHrDevolucao.Text.Trim() + "00";
                    return;
                }
                else
                {
                    if (Convert.ToInt32(txtHrDevolucao.Text.Substring(0, 2)) > 23 || Convert.ToInt32(txtHrDevolucao.Text.Substring(3, 2)) > 59 || Convert.ToString(txtHrDevolucao.Text.Trim().Substring(3, 2)) == "")
                    {
                        txtHrDevolucao.Clear();
                        txtHrDevolucao.Focus();
                        return;
                    }

                    txtHrDevolucao.Clear();
                    txtHrDevolucao.Focus();
                    return;
                }
            }
        }

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

        private void lvwInfo2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            qtdeDisponivelSelecionado = Convert.ToInt32(lvwInfo2.CurrentRow.Cells["qtdDisponivel"].Value);
            cdItemSelecionado = Convert.ToInt32(lvwInfo2.CurrentRow.Cells["cdItem"].Value);
            txtNomeItem.Text = Convert.ToString(lvwInfo2.CurrentRow.Cells["nmItem"].Value);
            txtQtde.Focus();
            lvwInfo2.Visible = false;
        }

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

        private void lvwInfo2_Leave(object sender, EventArgs e)
        {
            if (!lvwInfo2.Visible)
                return;

            lvwInfo2.Visible = false;
            lvwInfo2.DataSource = null;

            txtNomeItem.Focus();
        }

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
            catch (Exception ex)
            {
                throw ex;
            }
            e.Handled = true;
        }

        private void txtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void CarregaDetalhes()
        {
            DataSet ds = new DataSet();
            double total = 0;
            int i = lvwInfo.Rows.Count;

            pEntidadeEstoque.qtdeSolicitada = Convert.ToInt32(txtQtde.Text.Trim());

            ds = NEEstoque.Instance.ObterItem(pEntidadeEstoque);

            foreach (DataGridViewRow row in lvwInfo.Rows)
            {
                if (Convert.ToInt32(row.Cells["cdItem"].Value) == Convert.ToInt32(ds.Tables[0].Rows[0]["cdItem"]))
                {
                    FormHelper.Instance.Advertencia("O item " + Convert.ToString(ds.Tables[0].Rows[0]["nmItem"]) + " já está na lista!\n" +
                        "Exclua o item da lista e insira novamente!");
                    return;
                }
            }

            lvwInfo.Rows.Add();
            lvwInfo["cdItem", i].Value = Convert.ToString(ds.Tables[0].Rows[0]["cdItem"]);
            lvwInfo["nmItem", i].Value = Convert.ToString(ds.Tables[0].Rows[0]["nmItem"]);
            lvwInfo["qtdEstoque", i].Value = Convert.ToString(ds.Tables[0].Rows[0]["qtdEstoque"]);
            lvwInfo["valorUnit", i].Value = Convert.ToString(ds.Tables[0].Rows[0]["valorUnit"]);
            lvwInfo["vlrDesconto", i].Value = "0,00";
            lvwInfo["valorReposicao", i].Value = Convert.ToString(ds.Tables[0].Rows[0]["valorReposicao"]);
            lvwInfo["cSit", i].Value = Convert.ToString(ds.Tables[0].Rows[0]["cSit"]);
            lvwInfo["qtdeSolicitada", i].Value = Convert.ToString(ds.Tables[0].Rows[0]["qtdeSolicitada"]);
            lvwInfo["cdItem", i].Value = Convert.ToString(ds.Tables[0].Rows[0]["cdItem"]);

            total = Convert.ToDouble(ds.Tables[0].Rows[0]["valorUnit"]) * Convert.ToDouble(ds.Tables[0].Rows[0]["qtdeSolicitada"]);

            lvwInfo["total", i].Value = Convert.ToString(Funcoes.Formatar(total, "N2"));
            lvwInfo["totalBruto", i].Value = Convert.ToString(Funcoes.Formatar(total, "N2"));

            if (i > 4)
                lvwInfo.Columns["nmItem"].Width = 305;

            CalculaTotal();

            lvwInfo.Rows[i].Selected = true;

            qtdeDisponivelSelecionado = 0;
            cdItemSelecionado = 0;
        }

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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CarregaProduto()
        {
            qtdeDisponivelSelecionado = Convert.ToInt32(lvwInfo2.CurrentRow.Cells["qtdDisponivel"].Value);
            cdItemSelecionado = Convert.ToInt32(lvwInfo2.CurrentRow.Cells["cdItem"].Value);
            pEntidadeEstoque.nomeItem = Convert.ToString(lvwInfo2.CurrentRow.Cells["nmItem"].Value);
            pEntidadeEstoque.cdItem = Convert.ToInt32(lvwInfo2.CurrentRow.Cells["cdItem"].Value);
            pEntidadeEstoque.valorUnit = Convert.ToDecimal(lvwInfo2.CurrentRow.Cells["vlrUnit"].Value);
            pEntidadeEstoque.valorReposicao = Convert.ToDecimal(lvwInfo2.CurrentRow.Cells["vlrReposicao"].Value);
            txtNomeItem.Text = Convert.ToString(lvwInfo2.CurrentRow.Cells["nmItem"].Value);
            lvwInfo2.Visible = false;

            txtQtde.Focus();
        }

        private void PesquisaProd()
        {
            try
            {
                ENReserva entidadeItens = new ENReserva();

                entidadeItens.dtEntrega = Convert.ToDateTime(dtpEntrega.Text.Trim() + " " + txtHrEntrega.Text);
                entidadeItens.dtDevolucao = Convert.ToDateTime(dtpDevolucao.Text.Trim() + " " + txtHrDevolucao.Text);
                entidadeItens.nmItem = txtNomeItem.Text;

                lvwInfo2.DataSource = NEReserva.Instance.ObterEstoqueDisponivel(entidadeItens).Tables[0];

                if (lvwInfo2.Rows.Count > 0)
                {
                    lvwInfo2.Columns["cdItem"].Visible = false;
                    lvwInfo2.Columns["qtdDisponivel"].Visible = true;
                    lvwInfo2.Columns["vlrUnit"].Visible = false;
                    lvwInfo2.Columns["vlrReposicao"].Visible = false;
                    lvwInfo2.Columns["nmItem"].Width = 668;
                    lvwInfo2.Columns["qtdDisponivel"].Width = 42;

                    txtNomeItem.ReadOnly = true;

                    lvwInfo2.Visible = true;
                    lvwInfo2.Focus();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidaDatas()
        {
            if (txtHrEntrega.Text == "  :" || txtHrEntrega.Text.Length < 5)
            {
                FormHelper.Instance.Advertencia("Hora de entrega inválida!");
                txtHrEntrega.Focus();
                return false;
            }
            if (Convert.ToInt32(txtHrEntrega.Text.Substring(0, 2)) > 23 || Convert.ToInt32(txtHrEntrega.Text.Substring(3, 2)) > 59 || Convert.ToString(txtHrEntrega.Text.Trim().Substring(3, 2)) == "")
            {
                FormHelper.Instance.Advertencia("Hora de entrega inválida!");
                txtHrEntrega.Focus();
                return false;
            }
            if (txtHrDevolucao.Text == "  :" || txtHrDevolucao.Text.Length < 5)
            {
                FormHelper.Instance.Advertencia("Hora de devolução inválida!");
                txtHrEntrega.Focus();
                return false;
            }
            if (Convert.ToInt32(txtHrDevolucao.Text.Substring(0, 2)) > 23 || Convert.ToInt32(txtHrDevolucao.Text.Substring(3, 2)) > 59 || Convert.ToString(txtHrDevolucao.Text.Trim().Substring(3, 2)) == "")
            {
                FormHelper.Instance.Advertencia("Hora de devolução inválida!");
                txtHrEntrega.Focus();
                return false;
            }

            return true;
        }
    }
}
