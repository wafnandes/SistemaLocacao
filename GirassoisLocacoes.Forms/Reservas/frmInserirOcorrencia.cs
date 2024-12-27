using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using GirassoisLocacoes.Commons;
using GirassoisLocacoes.Entidades;
using GirassoisLocacoes.Negocio;

namespace GirassoisLocacoes.Forms
{
    public partial class frmInserirOcorrencia : Form
    {
        #region "Variáveis"
        ENReserva pEntidadeDados = new ENReserva();
        ENReservaItens pEntidadeItens = new ENReservaItens();
        List<ENReservaItens> pEntidadeListaItens = new List<ENReservaItens>();
        #endregion

        #region "Construtor"
        public frmInserirOcorrencia(ENReserva entidade)
        {
            pEntidadeDados = entidade;
            InitializeComponent();
        }

        private void frmInserirOcorrencia_Load(object sender, EventArgs e)
        {
            Limpar();
        }
        #endregion

        #region "Métodos"

        #region "Limpar"
        private void Limpar()
        {
            lblNroReserva.Text = Funcoes.Formatar(Convert.ToDouble(pEntidadeDados.cdReserva),"00000");
            txtDescOcorrencia.Text = "";
            CarregaCombo();
        }
        #endregion

        #region "ValidaDados"
        private bool ValidaDados()
        {
            if(txtDescOcorrencia.Text.Trim() == "")
            {
                FormHelper.Instance.Advertencia("Descreva a ocorrência!");
                txtDescOcorrencia.Focus();
                return false;
            }

            return true;
        }
        #endregion

        #region "BuildFormData"
        private ENReserva BuildFormData()
        {
            try
            {
                ENReserva entidade = new ENReserva();

                entidade.cdReserva = pEntidadeDados.cdReserva;
                entidade.ocorrencia = true;
                entidade.descOcorrencia = txtDescOcorrencia.Text.Trim();

                return entidade;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "BuildFormDataItem"
        private ENReservaItens BuildFormDataItem()
        {
            try
            {
                ENReservaItens entidade = new ENReservaItens();

                if (cboQtde.Text != "")
                {
                    entidade.idReserva = pEntidadeDados.cdReserva;
                    entidade.cdItem = pEntidadeItens.cdItem;
                    entidade.vlrUnit = pEntidadeItens.vlrBruto;
                    entidade.vlrReposicao = 0;
                    entidade.vlrDesconto = 0;
                    entidade.qtdeItem = Convert.ToInt32(cboQtde.Text);
                    entidade.total = Convert.ToDecimal(pEntidadeItens.vlrBruto * Convert.ToDecimal(cboQtde.Text));
                }

                return entidade;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "Gravar"
        private void Gravar()
        {
            try
            {
                ENReserva ocorrencia = new ENReserva();
                ENReservaItens item = new ENReservaItens();

                if (!ValidaDados())
                    return;

                ocorrencia = BuildFormData();
                item = BuildFormDataItem();

                if (FormHelper.Instance.Pergunta("Deseja inserir a ocorrência na reserva?", false) == DialogResult.No)
                    return;

                NEReserva.Instance.InserirOcorrencia(ocorrencia);
                NEReservaItens.Instance.GravarItem(item);

                FormHelper.Instance.Informacao("Ocorrência inserida com sucesso!");

                Limpar();

                this.Dispose();
            }
            catch(Exception ex)
            {
                throw ex;
            }  
        }
        #endregion

        #region "CarregaCombo"
        private void CarregaCombo()
        {
            try
            {
                DataSet ds = new DataSet();
                List<ENReservaItens> Itens = new List<ENReservaItens>();

                pEntidadeDados.idFinalizado = true;
                Itens = NEReserva.Instance.ObterItensReserva(pEntidadeDados);

                foreach (ENReservaItens item in Itens)
                {
                    if(item.cdItem != 999 && item.cdItem != 998)
                        cboItem.Items.Add(item.nmItem.ToString());
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #endregion

        #region "Eventos"

        #region "btnPadraoConfirmar_Click"
        private void btnPadraoConfirmar_Click(object sender, EventArgs e)
        {
            Gravar();
        }
        #endregion

        #region "btnPadraoNovo_Click"
        private void btnPadraoNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        #endregion

        #region "frmInserirOcorrencia_KeyDown"
        private void frmInserirOcorrencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            else
            {
                if (e.KeyCode == Keys.F2)
                {
                    btnPadraoConfirmar.PerformClick();
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
        #endregion

        #region "cboItem_SelectedValueChanged"
        private void cboItem_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboItem.Text != "")
                {
                    DataSet ds = new DataSet();
                    List<ENReservaItens> Itens = new List<ENReservaItens>();
                    int quantidade = 0;
                    cboQtde.Enabled = true;

                    Itens = NEReserva.Instance.ObterItensReserva(pEntidadeDados);

                    foreach (ENReservaItens item in Itens)
                    {
                        if (item.nmItem == cboItem.Text)
                        {
                            quantidade = item.qtdeItem;

                            pEntidadeItens.cdItem = item.cdItem;
                            pEntidadeItens.vlrBruto = item.vlrReposicao;
                            pEntidadeItens.vlrDesconto = 0;
                            pEntidadeItens.vlrUnit = item.vlrReposicao;
                            pEntidadeItens.vlrReposicao = 0;
                        }
                    }

                    cboQtde.Items.Clear();

                    for (int i = 1; i <= quantidade; i++)
                        cboQtde.Items.Add(i.ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "chkReposicao_CheckedChanged"
        private void chkReposicao_CheckedChanged(object sender, EventArgs e)
        {
            gpoItem.Enabled = chkReposicao.Checked;
        }
        #endregion

        #endregion

    }
}
