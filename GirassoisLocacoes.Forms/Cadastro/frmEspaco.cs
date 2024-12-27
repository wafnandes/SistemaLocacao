using System;
using System.Windows.Forms;
using GirassoisLocacoes.Commons;
using GirassoisLocacoes.Entidades;
using GirassoisLocacoes.Negocio;

namespace GirassoisLocacoes.Forms
{
    public partial class frmEspaco : Form
    {
        #region "Variáveis"
        private ENEspaco entidade;
        private bool carregouDados = false;
        #endregion

        #region "Construtor"
        public frmEspaco()
        {
            InitializeComponent();
        }

        private void frmEspaco_Load(object sender, EventArgs e)
        {
            CarregaCombo();
            Limpar();
        }
        #endregion

        #region "Métodos"

        #region "Gravar"
        private void Gravar()
        {
            try
            {
                if (!ValidaDados())
                    return;

                entidade = BuildFormData();

                if (FormHelper.Instance.Pergunta("Confirma inclusão?", false) == DialogResult.No)
                    return;

                NEEspaco.Instance.Gravar(entidade);

                FormHelper.Instance.Informacao("Cadastro realizado com sucesso!");

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
            try
            {
                if (carregouDados)
                {
                    ENEspaco nmEspaco = new ENEspaco();
                    nmEspaco.nmEspaco = txtNomeEspaco.Text;

                    if (FormHelper.Instance.Pergunta("Deseja excluir o cadastro?", true) == DialogResult.No)
                        return;

                    NEEspaco.Instance.Excluir(nmEspaco);

                    FormHelper.Instance.Informacao("Registro excluído com sucesso!");
                    Limpar();
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
            FormHelper.Instance.setControlInitialState(true, true, txtNomeEspaco, txtCEP, txtTelefoneProprietario, txtEndereco, txtComplemento, txtBairro, cboCidade);
            FormHelper.Instance.setControlInitialState(false, false, txtEstado);
            CarregarGrid();
            ConfigurarGrid();
            txtNomeEspaco.Focus();
            carregouDados = false;
        }
        #endregion

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

        #region "CarregarGrid"
        private void CarregarGrid()
        {
            try
            {
                lvwInfo.Columns.Clear();

                lvwInfo.DataSource = NEEspaco.Instance.Obter().Tables[0];
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "ConfigurarGrid"
        private void ConfigurarGrid()
        {
            try
            {
                if (lvwInfo.Rows.Count > 0)
                {
                    lvwInfo.Columns["nmEspaco"].HeaderText = "Nome do Espaço";
                    lvwInfo.Columns["nmProprietario"].Visible = false;
                    lvwInfo.Columns["telProprietario"].Visible = false;
                    lvwInfo.Columns["cep"].Visible = false;
                    lvwInfo.Columns["endEspaco"].Visible = false;
                    lvwInfo.Columns["compl"].Visible = false;
                    lvwInfo.Columns["bairro"].Visible = false;
                    lvwInfo.Columns["cidade"].Visible = false;
                    lvwInfo.Columns["estado"].Visible = false;
                    lvwInfo.Columns["nmEspaco"].Width = 553;

                    if(lvwInfo.Rows.Count > 5)
                        lvwInfo.Columns["nmEspaco"].Width = 536;
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

        #region "ValidaDados"
        private bool ValidaDados()
        {
            if (txtNomeEspaco.Text.Trim() == "")
            {
                FormHelper.Instance.Advertencia("Preencha o nome do espaço!");
                txtNomeEspaco.Focus();
                return false;
            }
            if (txtCEP.Text.Trim() == "")
            {
                FormHelper.Instance.Advertencia("Preencha o CEP!");
                txtCEP.Focus();
                return false;
            }
            if (txtCEP.Text.Trim().Length < 10)
            {
                FormHelper.Instance.Advertencia("CEP Inválido!");
                txtCEP.Focus();
                return false;
            }
            if (txtEndereco.Text.Trim() == "")
            {
                FormHelper.Instance.Advertencia("Preencha o endereço!");
                txtEndereco.Focus();
                return false;
            }
            if (txtBairro.Text.Trim() == "")
            {
                FormHelper.Instance.Advertencia("Preencha o bairro!");
                txtBairro.Focus();
                return false;
            }
            if (cboCidade.Text.Trim() == "")
            {
                FormHelper.Instance.Advertencia("Preencha a cidade!");
                cboCidade.Focus();
                return false;
            }

            return true;
        }
        #endregion

        #region "BuildFormData"
        private ENEspaco BuildFormData()
        {
            ENEspaco pEntidadeDados = new ENEspaco();

            pEntidadeDados.nmEspaco = txtNomeEspaco.Text.Trim();

            if (txtTelefoneProprietario.Text.Trim() != "(  )      -")
                pEntidadeDados.telProprietario = Convert.ToInt64(FormHelper.Instance.LimpaNumeros(txtTelefoneProprietario.Text.Trim()));

            pEntidadeDados.cep = Convert.ToInt64(FormHelper.Instance.LimpaNumeros(txtCEP.Text.Trim()));
            pEntidadeDados.endEspaco = txtEndereco.Text.Trim();

            if (txtComplemento.Text.Trim() != "")
                pEntidadeDados.compl = txtComplemento.Text.Trim();

            pEntidadeDados.bairro = txtBairro.Text.Trim();
            pEntidadeDados.cidade = cboCidade.Text;
            pEntidadeDados.estado = txtEstado.Text.Trim();  

            return pEntidadeDados;

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

        #region "txtNomeProprietario_KeyPress"
        private void txtNomeProprietario_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            const char Space = (char)32;
            e.Handled = (!Char.IsLetterOrDigit(e.KeyChar) || Char.IsDigit(e.KeyChar)) && e.KeyChar != Delete && e.KeyChar != Space;
        }
        #endregion

        #region "frmEspaco_KeyDown"

        #endregion

        #region "lvwInfo_CellDoubleClick"
        private void lvwInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FormHelper.Instance.Pergunta("Deseja carregar os dados?", false) == DialogResult.Yes)
            {
                txtNomeEspaco.Text = Convert.ToString(lvwInfo.CurrentRow.Cells["nmEspaco"].Value);

                if (Convert.ToString(lvwInfo.CurrentRow.Cells["telProprietario"].Value) != "0")
                    txtTelefoneProprietario.Text = Convert.ToString(lvwInfo.CurrentRow.Cells["telProprietario"].Value);

                txtCEP.Text = Convert.ToString(lvwInfo.CurrentRow.Cells["cep"].Value);
                txtEndereco.Text = Convert.ToString(lvwInfo.CurrentRow.Cells["endEspaco"].Value);
                txtComplemento.Text = Convert.ToString(lvwInfo.CurrentRow.Cells["compl"].Value);
                txtBairro.Text = Convert.ToString(lvwInfo.CurrentRow.Cells["bairro"].Value);
                cboCidade.Text = Convert.ToString(lvwInfo.CurrentRow.Cells["cidade"].Value);
                txtEstado.Text = Convert.ToString(lvwInfo.CurrentRow.Cells["estado"].Value);

                carregouDados = true;
                SSTab.SelectTab(0);
                txtNomeEspaco.Enabled = false;
                txtEndereco.Focus();
            }
        }
        #endregion

        #region "frmEspaco_KeyDown"
        private void frmEspaco_KeyDown(object sender, KeyEventArgs e)
        {
            if (SSTab.SelectedIndex == 0)
            {
                switch (e.KeyCode)
                {
                    case Keys.F2:
                        btnPadraoConfirmar.PerformClick();
                        break;
                    case Keys.F12:
                        btnPadraoExcluir.PerformClick();
                        break;
                    case Keys.F3:
                        btnPadraoNovo.PerformClick();
                        break;
                }
            }
        }
        #endregion

        #region "cboCidade_SelectedValueChanged
        private void cboCidade_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboCidade.Text != "")
                txtEstado.Text = "GO";
            else
                txtEstado.Text = "";
        }
        #endregion

        #endregion
    }
}
