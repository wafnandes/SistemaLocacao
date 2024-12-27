using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using GirassoisLocacoes.Commons;
using GirassoisLocacoes.Entidades;
using GirassoisLocacoes.Negocio;
using Newtonsoft.Json;

namespace GirassoisLocacoes.Forms
{
    public partial class frmReserva : Form
    {
        #region "Variáveis"
        private ENCliente pEntidadeDadosCliente = new ENCliente();
        private ENEspaco pEntidadeDadosEspaco = new ENEspaco();
        private ENReserva pEntidadeCarregaDados = new ENReserva();
        private List<ENReservaItens> pEntidadeCarregaDadosItens = new List<ENReservaItens>();
        private bool carregouDados = true;
        #endregion

        #region "Construtor"
        public frmReserva()
        {
            InitializeComponent();
        }

        public frmReserva(ENReserva entidade, List<ENReservaItens> entidadeItens)
        {
            pEntidadeCarregaDados = (ENReserva)entidade;
            pEntidadeCarregaDadosItens = (List<ENReservaItens>)entidadeItens;
            InitializeComponent();
        }

        private void frmReserva_Load(object sender, EventArgs e)
        {
            if (pEntidadeCarregaDados.cdReserva == 0)
                Limpar();
            else
                CarregaDados();
        }
        #endregion

        #region "Métodos"

        #region "CarregaCombo"
        private void CarregaCombo()
        {
            cboCidade.Items.Add("Aparecida de Goiânia");
            cboCidade.Items.Add("Aragoiânia");
            cboCidade.Items.Add("Goiânia");
            cboCidade.Items.Add("Hidrolândia");
            cboCidade.Items.Add("Senador Canedo");
        }
        #endregion

        #region "LimpaEndereco"
        private void LimpaEndereco()
        {
            FormHelper.Instance.setControlInitialState(false, false, txtEntregarEm, txtCEP,
                txtEndereco, txtComplemento, txtBairro, cboCidade, txtEstado);
            CarregaCombo();
        }
        #endregion

        #region "Limpar"
        private void Limpar()
        { 
            FormHelper.Instance.setControlInitialState(false, true, txtNome, txtCPF, txtDtNasc, txtTelefone, txtEntregarEm, txtCEP,
                txtEndereco, txtComplemento, txtBairro, cboCidade, txtEstado, txtHrEntrega, txtHrDevolucao, txtObservacoes, chkOrcamento);
            dtpEntrega.Value = DateTime.Now;
            dtpDevolucao.Value = DateTime.Now;
            optEndCadastro.Checked = false;
            optEndEspaco.Checked = false;
            optNovoEndereco.Checked = false;
            chkOrcamento.Checked = false;
            lvwInfo.Rows.Clear();
            btnPesquisa.Focus();
            txtVlrTotal.Text = "R$ 0,00";
            dtpEntrega.Value = DateTime.Now;
            dtpDevolucao.Value = DateTime.Now;
            btnPadraoExcluir.Visible = false;
        }
        #endregion

        #region "ValidaDados"
        private bool ValidaDados()
        {
            if (txtNome.Text.Trim() == "")
            {
                FormHelper.Instance.Advertencia("Escolha o cliente da reserva!");
                btnPesquisa.Focus();
                return false;
            }
            if (optNovoEndereco.Checked)
            {
                //if (txtEntregarEm.Text.Trim() == "")
                //{
                //    FormHelper.Instance.Advertencia("Informe o local da entrega!");
                //    txtEntregarEm.Focus();
                //    return false;
                //}
                //if (txtCEP.Text.Trim() == ".   -")
                //{
                //    FormHelper.Instance.Advertencia("Informe o CEP da entrega!");
                //    txtCEP.Focus();
                //    return false;
                //}
                //if (txtCEP.Text.Trim().Length < 10)
                //{
                //    FormHelper.Instance.Advertencia("CEP inválido!");
                //    txtCEP.Focus();
                //    return false;
                //}
                //if (txtEndereco.Text.Trim() == "")
                //{
                //    FormHelper.Instance.Advertencia("Informe o endereço da entrega!");
                //    txtEndereco.Focus();
                //    return false;
                //}
                //if (txtBairro.Text.Trim() == "")
                //{
                //    FormHelper.Instance.Advertencia("Informe o bairro da entrega!");
                //    txtBairro.Focus();
                //    return false;
                //}
                //if (cboCidade.Text.Trim() == "")
                //{
                //    FormHelper.Instance.Advertencia("Informe a cidade da entrega!");
                //    cboCidade.Focus();
                //    return false;
                //}
            }
            if(lvwInfo.Rows.Count == 0)
            {
                FormHelper.Instance.Advertencia("É necessário incluir um item para salvar a reserva!");
                btnMontarPedido.Focus();
                return false;
            }
            if (txtHrEntrega.Text == "  :" || txtHrEntrega.Text.Trim().Length < 5)
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
            if (txtHrDevolucao.Text == "  :" || txtHrDevolucao.Text.Trim().Length < 5)
            {
                FormHelper.Instance.Advertencia("Hora de devolução inválida!");
                txtHrDevolucao.Focus();
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
        #endregion

        #region "CarregaDetalhes"
        private void CarregaDetalhes(List<ENReservaItens> entidade)
        {
            List<ENReservaItens> listaItens = (List<ENReservaItens>)entidade;

            lvwInfo.Rows.Clear();
            int i;

            foreach (ENReservaItens Item in listaItens)
            {
                i = lvwInfo.Rows.Count;

                lvwInfo.Rows.Add();
                lvwInfo["cdItem", i].Value = Convert.ToDouble(Item.cdItem).Formatar("000"); ;
                lvwInfo["nmItem", i].Value = Item.nmItem;
                lvwInfo["valorUnit", i].Value = "R$ " + Convert.ToDouble(Item.vlrUnit).Formatar("N2");
                lvwInfo["valorReposicao", i].Value = "R$ " + Convert.ToDouble(Item.vlrReposicao).Formatar("N2");
                lvwInfo["vlrDesconto", i].Value = Convert.ToDouble(Item.vlrDesconto).Formatar("N2");
                lvwInfo["qtdeSolicitada", i].Value = Convert.ToString(Item.qtdeItem);
                lvwInfo["total", i].Value = "R$ " + Convert.ToDouble(Item.total).Formatar("N2");
                lvwInfo["dblVlrUnit", i].Value = Convert.ToDouble(Item.vlrUnit).Formatar("N2");
                lvwInfo["dblVlrReposicao", i].Value = Convert.ToDouble(Item.vlrReposicao).Formatar("N2");
                lvwInfo["dblVlrDesconto", i].Value = Convert.ToDouble(Item.vlrDesconto).Formatar("N2");
                lvwInfo["dblTotal", i].Value = Convert.ToDouble(Item.total).Formatar("N2");
            }

            if (lvwInfo.Rows.Count > 5)
                lvwInfo.Columns["nmItem"].Width = 152;
        }
        #endregion

        #region "BuildFormData"
        private ENReserva BuildFormDataReserva()
        {
            ENReserva pEntidade = new ENReserva();
            string dtEntrega;
            string dtDevolucao;

            dtEntrega = dtpEntrega.Text + ' ' + txtHrEntrega.Text;
            dtDevolucao = dtpDevolucao.Text + ' ' + txtHrDevolucao.Text;

            if (pEntidadeCarregaDados.cdReserva != 0)
                pEntidade.cdReserva = pEntidadeCarregaDados.cdReserva;

            pEntidade.cpfcnpj = Convert.ToString(FormHelper.Instance.LimpaNumeros(txtCPF.Text.Trim()));
            pEntidade.cep = txtCEP.Text.Trim() != ".   -" ? Convert.ToInt64(FormHelper.Instance.LimpaNumeros(txtCEP.Text.Trim())) : 0;
            pEntidade.endereco = txtEndereco.Text.Trim();
            pEntidade.compl = txtComplemento.Text.Trim();
            pEntidade.bairro = txtBairro.Text.Trim();
            pEntidade.cidade = cboCidade.Text.Trim();
            pEntidade.estado = txtEstado.Text.Trim();
            pEntidade.dtEntrega = Convert.ToDateTime(dtEntrega);
            pEntidade.dtDevolucao = Convert.ToDateTime(dtDevolucao);

            if (optEndCadastro.Checked)
            {
                pEntidade.tpEndereco = 1;
            }
            else
            {
                if(optEndEspaco.Checked)
                {
                    pEntidade.tpEndereco = 2;
                }
                else
                {
                    pEntidade.tpEndereco = 3;
                }
            }

            pEntidade.nmLocalEntrega = txtEntregarEm.Text.Trim();
            pEntidade.observacao = txtObservacoes.Text.Trim();
            pEntidade.orcamento = chkOrcamento.Checked;
            pEntidade.vlrTotal = Convert.ToDecimal(txtVlrTotal.Text.Trim().Replace("R"," ").Replace("$"," ").Trim());
            pEntidade.vlrDescontoItens = Convert.ToDecimal(txtVlrDesconto.Text.Trim().Replace("R"," ").Replace("$"," ").Trim());
            pEntidade.vlrDesconto = Convert.ToDecimal(txtOutrosDescontos.Text.Trim().Replace("R"," ").Replace("$"," ").Trim());
            pEntidade.vlrReserva = Convert.ToDecimal(txtVlrBruto.Text.Trim().Replace("R"," ").Replace("$"," ").Trim());
            pEntidade.idFinalizado = false;

            return pEntidade;
        }
        #endregion

        #region "BuildFormDataItens"
        private List<ENReservaItens> BuildFormDataItens(int _cdReserva)
        {
            int idReserva = 0;
            List<ENReservaItens> listaItens = new List<ENReservaItens>();

            if (pEntidadeCarregaDados.cdReserva == 0)
            {
                idReserva = _cdReserva;
            }
            else
            {
                ENReserva cdReserva = new ENReserva();
                idReserva = pEntidadeCarregaDados.cdReserva;
                
                cdReserva.cdReserva = idReserva;
                NEReservaItens.Instance.LimparItensReserva(cdReserva);
            }

            foreach (DataGridViewRow row in lvwInfo.Rows)
            {
                ENReservaItens item = new ENReservaItens();

                item.idReserva = idReserva;
                item.cdItem = Convert.ToInt32(row.Cells["cdItem"].Value);
                item.vlrUnit = Convert.ToDecimal(row.Cells["dblVlrUnit"].Value);
                item.vlrReposicao = Convert.ToDecimal(row.Cells["dblVlrReposicao"].Value);
                item.vlrDesconto = Convert.ToDecimal(row.Cells["dblVlrDesconto"].Value);
                item.qtdeItem = Convert.ToInt32(row.Cells["qtdeSolicitada"].Value);
                item.total = Convert.ToDecimal(row.Cells["dblTotal"].Value);

                listaItens.Add(item);
            }

            return listaItens;
        }
        #endregion

        #region "Gravar"
        private void Gravar() 
        {
            ENReserva entidadeReserva = new ENReserva();
            List<ENReservaItens> itensReserva = new List<ENReservaItens>();
            DataSet cdReservaGravada = new DataSet();

            if (!ValidaDados())
                return;

            entidadeReserva = BuildFormDataReserva();
            
            if (FormHelper.Instance.Pergunta(chkOrcamento.Checked ? "Confirma orçamento?" :"Confirma reserva?", false) == DialogResult.No)
                return;

            cdReservaGravada = NEReserva.Instance.Gravar(entidadeReserva);

            itensReserva = BuildFormDataItens(Convert.ToInt32(cdReservaGravada.Tables[0].Rows[0]["cdReserva"]));

            NEReservaItens.Instance.Gravar(itensReserva);

            entidadeReserva.cdReserva = Convert.ToInt32(cdReservaGravada.Tables[0].Rows[0]["cdReserva"]);
            entidadeReserva = NEReserva.Instance.ObterDetalhesReserva(entidadeReserva);
            itensReserva = NEReserva.Instance.ObterItensReserva(entidadeReserva);

            string nome = entidadeReserva.nmCliente.ToString();
            string[] palavras = nome.Split(' ');

            GeraPDF.Instance.GeraPDFReservaA4(entidadeReserva, itensReserva, "Reserva_" + Funcoes.Formatar(Convert.ToDouble(cdReservaGravada.Tables[0].Rows[0]["cdReserva"]), "00000") + "_" + $"{palavras[0]}");

            Limpar();

            if (pEntidadeCarregaDados.cdReserva != 0)
                this.Dispose();
        }
        #endregion

        #region "Excluir"
        private void Excluir()
        {
            try
            {
                if(pEntidadeCarregaDados.cdReserva != 0)
                {
                    if(FormHelper.Instance.Pergunta("Deseja excluir a reserva?", false) == DialogResult.No)
                        return;

                    NEReserva.Instance.Excluir(pEntidadeCarregaDados);

                    FormHelper.Instance.Informacao("Reserva excluída com sucesso!");

                    this.Dispose();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "InserirTaxaEntrega"
        private void InserirTaxaEntrega()
        {
            try
            {
                if (txtVlrTotal.Text == "R$ 0,00")
                    return;

                if (FormHelper.Instance.Pergunta("Deseja incluir taxa de entrega?", false) == DialogResult.No)
                    return;

                this.Enabled = false;

                ENReservaItens txEntrega = new ENReservaItens();
                frmTaxaEntrega taxaEntrega = new frmTaxaEntrega();
                double total;

                taxaEntrega.ShowDialog();
                txEntrega = taxaEntrega.GetEntidade();

                int i = lvwInfo.Rows.Count;

                lvwInfo.Rows.Add();
                lvwInfo["cdItem", i].Value = Convert.ToDouble(txEntrega.cdItem).Formatar("000"); ;
                lvwInfo["nmItem", i].Value = txEntrega.nmItem;
                lvwInfo["valorUnit", i].Value = "R$ " + Convert.ToDouble(txEntrega.vlrUnit).Formatar("N2");
                lvwInfo["valorReposicao", i].Value = "R$ " + Convert.ToDouble(txEntrega.vlrReposicao).Formatar("N2");
                lvwInfo["vlrDesconto", i].Value = Convert.ToDouble(txEntrega.vlrDesconto).Formatar("N2");
                lvwInfo["qtdeSolicitada", i].Value = Convert.ToString(txEntrega.qtdeItem);
                lvwInfo["total", i].Value = "R$ " + Convert.ToDouble(txEntrega.total).Formatar("N2");
                lvwInfo["dblVlrUnit", i].Value = Convert.ToDouble(txEntrega.vlrUnit).Formatar("N2");
                lvwInfo["dblVlrReposicao", i].Value = Convert.ToDouble(txEntrega.vlrReposicao).Formatar("N2");
                lvwInfo["dblVlrDesconto", i].Value = Convert.ToDouble(txEntrega.vlrDesconto).Formatar("N2");
                lvwInfo["dblTotal", i].Value = Convert.ToDouble(txEntrega.total).Formatar("N2");
               
                total = Convert.ToDouble(txtVlrBruto.Text.Replace("R", " ").Replace("$", " ").Trim());
                total += Convert.ToDouble(txEntrega.total);
                txtVlrBruto.Text = "R$ " + total.Formatar("N2");
                total = Convert.ToDouble(txtVlrTotal.Text.Replace("R", " ").Replace("$", " ").Trim());
                total += Convert.ToDouble(txEntrega.total);
                txtVlrTotal.Text = "R$ " + total.Formatar("N2");


                this.Enabled = true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "AplicarDescontoReserva"
        private void AplicarDescontoReserva()
        {
            try
            {
                if (txtVlrTotal.Text == "R$ 0,00")
                    return;

                if (FormHelper.Instance.Pergunta("Deseja aplicar desconto na reserva?", false) == DialogResult.No)
                    return;

                double vlrReserva;

                vlrReserva = Convert.ToDouble(txtVlrBruto.Text.Replace("R", " ").Replace("$", " ").Trim()) - Convert.ToDouble(txtVlrDesconto.Text.Replace("R", " ").Replace("$", " ").Trim());

                frmDescontoReserva descontoReserva = new frmDescontoReserva(vlrReserva);
                ENReserva entidadeValores = new ENReserva();

                this.Enabled = false;
                descontoReserva.ShowDialog();
                entidadeValores = descontoReserva.GetEntidade();
                txtOutrosDescontos.Text = "R$ " + Convert.ToDouble(entidadeValores.vlrDesconto).Formatar("N2");
                txtVlrTotal.Text = "R$ " + (Convert.ToDouble(txtVlrBruto.Text.Replace("R"," ").Replace("$"," ").Trim()) - Convert.ToDouble(txtVlrDesconto.Text.Replace("R", " ").Replace("$", " ").Trim())  - Convert.ToDouble(entidadeValores.vlrDesconto)).Formatar("N2");

                this.Enabled = true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #endregion

        #region "Eventos"

        #region "btnPesquisa_Click"
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                frmPesquisaCliente pesquisa = new frmPesquisaCliente();
                this.Enabled = false;
                pesquisa.ShowDialog();
                pEntidadeDadosCliente = pesquisa.GetEntidade();
                this.Enabled = true;

                if (Convert.ToInt64(pEntidadeDadosCliente.cpfcnpj) !=0)
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
        #endregion

        #region "optEndCadastro_CheckedChanged"
        private void optEndCadastro_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optEndCadastro.Checked)
                {
                    FormHelper.Instance.setControlInitialState(false, false, txtEntregarEm, txtCEP, txtEndereco, txtComplemento, txtBairro, cboCidade, txtEstado);

                    if (txtNome.Text == "")
                    {
                        FormHelper.Instance.Advertencia("Selecione o cliente!");
                        optEndCadastro.Checked = false;
                        btnPesquisa.Focus();
                        return;
                    }

                    LimpaEndereco();

                    if (pEntidadeDadosCliente.cep != 0)
                    {
                        if (Convert.ToString(pEntidadeDadosCliente.cep) != "0")
                            txtCEP.Text = pEntidadeDadosCliente.cep.ToString();

                        txtEntregarEm.Text = "Endereço do cliente";
                        txtEndereco.Text = pEntidadeDadosCliente.endereco.ToString();
                        txtComplemento.Text = pEntidadeDadosCliente.complemento.ToString();
                        txtBairro.Text = pEntidadeDadosCliente.bairro.ToString();
                        cboCidade.Text = pEntidadeDadosCliente.cidade.ToString();
                        txtEstado.Text = pEntidadeDadosCliente.estado.ToString();

                        FormHelper.Instance.setControlInitialState(true, false, txtHrEntrega, txtHrDevolucao);
                        dtpEntrega.Enabled = true;
                        dtpDevolucao.Enabled = true;
                        btnMontarPedido.Enabled = false;
                        btnMontarPedido.Enabled = true;
                    }
                    else
                    {
                        if(pEntidadeCarregaDados.cdReserva == 0)
                        {
                            FormHelper.Instance.Advertencia("Cliente não tem endereço cadastrado!");
                            optEndCadastro.Checked = false;
                            FormHelper.Instance.setControlInitialState(false, false, dtpEntrega, txtHrEntrega, txtHrDevolucao, dtpDevolucao);
                            btnMontarPedido.Enabled = false;
                        }    
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "optEndEspaco_CheckedChanged"
        private void optEndEspaco_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optEndEspaco.Checked)
                {
                    if (txtNome.Text == "")
                    {
                        FormHelper.Instance.Advertencia("Selecione o cliente!");
                        optEndEspaco.Checked = false;
                        btnPesquisa.Focus();
                        return;
                    }

                    LimpaEndereco();

                    if (optEndEspaco.Checked && (pEntidadeCarregaDados.cdReserva == 0 || !carregouDados))
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

                            txtHrEntrega.Enabled = true;
                            txtHrDevolucao.Enabled = true;
                            dtpEntrega.Enabled = true;
                            dtpDevolucao.Enabled = true;
                            btnMontarPedido.Enabled = true;
                        }
                        else
                        {
                            FormHelper.Instance.setControlInitialState(false, false, txtHrEntrega, txtHrDevolucao);
                            btnMontarPedido.Enabled = false;
                            optEndEspaco.Checked = false;
                        }
                    }
                    else
                    {
                        FormHelper.Instance.setControlInitialState(false, false, txtEntregarEm, txtCEP, txtEndereco, txtComplemento, txtBairro, cboCidade, txtEstado);
                        carregouDados = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "optNovoEndereco_CheckedChanged"
        private void optNovoEndereco_CheckedChanged(object sender, EventArgs e)
        {
            if (optNovoEndereco.Checked)
            {
                if (txtNome.Text == "")
                {
                    FormHelper.Instance.Advertencia("Selecione o cliente!");
                    optNovoEndereco.Checked = false;
                    btnPesquisa.Focus();
                    return;
                }

                FormHelper.Instance.setControlInitialState(true, true, txtEntregarEm, txtCEP, txtEndereco, txtComplemento, txtBairro, cboCidade, txtHrEntrega, txtHrDevolucao);
                btnMontarPedido.Enabled = true;

                dtpEntrega.Enabled = true;
                dtpDevolucao.Enabled = true;
                txtHrEntrega.Enabled = true;
                txtHrDevolucao.Enabled = true;

                CarregaCombo();

                carregouDados = false;
            }
        }
        #endregion

        #region "btnMontarPedido_Click"
        private void btnMontarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                string dtEntrega;
                string dtDevolucao;

                if (txtHrEntrega.Text == "  :" || txtHrEntrega.Text.Length < 5)
                 {
                    FormHelper.Instance.Advertencia("Hora de entrega inválida!");
                    txtHrEntrega.Focus();
                    return;
                }
                if (Convert.ToInt32(txtHrEntrega.Text.Substring(0, 2)) > 23 || Convert.ToInt32(txtHrEntrega.Text.Substring(3, 2)) > 59 || Convert.ToString(txtHrEntrega.Text.Trim().Substring(3, 2)) == "")
                {
                    FormHelper.Instance.Advertencia("Hora de entrega inválida!");
                    txtHrEntrega.Focus();
                    return;
                }
                if (txtHrDevolucao.Text == "  :" || txtHrDevolucao.Text.Length < 5)
                {
                    FormHelper.Instance.Advertencia("Hora de devolução inválida!");
                    txtHrEntrega.Focus();
                    return;
                }
                if (Convert.ToInt32(txtHrDevolucao.Text.Substring(0, 2)) > 23 || Convert.ToInt32(txtHrDevolucao.Text.Substring(3, 2)) > 59 || Convert.ToString(txtHrDevolucao.Text.Trim().Substring(3, 2)) == "")
                {
                    FormHelper.Instance.Advertencia("Hora de devolução inválida!");
                    txtHrEntrega.Focus();
                    return;
                }

                dtEntrega = dtpEntrega.Text + ' ' + txtHrEntrega.Text;
                dtDevolucao = dtpDevolucao.Text + ' ' + txtHrDevolucao.Text;

                ENReserva datas = new ENReserva();
                List<ENReservaItens> listaItens = new List<ENReservaItens>();
                datas.dtEntrega = Convert.ToDateTime(Convert.ToDateTime(dtEntrega));
                datas.dtDevolucao = Convert.ToDateTime(Convert.ToDateTime(dtDevolucao));

                if (pEntidadeCarregaDados.cdReserva != 0)
                {
                    if (FormHelper.Instance.Pergunta("Os itens atuais serão excluídos da reserva e uma nova lista deve ser montada.\nDeseja continuar?", false) == DialogResult.No)
                        return;

                    datas.cdReserva = pEntidadeCarregaDados.cdReserva;

                    lvwInfo.Rows.Clear();

                    NEReservaItens.Instance.LimparItensReserva(datas);
                }
                    
                frmReservaItens itens = new frmReservaItens(datas);
                this.Enabled = false;
                itens.ShowDialog();
                listaItens = itens.GetEntidade();
                datas = itens.GetValores();

                if (listaItens.Count > 0)
                {
                    CarregaDetalhes(listaItens);

                    txtVlrBruto.Text = "R$ " + Convert.ToDouble(datas.vlrReserva).Formatar("N2");
                    txtVlrDesconto.Text = "R$ " + Convert.ToDouble(datas.vlrDesconto).Formatar("N2");
                    txtVlrTotal.Text = "R$ " + Convert.ToDouble(datas.vlrTotal).Formatar("N2");

                    txtObservacoes.Enabled = true;
                    chkOrcamento.Enabled = true;
                    txtObservacoes.Focus();

                    lvwInfo.Rows[0].Selected = false;
                }

                this.Enabled = true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnPadraoConfirmar_Click"
        private void btnPadraoConfirmar_Click(object sender, EventArgs e)
        {
            Gravar();
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
            if (FormHelper.Instance.Pergunta("Deseja limpar as informações inseridas?", false) == DialogResult.No)
                return;

            Limpar();
        }
        #endregion

        #region "frmReserva_KeyDown"
        private void frmReserva_KeyDown(object sender, KeyEventArgs e)
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
                    else
                    {
                        if (e.KeyCode == Keys.T)
                        {
                            if (e.Control)
                            {
                                InserirTaxaEntrega();
                            }
                        }
                        else
                        {
                            if(e.KeyCode == Keys.D)
                            {
                                if (e.Control)
                                {
                                    AplicarDescontoReserva();
                                }

                            }
                            else
                            {
                                if(e.KeyCode == Keys.M)
                                {
                                    if (e.Control)
                                    {
                                        btnMontarPedido.PerformClick();
                                    }
                                } 
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region "cboCidade_SelectedValueChanged"
        private void cboCidade_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboCidade.Text != "")
                txtEstado.Text = "GO";
            else
                txtEstado.Text = "";
        }

        #endregion

        #region "dtpEntrega_ValueChanged"
        private void dtpEntrega_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dtpEntrega.Value) < DateTime.Today)
            {
                dtpEntrega.Value = DateTime.Today;
                return;
            }
            dtpDevolucao.Value = dtpEntrega.Value;
        }
        #endregion

        #region "dtpDevolucao_ValueChanged"
        private void dtpDevolucao_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dtpDevolucao.Value) < DateTime.Today)
            {
                dtpDevolucao.Value = DateTime.Today;
                return;
            }
            else
            {
                if (dtpDevolucao.Value < dtpEntrega.Value)
                {
                    dtpDevolucao.Value = dtpEntrega.Value;
                }
            }
        }
        #endregion

        #region "txtHrEntrega_Leave"
        private void txtHrEntrega_Leave(object sender, EventArgs e)
        {
            if (txtHrEntrega.Text == "  :" || txtHrEntrega.Text.Trim().Length < 5)
            {
                if (txtHrEntrega.Text.Substring(0, 2) == "  ")
                    return;

                if (Convert.ToInt32(txtHrEntrega.Text.Substring(0, 2)) > 0 && Convert.ToInt32(txtHrEntrega.Text.Substring(0, 2)) < 24 && txtHrEntrega.Text.Length == 3)
                {
                    if(Convert.ToInt32(txtHrEntrega.Text.Substring(0,2)) < 10)
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
        #endregion

        #region "txtHrDevolucao_Leave"
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
            if (txtHrEntrega.Text == "  :")
                dtpEntrega.Focus();
        }
        #endregion

        #region "CarregaDados"
        private void CarregaDados()
        {
            txtNome.Text = pEntidadeCarregaDados.nmCliente;
            txtCPF.Text = FormHelper.Instance.MascaraCPFCNPJ(pEntidadeCarregaDados.cpfcnpj);
            txtDtNasc.Text = pEntidadeCarregaDados.dtNasc;
            txtTelefone.Text = pEntidadeCarregaDados.telCliente.ToString();

            if(pEntidadeCarregaDados.tpEndereco == 1)
            {
                optEndCadastro.Checked = true;
            }
            else
            {
                if(pEntidadeCarregaDados.tpEndereco == 2)
                {
                    optEndEspaco.Checked = true;
                }
                else
                {
                    optNovoEndereco.Checked = true;
                }
            }

            txtEntregarEm.Text = pEntidadeCarregaDados.nmLocalEntrega;

            if (pEntidadeCarregaDados.cep == 0)
                txtCEP.Text = "";
            else
                txtCEP.Text = pEntidadeCarregaDados.cep.ToString();

            txtEndereco.Text = pEntidadeCarregaDados.endereco;
            txtComplemento.Text = pEntidadeCarregaDados.compl;
            txtBairro.Text = pEntidadeCarregaDados.bairro;
            cboCidade.Text = pEntidadeCarregaDados.cidade;

            int i = 0;
            foreach (ENReservaItens Item in pEntidadeCarregaDadosItens)
            {
                i = lvwInfo.Rows.Count;

                lvwInfo.Rows.Add();
                lvwInfo["cdItem", i].Value = Funcoes.Formatar(Convert.ToDouble(Item.cdItem), "000"); ;
                lvwInfo["nmItem", i].Value = Item.nmItem;
                lvwInfo["valorUnit", i].Value = "R$ " + Funcoes.Formatar(Convert.ToDouble(Item.vlrUnit), "N2");
                lvwInfo["valorReposicao", i].Value = "R$ " + Funcoes.Formatar(Convert.ToDouble(Item.vlrReposicao), "N2");
                lvwInfo["vlrDesconto", i].Value = "R$ " + Funcoes.Formatar(Convert.ToDouble(Item.vlrDesconto), "N2");
                lvwInfo["qtdeSolicitada", i].Value = Convert.ToString(Item.qtdeItem);
                lvwInfo["total", i].Value = "R$ " + Funcoes.Formatar(Convert.ToDouble(Item.total), "N2");
                lvwInfo["dblVlrUnit", i].Value = Funcoes.Formatar(Convert.ToDouble(Item.vlrUnit), "N2");
                lvwInfo["dblVlrReposicao", i].Value = Funcoes.Formatar(Convert.ToDouble(Item.vlrReposicao), "N2");
                lvwInfo["dblVlrDesconto", i].Value = Funcoes.Formatar(Convert.ToDouble(Item.vlrDesconto), "N2");
                lvwInfo["dblTotal", i].Value = Funcoes.Formatar(Convert.ToDouble(Item.total), "N2");
            }
            lvwInfo.Rows[0].Selected = false;

            dtpEntrega.Text = pEntidadeCarregaDados.strDtEntrega;
            dtpDevolucao.Text = pEntidadeCarregaDados.strDtDevolucao;
            txtHrEntrega.Text = pEntidadeCarregaDados.strHrEntrega;
            txtHrDevolucao.Text = pEntidadeCarregaDados.strHrDevolucao;

            txtVlrBruto.Text = "R$ " + Funcoes.Formatar(Convert.ToDouble(pEntidadeCarregaDados.vlrReserva), "N2");
            txtOutrosDescontos.Text = "R$ " + Funcoes.Formatar(Convert.ToDouble(pEntidadeCarregaDados.vlrDesconto), "N2");
            txtVlrDesconto.Text = "R$ " + Funcoes.Formatar(Convert.ToDouble(pEntidadeCarregaDados.vlrDescontoItens), "N2");
            txtVlrTotal.Text = "R$ " + Funcoes.Formatar(Convert.ToDouble(pEntidadeCarregaDados.vlrTotal), "N2");

            txtObservacoes.Text = pEntidadeCarregaDados.observacao;
            chkOrcamento.Checked = Convert.ToBoolean(pEntidadeCarregaDados.orcamento);

            txtHrEntrega.Enabled = true;
            txtHrDevolucao.Enabled = true;
            btnPadraoExcluir.Visible = true;

            btnMontarPedido.Enabled = true;
        }
        #endregion

        #endregion

        private void txtDtNasc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}