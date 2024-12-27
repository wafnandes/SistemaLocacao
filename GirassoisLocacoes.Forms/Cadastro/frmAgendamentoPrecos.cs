using GirassoisLocacoes.Commons;
using GirassoisLocacoes.Entidades;
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
    public partial class frmAgendamentoPrecos : Form
    {
        int cdItemSelecionado = 0;
        int idPreco = 0;

        public frmAgendamentoPrecos()
        {
            InitializeComponent();
        }

        private void frmAgendamentoPrecos_Load(object sender, EventArgs e)
        {
            Limpar();
        }

        #region "Métodos"

        #region "Limpar"
        private void Limpar()
        {
            dtpFim.MinDate = DateTime.Now.AddDays(1);
            dtpFim.Value = DateTime.Now.AddDays(1);
            dtpInicio.MinDate = DateTime.Now;
            dtpInicio.Value = DateTime.Now;
            txtVlrUnit.Text = "0,00";
            txtNovoVlrUnit.Text = "0,00";
            cdItemSelecionado = 0;
            idPreco = 0;
            CarregaCombo();
            CarregaGrid();
            ConfiguraGrid();
            cboItem.Focus();

            if (idPreco == 0)
                btnPadraoExcluir.Visible = false;
        }
        #endregion

        private void CarregaGrid()
        {
            try
            { 
                lvwInfo.Columns.Clear();
                Cursor = Cursors.WaitCursor;

                if(NEAgendamentoPrecos.Instance.Obter().Tables[0].Rows.Count > 0)
                    lvwInfo.DataSource = NEAgendamentoPrecos.Instance.Obter().Tables[0];
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void ConfiguraGrid()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (lvwInfo.Rows.Count > 0)
                {
                    lvwInfo.Columns["nmItem"].HeaderText = "Nome";
                    lvwInfo.Columns["nmItem"].Width = 265;
                    lvwInfo.Columns["idPreco"].Visible = false;
                    lvwInfo.Columns["cdItem"].Visible = false;
                    lvwInfo.Columns["vlrUnit"].HeaderText = "Valor";
                    lvwInfo.Columns["vlrUnit"].Width = 64;
                    lvwInfo.Columns["dtInicio"].HeaderText = "Início";
                    lvwInfo.Columns["dtInicio"].Width = 80;
                    lvwInfo.Columns["dtFim"].HeaderText = "Fim";
                    lvwInfo.Columns["dtFim"].Width = 80;

                    if (lvwInfo.Rows.Count > 4)
                    {
                        lvwInfo.Columns["dtInicio"].Width = 70;
                        lvwInfo.Columns["dtFim"].Width = 70;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        #region "CarregaCombo"
        private void CarregaCombo()
        {
            try
            {
                DataSet ds = new DataSet();
                List<ENEstoque> Itens = new List<ENEstoque>();

                Itens = NEAgendamentoPrecos.Instance.ObterDadosCombo();

                cboItem.Items.Clear();

                foreach (ENEstoque estoque in Itens)
                {
                    cboItem.Items.Add(estoque.nomeItem);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "ValidaDados"
        private bool ValidaDados()
        {
            if(txtNovoVlrUnit.Text.Trim() == "0,00")
            {
                FormHelper.Instance.Advertencia("Novo valor unitário inválido!");
                txtNovoVlrUnit.Focus();
                return false;
            }

            return true;
        }
        #endregion

        #region "BuildFormData"
        private ENAgendamentoPrecos BuildFormData()
        {
            ENAgendamentoPrecos pEntidadeDados = new ENAgendamentoPrecos();

            if (idPreco != 0)
                pEntidadeDados.idPreco = idPreco;

            pEntidadeDados.cdItem = cdItemSelecionado;
            pEntidadeDados.vlrUnit = Convert.ToDecimal(txtNovoVlrUnit.Text.Trim());
            pEntidadeDados.dtInicio = Convert.ToDateTime(dtpInicio.Text);
            pEntidadeDados.dtFim = Convert.ToDateTime(dtpFim.Text);

            return pEntidadeDados;
        }
        #endregion

        #region "Gravar"
        private void Gravar()
        {
            try
            {
                DataSet objDs = new DataSet();
                ENAgendamentoPrecos entidade = new ENAgendamentoPrecos();

                if (!ValidaDados())
                    return;

                entidade = BuildFormData();

                if (FormHelper.Instance.Pergunta("Confirma inclusão?", false) == DialogResult.No)
                    return;

                NEAgendamentoPrecos.Instance.Gravar(entidade);

                FormHelper.Instance.Informacao("Agendamento de preços incluído com sucesso!\n\n" + 
                                               "Item: " + cboItem.Text +
                                               "\nValor Unitário: R$ " + Convert.ToDouble(entidade.vlrUnit).Formatar("N2") +
                                               "\nData de Início: " + dtpInicio.Text +
                                               "\nData de Fim: " + dtpFim.Text);

                Limpar();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #endregion

        #region "Eventos"

        #region "txtVlrUnit_KeyPress"
        private void txtVlrUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.SoNumeros(e, enumVirgulaPonto.ConvertePontoVirgula);
        }
        #endregion

        #region "txtVlrUnit_Leave"
        private void txtVlrUnit_Leave(object sender, EventArgs e)
        {
            if (txtVlrUnit.Text.Trim() == "")
                return;

            txtVlrUnit.Text = Convert.ToDouble(txtVlrUnit.Text.Trim()).Formatar("N2");
        }
        #endregion

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

        }
        #endregion

        #region "btnPadraoNovo_Click"
        private void btnPadraoNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        #endregion

        #region "cboItem_SelectedValueChanged"  
        private void cboItem_SelectedValueChanged(object sender, EventArgs e)
        {
            txtNovoVlrUnit.Text = "0,00";
            dtpInicio.MinDate = DateTime.Now;
            dtpInicio.Value = DateTime.Now;
            dtpFim.MinDate = DateTime.Now;
            dtpFim.Value = DateTime.Now.AddDays(1);

            DataSet ds = new DataSet();
            List<ENEstoque> Itens = new List<ENEstoque>();
            int i;

            Itens = NEAgendamentoPrecos.Instance.ObterDadosCombo();

            for (i = 0; Itens[i].nomeItem != cboItem.Text; i++);

            txtVlrUnit.Text = "R$ " + Convert.ToDouble(Itens[i].valorUnit).Formatar("N2");
            cdItemSelecionado = Convert.ToInt32(Itens[i].cdItem);

            txtNovoVlrUnit.Focus();
        }
        #endregion

        #region "txtNovoVlrUnit_KeyPress"
        private void txtNovoVlrUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.SoNumeros(e, enumVirgulaPonto.ConvertePontoVirgula);
        }
        #endregion

        #region "txtNovoVlrUnit_Leave"
        private void txtNovoVlrUnit_Leave(object sender, EventArgs e)
        {
            if (txtNovoVlrUnit.Text.Trim() == "")
                txtNovoVlrUnit.Text = "0,00";

            txtNovoVlrUnit.Text = Convert.ToDouble(txtNovoVlrUnit.Text.Trim()).Formatar("N2");
        }
        #endregion

        #region "dtpInicio_ValueChanged"
        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            if(idPreco == 0)
                dtpFim.Value = Convert.ToDateTime(dtpInicio.Value).AddDays(1);
        }
        #endregion

        #region "frmAgendamentoPrecos_KeyDown"
        private void frmAgendamentoPrecos_KeyDown(object sender, KeyEventArgs e)
        {
            if (SSTab.SelectedIndex == 0)
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
        }
        #endregion

        #region "SSTab_SelectedIndexChanged"
        private void SSTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SSTab.SelectedIndex == 1)
            {
                if (lvwInfo.Rows.Count == 0)
                {
                    FormHelper.Instance.Critica("Não existe preço agendado a ser consultado!");
                    SSTab.SelectedIndex = 0;
                    return;
                }

                btnPadraoConfirmar.Visible = false;
                btnPadraoExcluir.Visible = false;
                btnPadraoNovo.Visible = false;
            }
            else
            {
                btnPadraoConfirmar.Visible = true;
                btnPadraoExcluir.Visible = true;
                btnPadraoNovo.Visible = true;
            }
        }
        #endregion

        #region "lvwInfo_DataBindingComplete"
        private void lvwInfo_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                lvwInfo.Rows[0].Selected = false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "txtNovoVlrUnit_Enter"
        private void txtNovoVlrUnit_Enter(object sender, EventArgs e)
        {
            txtNovoVlrUnit.SelectAll();
        }
        #endregion

        #region "lvwInfo_CellDoubleClick"
        private void lvwInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lvwInfo.Rows.Count > 0)
            {
                if (FormHelper.Instance.Pergunta("Deseja carregar os dados?", false) == DialogResult.Yes)
                {
                    cboItem.SelectedItem = lvwInfo.CurrentRow.Cells["nmItem"].Value.ToString();
                    txtNovoVlrUnit.Text = Convert.ToDouble(lvwInfo.CurrentRow.Cells["vlrUnit"].Value.ToString().Replace("R", "").Replace("$", "").Trim()).Formatar("N2");
                    idPreco = Convert.ToInt32(lvwInfo.CurrentRow.Cells["idPreco"].Value);
                    dtpInicio.MinDate = Convert.ToDateTime(lvwInfo.CurrentRow.Cells["dtInicio"].Value);
                    dtpInicio.Value = Convert.ToDateTime(lvwInfo.CurrentRow.Cells["dtInicio"].Value);
                    dtpFim.MinDate = Convert.ToDateTime(lvwInfo.CurrentRow.Cells["dtInicio"].Value);
                    dtpFim.Value = Convert.ToDateTime(lvwInfo.CurrentRow.Cells["dtFim"].Value);

                    SSTab.SelectTab(0);
                }
            }
        }
        #endregion
    }
}
