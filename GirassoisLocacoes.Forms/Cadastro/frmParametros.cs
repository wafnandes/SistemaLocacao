using System;
using System.Windows.Forms;
using GirassoisLocacoes.Commons;
using GirassoisLocacoes.Entidades;
using GirassoisLocacoes.Negocio;

namespace GirassoisLocacoes.Forms
{
    public partial class frmParametros : Form
    {
        public frmParametros()
        {
            InitializeComponent();
        }

        private void frmParametros_Load(object sender, EventArgs e)
        {
            Limpar();
            btnPadraoExcluir.Visible = false;
        }

        #region "Métodos"

        #region "CarregarGrid"
        private void CarregarGrid()
        {
            try
            {
                lvwInfo.Columns.Clear();
                Cursor = Cursors.WaitCursor;
                lvwInfo.DataSource = NEParametros.Instance.Obter().Tables[0];
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
                    lvwInfo.Columns["codParametro"].HeaderText = "Parâmetro";
                    lvwInfo.Columns["codValorParametro"].HeaderText = "Valor";
                    lvwInfo.Columns["descParametro"].HeaderText = "Descrição";
                    lvwInfo.Columns["idParametro"].Visible = false;
                    lvwInfo.Columns["codParametro"].Width = 170;
                    lvwInfo.Columns["codValorParametro"].Width = 190;
                    lvwInfo.Columns["descParametro"].Width = 190;

                    if (lvwInfo.Rows.Count > 4)
                        lvwInfo.Columns["codParametro"].Width = 153;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        #endregion

        #region "Limpar"
        private void Limpar()
        {
            FormHelper.Instance.setControlInitialState(false, false, txtCodParametro);
            FormHelper.Instance.setControlInitialState(true, true, txtValorParametro, txtDescricaoParametro);
            CarregarGrid();
            ConfigurarGrid();
        }
        #endregion

        #region "Gravar"
        private void Gravar()
        {
            ENParametros entidade = new ENParametros();

            if (!ValidaDados())
                return;

            entidade = BuildFormData();

            if (FormHelper.Instance.Pergunta("Confirma inclusão?", false) == DialogResult.No)
                return;

            NEParametros.Instance.Gravar(entidade);

            FormHelper.Instance.Informacao("Parâmetro cadastrado com sucesso!");

            Limpar();
        }
        #endregion

        #region "BuildFormData"
        private ENParametros BuildFormData()
        {
            try
            {
                ENParametros entidade = new ENParametros();
                entidade.codParametro = txtCodParametro.Text;
                entidade.codValorParametro = txtValorParametro.Text;
                entidade.descParametro = txtDescricaoParametro.Text;

                return entidade;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "ValidaDados"
        private bool ValidaDados()
        {
            try
            {
                if(txtCodParametro.Text == "")
                {
                    FormHelper.Instance.Advertencia("Preencha o nome do parâmetro!");
                    txtCodParametro.Focus();
                    return false;
                }
                if(txtValorParametro.Text == "")
                {
                    FormHelper.Instance.Advertencia("Preencha o valor do parâmetro!");
                    txtValorParametro.Focus();
                    return false;
                }
                if(txtDescricaoParametro.Text == "")
                {
                    FormHelper.Instance.Advertencia("Preencha a descrição do parâmetro!");
                    txtDescricaoParametro.Focus();
                    return false;
                }
                return true;
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

        #endregion

        private void frmParametros_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    btnPadraoConfirmar.PerformClick();
                    break;
                case Keys.F3:
                    btnPadraoNovo.PerformClick();
                    break;
            }
        }

        private void lvwInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lvwInfo.Rows.Count > 0)
            {
                if (FormHelper.Instance.Pergunta("Deseja carregar os dados?", false) == DialogResult.Yes)
                {
                    txtCodParametro.Text = Convert.ToString(lvwInfo.CurrentRow.Cells["codParametro"].Value);
                    txtValorParametro.Text = Convert.ToString(lvwInfo.CurrentRow.Cells["codValorParametro"].Value);
                    txtDescricaoParametro.Text = Convert.ToString(lvwInfo.CurrentRow.Cells["descParametro"].Value);
                    txtValorParametro.Focus();
                }
            }
        }
    }
}
