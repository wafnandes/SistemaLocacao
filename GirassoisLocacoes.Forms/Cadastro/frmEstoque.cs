using System;
using System.Data;
using System.Windows.Forms;
using GirassoisLocacoes.Commons;
using GirassoisLocacoes.Entidades;
using GirassoisLocacoes.Negocio;

namespace GirassoisLocacoes.Forms
{
    public partial class frmEstoque : Form
    {
        #region "Variáveis"
        private bool carregouDados = false;
        ENEstoque entidade;
        #endregion

        #region "Construtor"
        public frmEstoque()
        {
            InitializeComponent();
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            Limpar();
        }
        #endregion

        #region "Métodos"

        #region "Limpar"
        private void Limpar()
        {
            CarregarGrid();
            ConfigurarGrid();
            carregouDados = false;
            FormHelper.Instance.setControlInitialState(true, true, txtNome, txtQtde, txtVlrUnit, txtVlrRepo, txtDescricao);
            FormHelper.Instance.setControlInitialState(false, false, txtCodigo);
            txtVlrRepo.Text = "0,00";
            txtVlrUnit.Text = "0,00";
            ObterProxId();
        }
        #endregion

        #region "CarregarGrid"
        private void CarregarGrid()
        {
            try
            {
                lvwInfo.Columns.Clear();
                Cursor = Cursors.WaitCursor;

                lvwInfo.DataSource = NEEstoque.Instance.Obter().Tables[0];
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
        #endregion

        #region "ConfigurarGrid"
        private void ConfigurarGrid()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (lvwInfo.Rows.Count > 0)
                {
                    lvwInfo.Columns["cdItem"].HeaderText = "Código";
                    lvwInfo.Columns["nmItem"].HeaderText = "Nome";
                    lvwInfo.Columns["qtdEstoque"].Visible = false;
                    lvwInfo.Columns["valorUnit"].Visible = false;
                    lvwInfo.Columns["descItem"].Visible = false;
                    lvwInfo.Columns["valorReposicao"].Visible = false;
                    lvwInfo.Columns["cdItem"].Width = 50;
                    lvwInfo.Columns["nmItem"].Width = 255;

                    if (lvwInfo.Rows.Count > 5)
                        lvwInfo.Columns["nmItem"].Width = 240;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        #endregion

        #region "ObterProxId"
        public void ObterProxId()
        {
            try
            {
                DataSet dsCodigo = new DataSet();
                dsCodigo = NEEstoque.Instance.ObterProxId();

                txtCodigo.Text = dsCodigo.Tables[0].Rows[0]["CDITEM"].ToString();
            }
            catch(Exception ex)
            {
                throw ex;
            } 
        }
        #endregion

        #region "BuildFormData"
        private ENEstoque BuildFormData()
        {
            ENEstoque pEntidade = new ENEstoque();
            pEntidade.cdItem = Convert.ToInt32(txtCodigo.Text.Trim());
            pEntidade.nomeItem = txtNome.Text.Trim();
            pEntidade.qtdeEstoque = Convert.ToInt32(txtQtde.Text.Trim());
            pEntidade.valorUnit = Convert.ToDecimal(txtVlrUnit.Text.Trim());
            pEntidade.valorReposicao = Convert.ToDecimal(txtVlrRepo.Text.Trim());

            if(txtDescricao.Text.Trim() != "") 
                pEntidade.descItem = txtDescricao.Text.Trim();

            return pEntidade;
        }
        #endregion

        #region "Gravar"
        private void Gravar()
        {
            try
            {
                if (!ValidaDados())
                    return;

                entidade = BuildFormData();

                if (FormHelper.Instance.Pergunta(!carregouDados ? "Confirma inclusão?" : "Confirma alteração?", false) == DialogResult.No)
                    return;

                NEEstoque.Instance.Gravar(entidade);

                FormHelper.Instance.Informacao(!carregouDados ? "Cadastro realizado com sucesso!" : "Cadastro alterado com sucesso!");

                Limpar();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "Excluir"
        private void Excluir()
        {
            if (carregouDados)
            {
                entidade = BuildFormData();

                if (FormHelper.Instance.Pergunta("Deseja excluir o cadastro?", true) == DialogResult.No)
                    return;

                NEEstoque.Instance.Excluir(entidade);

                FormHelper.Instance.Informacao("Registro excluído com sucesso!");
                Limpar();
            }
        }
        #endregion

        #region "ValidaDados"
        private bool ValidaDados()
        {
            if (txtNome.Text.Trim() == "")
            {
                FormHelper.Instance.Advertencia("Preencha o nome do item!");
                txtNome.Focus();
                return false;
            }
            if (txtQtde.Text.Trim() == "")
            {
                FormHelper.Instance.Advertencia("Preencha a quantidade do item!");
                txtQtde.Focus();
                return false;
            }
            if (Convert.ToInt32(txtQtde.Text.Trim()) <= 0)
            {
                FormHelper.Instance.Advertencia("Insira uma quantidade válida!");
                txtQtde.Focus();
                return false;
            }
            if (txtVlrUnit.Text.Trim() == "")
            {
                FormHelper.Instance.Advertencia("Preencha o valor unitário!");
                txtVlrUnit.Focus();
                return false;
            }
            if (Convert.ToDouble(txtVlrUnit.Text.Trim().Replace(',','.')) <= 0)
            {
                FormHelper.Instance.Advertencia("Insira um valor válido!");
                txtVlrUnit.Focus();
                return false;
            }

            return true;
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

        #region "txtQtde_KeyPress"
        private void txtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
        #endregion

        #region "txtVlrUnit_KeyPress"
        private void txtVlrUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.SoNumeros(e, enumVirgulaPonto.ConvertePontoVirgula);
        }
        #endregion

        #region "lvwInfo_CellDoubleClick"
        private void lvwInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lvwInfo.Rows.Count > 0)
            {
                if (FormHelper.Instance.Pergunta("Deseja carregar os dados?", false) == DialogResult.Yes)
                {
                    carregouDados = true;

                    txtCodigo.Text = Convert.ToString(lvwInfo.CurrentRow.Cells["cdItem"].Value);
                    txtNome.Text = Convert.ToString(lvwInfo.CurrentRow.Cells["nmItem"].Value);
                    txtQtde.Text = Convert.ToString(lvwInfo.CurrentRow.Cells["qtdEstoque"].Value);
                    txtVlrUnit.Text = Funcoes.Formatar(Convert.ToDouble(lvwInfo.CurrentRow.Cells["valorUnit"].Value), "N2");
                    txtDescricao.Text = Convert.ToString(lvwInfo.CurrentRow.Cells["descItem"].Value);
                    txtVlrRepo.Text = Convert.ToString(lvwInfo.CurrentRow.Cells["valorReposicao"].Value);

                    SSTab.SelectTab(0);

                    txtNome.Focus();
                }
            }
        }
        #endregion

        #region "txtVlrUnit_Leave"
        private void txtVlrUnit_Leave(object sender, EventArgs e)
        {
            if (txtVlrUnit.Text == "0,00")
                return;

            if (txtVlrUnit.Text == "")
                txtVlrUnit.Text = "0,00";

            txtVlrUnit.Text = Funcoes.Formatar(Convert.ToDouble(txtVlrUnit.Text.Trim()), "N2");
        }
        #endregion

        #region "frmEstoque_KeyDown"
        private void frmEstoque_KeyDown(object sender, KeyEventArgs e)
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
                if(lvwInfo.Rows.Count == 0)
                {
                    FormHelper.Instance.Critica("Não existe estoque a ser consultado!");
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

        #region "txtVlrRepo_Leave"
        private void txtVlrRepo_Leave(object sender, EventArgs e)
        {
            if (txtVlrRepo.Text == "0,00")
                return;

            if (txtVlrRepo.Text == "")
                txtVlrRepo.Text = "0,00";

            txtVlrRepo.Text = Funcoes.Formatar(Convert.ToDouble(txtVlrRepo.Text.Trim()), "N2");
        }
        #endregion

        #region "txtVlrRepo_KeyPress"
        private void txtVlrRepo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.SoNumeros(e, enumVirgulaPonto.ConvertePontoVirgula);
        }
        #endregion

        #endregion
    }
}