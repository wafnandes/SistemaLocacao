using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GirassoisLocacoes.Commons;
using GirassoisLocacoes.Entidades;
using GirassoisLocacoes.Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GirassoisLocacoes.Forms
{
    public partial class frmCliente : Form
    {
        #region "Variáveis"
        ENCliente entidade;
        private bool carregouDados = false;
        private string strCpfAnt = "";
        #endregion

        #region "Construtor"
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            CarregaCombo();
            CarregarGrid();
            ConfigurarGrid();
            Limpar();
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

        #region "Limpar"
        private void Limpar()
        {
            FormHelper.Instance.setControlInitialState(true, true, txtNome, txtCPF, txtDtNasc, txtDtNasc, txtTelefone, txtEndereco, txtBairro, txtCEP, cboCidade, chkObservacoes, txtComplemento, chkCPFVerificado, chkCarregarInativos);
            FormHelper.Instance.setControlInitialState(false, false, txtObservacoes);
            txtCPF.Focus();
            carregouDados = false;
            CarregarGrid();
            ConfigurarGrid();
        }
        #endregion

        #region "ValidaCPFCGC"
        private bool ValidaCPFCGC()
        {
            int intQtDig = 0;

            if (txtCPF.Text.Trim() == "")
                return true;

            intQtDig = FormHelper.Instance.LimpaNumeros(txtCPF.Text).Length;

            if (intQtDig != 11 && intQtDig != 14)
            {
                FormHelper.Instance.Advertencia("Número incorreto de Caracteres.");
                txtCPF.Focus();
                return false;
            }

            if (intQtDig == 11)
            {
                txtCPF.MaxLength = 14;
                txtCPF.Text = FormHelper.Instance.MascaraCPFCNPJ(txtCPF.Text);
            }
            else
            {
                txtCPF.MaxLength = 18;
                txtCPF.Text =  FormHelper.Instance.MascaraCPFCNPJ(txtCPF.Text);
            }

            if (!FormHelper.Instance.ValidaCNPJCPF(txtCPF.Text))
            {
                FormHelper.Instance.Advertencia("CPF ou CNPJ inválido.");
                txtCPF.Focus();
                return false;
            }

            return true;
        }
        #endregion

        #region "Gravar"
        private void Gravar()
        {
            if (!ValidaDados())
                return;

            entidade = BuildFormData();

            if (FormHelper.Instance.Pergunta(!carregouDados ? "Confirma inclusão?" : "Confirma alteração?", false) == DialogResult.No)
                return;

            NECliente.Instance.Gravar(entidade);

            FormHelper.Instance.Informacao(!carregouDados ? "Cadastro realizado com sucesso!" : "Cadastro alterado com sucesso!");

            Limpar();
        }
        #endregion

        #region "Excluir"
        private void Excluir()
        {
            try
            {
                if (carregouDados)
                {
                    entidade = BuildFormData();

                    if (FormHelper.Instance.Pergunta("Deseja excluir o cadastro?", true) == DialogResult.No)
                        return;

                    NECliente.Instance.Excluir(entidade);

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

        #region "ValidaDados"
        private bool ValidaDados()
        {
            if(txtCPF.Text.Trim() == "")
            {
                FormHelper.Instance.Advertencia("Preencha o CPF/CNPJ!");
                txtCPF.Focus();
                return false;
            }
            if(txtCPF.Text.Trim().Length != 14 && txtCPF.Text.Trim().Length != 18)
            {
                FormHelper.Instance.Advertencia("CPF/CNPJ inválido!");
                txtNome.Focus();
                return false;
            }
            if (txtNome.Text.Trim() == "")
            {
                FormHelper.Instance.Advertencia("Preencha o nome do cliente!");
                txtNome.Focus();
                return false;
            }
            if(txtCPF.Text.Trim().Length == 14 && txtDtNasc.Text.Trim() == "/  /")
            {
                FormHelper.Instance.Advertencia("Preencha a data de nascimento!");
                txtDtNasc.Focus();
                return false;
            }
            if (txtCPF.Text.Trim().Length == 14 && txtDtNasc.Text.Trim().Length < 10)
            {
                FormHelper.Instance.Advertencia("Data de nascimento inválida!");
                txtDtNasc.Focus();
                return false;
            }
            if (txtTelefone.Text.Trim() == "(  )      -")
            {
                FormHelper.Instance.Advertencia("Preencha o telefone!");
                txtTelefone.Focus();
                return false;
            }
            if(txtTelefone.Text.Trim().Length < 15)
            {
                FormHelper.Instance.Advertencia("Telefone inválido!");
                txtTelefone.Focus();
                return false;
            }

            return true;
        }
        #endregion

        #region "BuildFormData"
        private ENCliente BuildFormData()
        {
            ENCliente pEntidade = new ENCliente();
            pEntidade.cpfcnpj = Convert.ToString(FormHelper.Instance.LimpaNumeros(txtCPF.Text.Trim()));

            if(txtDtNasc.Text.Trim() != "/  /")
                pEntidade.dataNascimento = Convert.ToDateTime(txtDtNasc.Text.Trim());

            pEntidade.nome = txtNome.Text.Trim();
            pEntidade.telefone = Convert.ToInt64(FormHelper.Instance.LimpaNumeros(txtTelefone.Text.Trim()));

            if (txtCEP.Text.Trim() != ".   -")
                pEntidade.cep = Convert.ToInt64(FormHelper.Instance.LimpaNumeros(txtCEP.Text.Trim()));

            if(txtEndereco.Text.Trim() != "")
                pEntidade.endereco = txtEndereco.Text.Trim();

            if(txtComplemento.Text.Trim() != "")
                pEntidade.complemento = txtComplemento.Text.Trim();

            if(txtBairro.Text.Trim() != "")
                pEntidade.bairro = txtBairro.Text.Trim();

            if (cboCidade.Text != "")
            {
                pEntidade.cidade = cboCidade.Text;
                pEntidade.estado = txtEstado.Text;
            }

            if (chkObservacoes.Checked)
            {
                pEntidade.ocorrencia = chkObservacoes.Checked;
                pEntidade.observacao = txtObservacoes.Text.Trim();
            }

            pEntidade.cSit = false;
            pEntidade.cpfVerificado = chkCPFVerificado.Checked;

            return pEntidade;
        }
        #endregion

        #region "ExisteCadastroCliente"
        private bool ExisteCadastroCliente()
        {
            try
            {
                ENCliente pCadastro = new ENCliente();
                DataSet dsCliente = new DataSet();

                if (txtCPF.Text.Trim() == "")
                    return false;

                pCadastro.cpfcnpj = Convert.ToString(FormHelper.Instance.LimpaNumeros(txtCPF.Text.Trim()));

                dsCliente = NECliente.Instance.ObterClienteCPF(pCadastro);

                if (dsCliente.Tables.Count > 0 && !carregouDados)
                {
                    FormHelper.Instance.Advertencia("Já existe um cadastro para o CPF informado!\nOs dados serão carregados!");

                    txtCPF.Text = FormHelper.Instance.MascaraCPFCNPJ(dsCliente.Tables[0].Rows[0]["CPFCLI"].ToString());
                    txtNome.Text = dsCliente.Tables[0].Rows[0]["NMCLI"].ToString();
                    txtDtNasc.Text = dsCliente.Tables[0].Rows[0]["DTNASC"].ToString();
                    txtTelefone.Text = FormHelper.Instance.MascaraTelefone(dsCliente.Tables[0].Rows[0]["TELCLI"].ToString());
                    txtCEP.Text = FormHelper.Instance.MascaraCEP(dsCliente.Tables[0].Rows[0]["CEPCLI"].ToString());
                    txtEndereco.Text = dsCliente.Tables[0].Rows[0]["ENDCLI"].ToString();
                    txtComplemento.Text = dsCliente.Tables[0].Rows[0]["COMPL"].ToString();
                    txtBairro.Text = dsCliente.Tables[0].Rows[0]["BAIRRO"].ToString();
                    cboCidade.Text = dsCliente.Tables[0].Rows[0]["CIDADE"].ToString();
                    txtEstado.Text = dsCliente.Tables[0].Rows[0]["ESTADO"].ToString();
                    chkObservacoes.Checked = Convert.ToBoolean(dsCliente.Tables[0].Rows[0]["OCORRENCIA"]);
                    txtObservacoes.Text = dsCliente.Tables[0].Rows[0]["OBSERVACAO"].ToString();
                    chkCPFVerificado.Checked = Convert.ToBoolean(dsCliente.Tables[0].Rows[0]["CPFVerificado"]);

                    txtTelefone.MaxLength = txtTelefone.Text.Trim().Length;
                    txtCPF.MaxLength = 18;

                    strCpfAnt = txtCPF.Text.Trim();

                    carregouDados = true;

                    return true;
                }
                if (carregouDados)
                    return true;

                

                return false;
            }
            catch (Exception ex)
            {
                FormHelper.Instance.Critica("Ocorreu um erro ao consultar o cadastro do cliente. \nErro: " + ex.Message);
                return true;
            }
        }
        #endregion

        #region "CarregarGrid"
        private void CarregarGrid()
        {
            try
            {
                ENCliente pEntidadeDados = new ENCliente();
                pEntidadeDados.cSit = chkCarregarInativos.Checked;
                lvwInfo.Columns.Clear();
                Cursor = Cursors.WaitCursor;
                
                lvwInfo.DataSource = NECliente.Instance.Obter(pEntidadeDados).Tables[0];
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
        #endregion

        #region "ConfigurarGrid"
        private void ConfigurarGrid()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if(lvwInfo.Rows.Count > 0 ) 
                {
                    lvwInfo.Columns["NMCLI"].HeaderText = "Nome";
                    lvwInfo.Columns["CPFCLI"].HeaderText = "CPF/CNPJ";
                    lvwInfo.Columns["TELCLI"].HeaderText = "Telefone";
                    lvwInfo.Columns["DTNASC"].Visible = false;
                    lvwInfo.Columns["CEPCLI"].Visible = false;
                    lvwInfo.Columns["ENDCLI"].Visible = false;
                    lvwInfo.Columns["COMPL"].Visible = false;
                    lvwInfo.Columns["BAIRRO"].Visible = false;
                    lvwInfo.Columns["CIDADE"].Visible = false;
                    lvwInfo.Columns["ESTADO"].Visible = false;
                    lvwInfo.Columns["OCORRENCIA"].Visible = false;
                    lvwInfo.Columns["OBSERVACAO"].Visible = false;
                    lvwInfo.Columns["cSIT"].Visible = false;
                    lvwInfo.Columns["CPFVERIFICADO"].Visible = false;
                    lvwInfo.Columns["NMCLI"].Width = 345;
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

        #endregion

        #region "Eventos"

        #region "txtCPF_KeyPress"
        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
        #endregion

        #region "txtCPF_Enter"
        private void txtCPF_Enter(object sender, EventArgs e)
        {
            txtCPF.SelectAll();
        }
        #endregion

        #region "txtCPF_Leave"
        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (!ValidaCPFCGC())
                return;

            if (txtCPF.Text.Trim() != strCpfAnt)
            {
                FormHelper.Instance.setControlInitialState(true, true, txtNome, txtDtNasc, txtDtNasc, txtTelefone, txtEndereco, txtBairro, txtCEP, cboCidade, chkObservacoes, txtComplemento, chkCPFVerificado, chkCarregarInativos);
                FormHelper.Instance.setControlInitialState(false, false, txtObservacoes);
            }

            if(ExisteCadastroCliente())
                return;

            if (txtCPF.Text.Trim().Length > 14)
                txtDtNasc.Enabled = false;
        }
        #endregion

        #region "txtNome_KeyPress"
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            const char Space = (char)32;
            e.Handled = (!Char.IsLetterOrDigit(e.KeyChar) || Char.IsDigit(e.KeyChar)) && e.KeyChar != Delete && e.KeyChar != Space;
        }
        #endregion

        #region "txtNome_Enter"
        private void txtNome_Enter(object sender, EventArgs e)
        {
            txtNome.SelectAll();
        }
        #endregion

        #region "txtDtNasc_KeyPress"
        private void txtDtNasc_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
        #endregion

        #region "txtDtNasc_Leave"
        private void txtDtNasc_Leave(object sender, EventArgs e)
        {
            txtDtNasc.Text = FormHelper.Instance.MascaraData(txtDtNasc.Text.Trim());
        }
        #endregion

        #region "txtDtNasc_Enter"
        private void txtDtNasc_Enter(object sender, EventArgs e)
        {
            txtDtNasc.SelectAll();    
        }
        #endregion

        #region "txtTelefone_KeyPress"
        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
        #endregion

        #region "txtTelefone_Leave"
        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            txtTelefone.Text = FormHelper.Instance.MascaraTelefone(txtTelefone.Text.Trim());
        }
        #endregion

        #region "chkObservacoes_CheckedChanged"
        private void chkObservacoes_CheckedChanged(object sender, EventArgs e)
        {
            txtObservacoes.Enabled = chkObservacoes.Checked;
        }
        #endregion

        #region "txtCEP_KeyPress"
        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
        #endregion

        #region "txtCEP_Leave"
        private void txtCEP_Leave(object sender, EventArgs e)
        {
            txtCEP.Text = FormHelper.Instance.MascaraCEP(txtCEP.Text);
        }
        #endregion

        #region "frmCliente_KeyDown"
        private void frmCliente_KeyDown(object sender, KeyEventArgs e)
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

        #region "lvwInfo_DataBindingComplete"
        private void lvwInfo_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (lvwInfo.Rows.Count > 0)
                lvwInfo.Rows[0].Selected = false;

            foreach (DataGridViewRow row in lvwInfo.Rows)
            {
                if (Convert.ToBoolean(row.Cells["OCORRENCIA"].Value))
                {
                    lvwInfo.Rows[row.Index].DefaultCellStyle.BackColor = Color.Firebrick;
                    lvwInfo.Rows[row.Index].DefaultCellStyle.ForeColor = Color.White;
                }
            }
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

                    txtCPF.Text = FormHelper.Instance.MascaraCPFCNPJ(Convert.ToString(lvwInfo.CurrentRow.Cells["CPFCLI"].Value));
                    txtNome.Text = Convert.ToString(lvwInfo.CurrentRow.Cells["NMCLI"].Value);
                    txtDtNasc.Text = Convert.ToString(lvwInfo.CurrentRow.Cells["DTNASC"].Value);
                    txtTelefone.Text = FormHelper.Instance.MascaraTelefone(Convert.ToString(lvwInfo.CurrentRow.Cells["TELCLI"].Value));

                    if (Convert.ToString(lvwInfo.CurrentRow.Cells["CEPCLI"].Value) != "0")
                        txtCEP.Text = Convert.ToString(lvwInfo.CurrentRow.Cells["CEPCLI"].Value);

                    txtEndereco.Text = Convert.ToString(lvwInfo.CurrentRow.Cells["ENDCLI"].Value);
                    txtComplemento.Text = Convert.ToString(lvwInfo.CurrentRow.Cells["COMPL"].Value);
                    txtBairro.Text = Convert.ToString(lvwInfo.CurrentRow.Cells["BAIRRO"].Value);
                    cboCidade.Text = Convert.ToString(lvwInfo.CurrentRow.Cells["CIDADE"].Value);
                    txtEstado.Text = Convert.ToString(lvwInfo.CurrentRow.Cells["ESTADO"].Value);
                    chkObservacoes.Checked = Convert.ToBoolean(lvwInfo.CurrentRow.Cells["OCORRENCIA"].Value);
                    txtObservacoes.Text = Convert.ToString(lvwInfo.CurrentRow.Cells["OBSERVACAO"].Value);
                    chkCPFVerificado.Checked = Convert.ToBoolean(lvwInfo.CurrentRow.Cells["CPFVERIFICADO"].Value);

                    SSTab.SelectTab(0);
                    
                    strCpfAnt = txtCPF.Text.Trim();
                    txtNome.Focus();
                }
            }
        }
        #endregion

        #region "chkCarregarInativos_CheckedChanged"
        private void chkCarregarInativos_CheckedChanged(object sender, EventArgs e)
        {
            CarregarGrid();
            ConfigurarGrid();
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
            Limpar();
        }
        #endregion

        #region "SSTab_SelectedIndexChanged"
        private void SSTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SSTab.SelectedIndex == 1)
            {
                if (lvwInfo.Rows.Count == 0)
                {
                    FormHelper.Instance.Critica("Não existem clientes a serem consultados!");
                    SSTab.SelectedIndex = 0;
                    return;
                }

                btnPadraoConfirmar.Visible = false;
                btnPadraoExcluir.Visible = false;
                btnPadraoNovo.Visible = false;
                imgLegenda.Visible = true;
                lblClienteOcorrencia.Visible = true;
            }
            else
            {
                btnPadraoConfirmar.Visible = true;
                btnPadraoExcluir.Visible = true;
                btnPadraoNovo.Visible = true;
                imgLegenda.Visible = false;
                lblClienteOcorrencia.Visible = false;
            }
        }
        #endregion

        #endregion

    }
}