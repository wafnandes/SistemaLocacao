using System;
using System.Drawing;
using System.Windows.Forms;
using GirassoisLocacoes.Commons;
using GirassoisLocacoes.Entidades;
using GirassoisLocacoes.Negocio;

namespace GirassoisLocacoes.Forms
{
    public partial class frmPesquisaCliente : Form
    {
        private ENCliente pEntidade = new ENCliente();

        #region "Construtor"
        public frmPesquisaCliente()
        {
            InitializeComponent();
        }
        #endregion

        #region "frmPesquisaCliente_Load"
        private void frmPesquisaCliente_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            ConfigurarGrid();
            lvwInfo.Focus();
        }
        #endregion

        #region "Métodos"

        #region "CarregarGrid"
        private void CarregarGrid()
        {
            try
            {
                ENCliente pEntidadeDados = new ENCliente();
                pEntidadeDados.cSit = true;
                lvwInfo.Columns.Clear();
                Cursor = Cursors.WaitCursor;

                lvwInfo.DataSource = NECliente.Instance.Obter(pEntidadeDados).Tables[0];
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

                    if(lvwInfo.Rows.Count > 5)
                        lvwInfo.Columns["NMCLI"].Width = 330;
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

        #region "GetEntidade"
        public ENCliente GetEntidade()
        {
            return pEntidade;
        }
        #endregion

        #endregion

        #region "Eventos"

        #region "lvwInfo_CellDoubleClick"
        private void lvwInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lvwInfo.Rows.Count > 0)
            {
                if (FormHelper.Instance.Pergunta(Convert.ToBoolean(lvwInfo.CurrentRow.Cells["OCORRENCIA"].Value) ? 
                    "O cliente escolhido tem ocorrência registrada. Deseja continuar mesmo assim?" : "Deseja carregar os dados?", false) == DialogResult.Yes)
                {
                    pEntidade.cpfcnpj = Convert.ToString(lvwInfo.CurrentRow.Cells["CPFCLI"].Value);
                    pEntidade.nome = Convert.ToString(lvwInfo.CurrentRow.Cells["NMCLI"].Value);
                    pEntidade.dataNascimento = Convert.ToDateTime(lvwInfo.CurrentRow.Cells["DTNASC"].Value);
                    pEntidade.telefone = Convert.ToInt64(lvwInfo.CurrentRow.Cells["TELCLI"].Value);

                    if (Convert.ToString(lvwInfo.CurrentRow.Cells["CEPCLI"].Value) != "0")
                        pEntidade.cep = Convert.ToInt64(lvwInfo.CurrentRow.Cells["CEPCLI"].Value);

                    pEntidade.endereco = Convert.ToString(lvwInfo.CurrentRow.Cells["ENDCLI"].Value);
                    pEntidade.complemento = Convert.ToString(lvwInfo.CurrentRow.Cells["COMPL"].Value);
                    pEntidade.bairro = Convert.ToString(lvwInfo.CurrentRow.Cells["BAIRRO"].Value);
                    pEntidade.cidade = Convert.ToString(lvwInfo.CurrentRow.Cells["CIDADE"].Value);
                    pEntidade.estado = Convert.ToString(lvwInfo.CurrentRow.Cells["ESTADO"].Value);
                    pEntidade.ocorrencia = Convert.ToBoolean(lvwInfo.CurrentRow.Cells["OCORRENCIA"].Value);
                    pEntidade.observacao = Convert.ToString(lvwInfo.CurrentRow.Cells["OBSERVACAO"].Value);
                }
            }

            this.Dispose();
        }
        #endregion

        #region "lvwInfo_KeyDown"
        private void lvwInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (lvwInfo.Rows.Count > 0)
                {
                    if (FormHelper.Instance.Pergunta("Deseja carregar os dados?", false) == DialogResult.Yes)
                    {
                        pEntidade.cpfcnpj = Convert.ToString(lvwInfo.CurrentRow.Cells["CPFCLI"].Value);
                        pEntidade.nome = Convert.ToString(lvwInfo.CurrentRow.Cells["NMCLI"].Value);
                        pEntidade.dataNascimento = Convert.ToDateTime(lvwInfo.CurrentRow.Cells["DTNASC"].Value);
                        pEntidade.telefone = Convert.ToInt64(lvwInfo.CurrentRow.Cells["TELCLI"].Value);

                        if (Convert.ToString(lvwInfo.CurrentRow.Cells["CEPCLI"].Value) != "0")
                            pEntidade.cep = Convert.ToInt64(lvwInfo.CurrentRow.Cells["CEPCLI"].Value);

                        pEntidade.endereco = Convert.ToString(lvwInfo.CurrentRow.Cells["ENDCLI"].Value);
                        pEntidade.complemento = Convert.ToString(lvwInfo.CurrentRow.Cells["COMPL"].Value);
                        pEntidade.bairro = Convert.ToString(lvwInfo.CurrentRow.Cells["BAIRRO"].Value);
                        pEntidade.cidade = Convert.ToString(lvwInfo.CurrentRow.Cells["CIDADE"].Value);
                        pEntidade.estado = Convert.ToString(lvwInfo.CurrentRow.Cells["ESTADO"].Value);
                        pEntidade.ocorrencia = Convert.ToBoolean(lvwInfo.CurrentRow.Cells["OCORRENCIA"].Value);
                        pEntidade.observacao = Convert.ToString(lvwInfo.CurrentRow.Cells["OBSERVACAO"].Value);

                        this.Dispose();
                    }
                }
            }
            else
            {
                if (e.KeyCode == Keys.Escape)
                    this.Dispose();
            }
        }
        #endregion

        #region "lvwInfo_DataBindingComplete"
        private void lvwInfo_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
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

        #endregion
    }
}
